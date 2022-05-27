using TE11Manager.Controller;

namespace TE11Manager
{
    internal static class Program
    {
        public static readonly string MainApi = "https://te11api.herokuapp.com/";
        static void Main()
        {
            /*LoginController loginController = new LoginController();
            loginController.Start();*/
            MainController mainController = new MainController();
            mainController.Start();
        }
    }
}