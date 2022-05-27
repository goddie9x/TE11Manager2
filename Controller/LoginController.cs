
using TE11Manager.DataType;
using TE11Manager.Util;
using Newtonsoft.Json;
using TE11Manager.View;
using System.Windows;

namespace TE11Manager.Controller
{
    #nullable enable
    public class LoginController : Core.Controller
    {
        #region attributes
        public static LoginController instance;
        public static Account account = GetUserData();
        #endregion
        #region constructor
        public LoginController()
        {
            LoginController.instance = this;
        }
        #endregion
        #region methods
        private static Account GetUserData()
        {
            string token = LocalStorage.GetItem("token");
            string tokenUser = "{\"tokenUser\":" + token + "}";
            string accountJSON = HttpRequestCommon.PostDataJSON("user", tokenUser);
            Account account = JsonConvert.DeserializeObject<Account>(accountJSON);
            return account;
        }
        public void Login(string userName, string password)
        {
            Account currentAccount = new Account(userName, password);
            string result = HttpRequestCommon.PostDataJSONIfFalseReturnStatusCode("user/login", currentAccount.ToJSONForLogin());

            switch (result)
            {
                //all that shit status is made by the creater of xNet :v example: status 402 = PaymentRequired
                case "PaymentRequired":
                    {
                        MessageBox.Show("Password is incorected");
                        break ;
                    }
                case "Forbidden":
                    {
                        MessageBox.Show("Account has been banned");
                        break ;
                    }
                case "NotFound":
                    {
                        MessageBox.Show("Account is not exist");
                        break ;
                    }
                default:
                    {
                        bool isSavedToken = LocalStorage.SaveJSONData(result);
                        if (isSavedToken)
                        {
                            if (FormLogin.Instance != null)
                            {
                                FormLogin.Instance.Hide();
                            }
                            if (MainController.instance == null)
                            {
                                MainController.instance = new MainController();
                            }
                            MainController.instance.Start();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                        }
                        break;
                    }
            }
        }
        public bool Register(string userName, string password, string email)
        {
            Account currentAccount = new Account(userName, password, email);

            string token = HttpRequestCommon.PostDataJSON("user/register", currentAccount.ToJSONForLogin());
            if (token != null)
            {
               return LocalStorage.SaveJSONData(token);
            }
            return false;
        }
        override public void Start()
        {
            LoginController.account = GetUserData();
            if (account != null)
            {
                FormLogin.Instance.Hide();
                if (MainController.instance == null)
                {
                    MainController.instance = new MainController();
                }
                MainController.instance.Start();
            }
            else
            {
                if (FormLogin.Instance == null)
                {
                    FormLogin.Instance = new FormLogin();
                }
                FormLogin.Instance.Show();
            }
        }
        #endregion
    }
}