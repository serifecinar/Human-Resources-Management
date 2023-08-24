using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Utils
{
    static public class PageChange
    {
        static public void Change(Panel panel, Form Main, Form ChildForm)
        {
            ChildForm.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(ChildForm);
            ChildForm.Show();

            foreach (Form activeForm in panel.Controls)
            {
                activeForm.Size = panel.Size;
            }
        }
        static public void Close(Panel panel, Form Main, TableLayoutPanel tableLayoutPanel)
        {
            panel.Controls.Clear();
            panel.Controls.Add(tableLayoutPanel);
            tableLayoutPanel.Show();


        }
    }
}
