using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop.Shop_delete
{
    public partial class deleteCustomer : Form
    {
        public deleteCustomer()
        {
            InitializeComponent();
        }

        private void B_Customer_Delete_Click(object sender, EventArgs e)
        {
            if(TB_Customer_IDcard.Text == "" || TB_Customer_name.Text == "")
            {
                MessageBox.Show("กรุณาเลือกก่อนนะครับ และรอข้อความขึ้นในช่องนะครับ");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(
                    "DELETE FROM tblCustomers \r\n" +
                    "WHERE IDcardnum = " + TB_Customer_IDcard.Text+"; \r\n\r\n");
                MessageBox.Show("ลบผู้ใช้นี้เรียบร้อยแล้วครับ");
                TB_Customer_IDcard.Text = "";
                TB_Customer_name.Text = "";
                ShopApp.Class.CustomerInformation.Idcard = "";
                ShopApp.Class.CustomerInformation.Name = "";
            }

        }

        private void B_Customer_Select_Click(object sender, EventArgs e)
        {
            TB_Customer_name.Text = "";
            TB_Customer_IDcard.Text = "";
            ShopApp.Shop.SelectCustomer Select = new ShopApp.Shop.SelectCustomer();
            Select.Show();
        }

        private void deleteCustomer_MouseHover(object sender, EventArgs e)
        {

        }

        private void deleteCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            TB_Customer_name.Text = ShopApp.Class.CustomerInformation.Name;
            TB_Customer_IDcard.Text = ShopApp.Class.CustomerInformation.Idcard;

        }

        private void B_Customer_Delete_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void deleteCustomer_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }
    }
}