
using System;
using System.Windows.Forms;
using TE11Manager.View;

namespace TE11Manager.Core
{
    public class View : Form
    {
        virtual public void Render()
        {
            this.Show();
        }

        public static implicit operator View(FormDashboard v)
        {
            throw new NotImplementedException();
        }
    }
}
