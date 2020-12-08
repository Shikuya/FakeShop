using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        /// <summary>
		/// SQLDafault
		/// <para>//[0] INPUT: Check Level</para>
		/// </summary>
		private String[] SQLDefault = new String[]
        {
			//[0] INPUT: Check Level
			"SELECT Level \r\n"+
            "FROM tblLogin \r\n"+
            "WHERE Userid = "+ShopApp.Class.AccountInfo.AccountNo+"; \r\n\r\n",
        };
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        { 
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]);
            if (e.KeyCode == Keys.P)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) >= 1)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("คุณไม่มีสิทการเข้าถึงสิ้งนี้");
                }
            }
            else if (e.KeyCode == Keys.S)
            {

                if (Convert.ToInt32(dt.Rows[0][0]) > 2)
                {
                    ShopApp.Shop.Mainshop mshop = new ShopApp.Shop.Mainshop();
                    mshop.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("คุณไม่มีสิทการเข้าถึงสิ้งนี้");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]);
            if (Convert.ToInt32(dt.Rows[0][0]) >= 1)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("คุณไม่มีสิทการเข้าถึงสิ้งนี้");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]);
            if (Convert.ToInt32(dt.Rows[0][0]) > 2)
            {
                ShopApp.Shop.Mainshop mshop = new ShopApp.Shop.Mainshop();
                mshop.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("คุณไม่มีสิทการเข้าถึงสิ้งนี้");
            }
        }
    }
}
