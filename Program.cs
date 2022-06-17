using System.Windows.Forms;
using TE11Manager.View;

namespace TE11Manager
{
    internal static class Program
    {
        public static FormLogin login = new FormLogin();
        static void Main()
        {
            Application.Run(login);
        }
    }
}