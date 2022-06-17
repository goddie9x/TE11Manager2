using System.Threading;
using System.Windows.Forms;

namespace TE11Manager.Util
{
    internal static class ThreadForm
    {
        public static void Run(Form formNeedToRun)
        {
            Thread thread = new Thread(()=> {
                Application.Run(formNeedToRun);
            });
            thread.Start();
        }
        public static void HideFormInstanceIfExit(ref Form formNeedToHide)
        {
            if (formNeedToHide != null)
            {
                formNeedToHide.Hide();
            }
        }
        public static void ShowOtherFormAndHideCurrentForm(Form formNeedToShow, Form formNeedToHide, bool isClose = false) {
            if (formNeedToShow != null)
            {
                formNeedToShow.Show();
                formNeedToShow.Activate();
                formNeedToShow.Focus();
                if (isClose)
                {
                    formNeedToHide.Close();
                }
                else
                {
                    formNeedToHide.Hide();
                }
            }
        }
    }
}
