using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Class
{
    class Formulatwo
    {
        //ReSize Panel  -- > Center {Form} {panel}
        public static void CenterSize(Form F1, Panel P1)
        {
            P1.Location = new Point((F1.Width / 2) - (P1.Size.Width / 2), F1.Height / 2 - (P1.Size.Height / 2));
        }
        //Chage Page {main form} {to from}
        public static void ChangPage(Form MainForm, Form SubForm)
        {
            SubForm.Owner = MainForm;
            SubForm.MdiParent = MainForm;
            SubForm.Show();
            SubForm.WindowState = FormWindowState.Maximized;
            SubForm.Select();
            SubForm.MaximizeBox = false;
            SubForm.MinimizeBox = false;
            SubForm.FormBorderStyle = FormBorderStyle.None;
            ShopApp.Class.CustomerInformation.Name = "";
            ShopApp.Class.CustomerInformation.Idcard = "";
        }
    }
}
