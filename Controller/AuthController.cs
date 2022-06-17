
using TE11Manager.DataType;
using TE11Manager.Util;
using Newtonsoft.Json;
using System.Windows;
using System;

namespace TE11Manager.Controller
{
    #nullable enable
    public class AuthController : Core.IController
    {
        #region attributes
        #endregion
        #region constructor
        #endregion
        #region methods
        public User GetUserData()
        {
            string token = LocalStorage.GetItem("token");
            string tokenUser = "{\"tokenUser\":" + token + "}";
            string accountJSON = HttpRequestCommon.PostDataJSON("user", tokenUser);
            try
            {
                UserInfoForUserLogin currentUserInfo = JsonConvert.DeserializeObject<UserInfoForUserLogin>(accountJSON);
                if(currentUserInfo!= null)
                {
                    return currentUserInfo.currentUser;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public bool Login(string userName, string password)
        {
            Account currentAccount = new Account(userName, password);
            string result = HttpRequestCommon.PostDataJSONIfFalseReturnStatusCode("user/login", currentAccount.ToJSONForLogin());

            switch (result)
            {
                //all that shit status is made by the creater of xNet :v example: status 402 = PaymentRequired
                case "PaymentRequired":
                    {
                        MessageBox.Show("Password is incorected");
                        return false ;
                    }
                case "Forbidden":
                    {
                        MessageBox.Show("Account has been banned");
                        return false;
                    }
                case "NotFound":
                    {
                        MessageBox.Show("Account is not exist");
                        return false;
                    }
                default:
                    {
                        bool isSavedToken = LocalStorage.SaveJSONData(result);
                        if (isSavedToken)
                        {
                            GetUserData();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                            return false;
                        }
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
        public void Start()
        {
        }
        #endregion
    }
}