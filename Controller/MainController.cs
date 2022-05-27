using TE11Manager.View;
using TE11Manager.DataType;
using Newtonsoft.Json;
using TE11Manager.Util;
namespace TE11Manager.Controller
{
    public class MainController: Core.Controller
    {
        public static MainController instance;
        public static Dashboard dashboard;
        public static User[] users;
        public static User user;
        public static DataType.Post[] posts;
        public static Schedule[] schedules;
        public MainController()
        {
            MainController.GetData("dashboard");
            MainController.instance = this;
        }
        public static void GetData(string dataType)
        {
            string jsonValue = HttpRequestCommon.GetDataJSON(Program.MainApi + dataType);
            switch (dataType)
            {
                case "dashboard":
                    {
                        dashboard = JsonConvert.DeserializeObject<Dashboard>(jsonValue);
                        break;
                    }
                case "schedules":
                    {
                        schedules = JsonConvert.DeserializeObject<Schedule[]>(jsonValue);
                        break;
                    }
                case "user":
                    {
                        user = JsonConvert.DeserializeObject<User>(jsonValue);
                        break;
                    }
                case "users":
                    {
                        users = JsonConvert.DeserializeObject<User[]>(jsonValue);
                        break;
                    }
                case "post":
                    {
                        posts = JsonConvert.DeserializeObject<Post[]>(jsonValue);
                        break;
                    }
            }
        }
        public void UpdateDataForType(string dataType)
        {
            string jsonValue = HttpRequestCommon.GetDataJSON(Program.MainApi + dataType);
            switch (dataType)
            {
                case "dashboard":
                    {
                        dashboard = JsonConvert.DeserializeObject<Dashboard>(jsonValue);
                        break;
                    }
                case "schedules":
                    {
                        schedules = JsonConvert.DeserializeObject<Schedule[]>(jsonValue);
                        break;
                    }
                case "user":
                    {
                        user = JsonConvert.DeserializeObject<User>(jsonValue);
                        break;
                    }
                case "users":
                    {
                        users = JsonConvert.DeserializeObject<User[]>(jsonValue);
                        break;
                    }
                case "post":
                    {
                        posts = JsonConvert.DeserializeObject<Post[]>(jsonValue);
                        break;
                    }
            }
        }
        public void DeleteDataForType(string dataType, string _Id)
        {
            string jsonValue = HttpRequestCommon.PostDataJSON(Program.MainApi + dataType+ _Id + "?_method=DELETE");
            switch (dataType)
            {
                case "dashboard":
                    {
                        dashboard = JsonConvert.DeserializeObject<Dashboard>(jsonValue);
                        break;
                    }
                case "schedules":
                    {
                        schedules = JsonConvert.DeserializeObject<Schedule[]>(jsonValue);
                        break;
                    }
                case "user":
                    {
                        user = JsonConvert.DeserializeObject<User>(jsonValue);
                        break;
                    }
                case "users":
                    {
                        users = JsonConvert.DeserializeObject<User[]>(jsonValue);
                        break;
                    }
                case "post":
                    {
                        posts = JsonConvert.DeserializeObject<Post[]>(jsonValue);
                        break;
                    }
            }
        }
        public void AddDataDataForType(string dataType)
        {
            string jsonValue = HttpRequestCommon.GetDataJSON(Program.MainApi + dataType);
            switch (dataType)
            {
                case "dashboard":
                    {
                        dashboard = JsonConvert.DeserializeObject<Dashboard>(jsonValue);
                        break;
                    }
                case "schedules":
                    {
                        schedules = JsonConvert.DeserializeObject<Schedule[]>(jsonValue);
                        break;
                    }
                case "user":
                    {
                        user = JsonConvert.DeserializeObject<User>(jsonValue);
                        break;
                    }
                case "users":
                    {
                        users = JsonConvert.DeserializeObject<User[]>(jsonValue);
                        break;
                    }
                case "post":
                    {
                        posts = JsonConvert.DeserializeObject<Post[]>(jsonValue);
                        break;
                    }
            }
        }
        public void Logout()
        {
            if (FormDashboard.Instance != null)
            {
                FormDashboard.Instance.Hide();
            }
            if (FormLogin.Instance == null)
            {
                FormLogin.Instance = new FormLogin();
            }
            FormLogin.Instance.Show();
        }
        override public void Start()
        {
            if(FormMain.instance==null)
                FormMain.instance = new FormMain();
            FormMain.instance.Show();
        }
    }
}
