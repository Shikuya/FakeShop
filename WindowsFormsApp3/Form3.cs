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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Checkname = SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT Username \r\n" +
            "FROM tblLogin \r\n" +
            "WHERE Username = '"+ textBox1.Text +"' ; \r\n\r\n" );
            if (Checkname.Rows.Count == 0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SQL.InputSQLMSSQL("INSERT INTO tblLogin (Username , password ,Level) \r\n" +
                    "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "' , '1'); \r\n\r\n");
                    MessageBox.Show("Register Success");
                    Form2 fm2 = new Form2();
                    fm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("This username is already taken.", "This username is already taken.",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.SelectAll();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }
    }
}
