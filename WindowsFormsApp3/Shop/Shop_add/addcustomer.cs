using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop.add
{
    public partial class addcustomer : Form
    {
        public addcustomer()
        {
            InitializeComponent();
        }

        private void TBnamecustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCustomer_Click(object sender, EventArgs e)
        {
            if (TB_customer_address.Text == "" || TB_customer_idcard.Text == "" || TB_Customer_name.Text == "" || TB_customer_Phonenum.Text == "")
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วนด้วยครับ.");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "INSERT INTO tblCustomers(Customername , IDcardnum , Address , PhoneNumber) \r\n" +
                "VALUES ('" + TB_Customer_name.Text + "','" + TB_customer_idcard.Text + "','" + TB_customer_address.Text + "','" + TB_customer_Phonenum.Text + "'); \r\n\r\n");
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้วครับ");
                TB_customer_address.Text = "";
                TB_customer_idcard.Text = "";
                TB_customer_Phonenum.Text = "";
                TB_Customer_name.Text = "";
            }
        }
    }
}
