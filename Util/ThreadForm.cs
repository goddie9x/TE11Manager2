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
    }
}
