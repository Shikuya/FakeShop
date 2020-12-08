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
    public partial class Form2 : Form
    {
        /// <summary>
		/// SQLDafault
		/// <para>//[0] INPUT: Login Check user pass</para>
		/// </summary>

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            DataTable userpass = ShopApp.SQL.InputSQLMSSQL("SELECT Userid  \r\n" +
            "FROM tbllogin  \r\n" +
            "WHERE username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'; \r\n");
            if (userpass.Rows.Count == 1)
            {
                ShopApp.Class.AccountInfo.AccountNo = userpass.Rows[0][0].ToString();
                MessageBox.Show("Login Success");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong name or password");
                textBox2.SelectAll();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:/Users/kaijew/source/repos/FakeShop/WindowsFormsApp3/Resources/login.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:/Users/kaijew/source/repos/FakeShop/WindowsFormsApp3/Resources/login1-removebg-preview.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                LoadInformation();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                textBox2.Select();
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
