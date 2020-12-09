using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop.Shop_edit
{
    public partial class editCustomer : Form
    {
        public editCustomer()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void editCustomer_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void B_Customer_Select_Click(object sender, EventArgs e)
        {
            TB_Customer_Show_IDcard.Text = "";
            TB_Customer_Show_name.Text = "";
            ShopApp.Shop.SelectCustomer Select = new ShopApp.Shop.SelectCustomer();
            Select.Show();
        }

        private void editCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            TB_Customer_Show_name.Text = ShopApp.Class.CustomerInformation.Name;
            TB_Customer_Show_IDcard.Text = ShopApp.Class.CustomerInformation.Idcard;
        }

        private void B_Customer_Save_Click(object sender, EventArgs e)
        {
            DataTable dtCheck = ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT IDcardnum \r\n" +
            "FROM tblCustomers" +
            "WHERE IDcardnum = " + TB_Customer_Change_Idcard.Text + "; \r\n\r\n");
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT * \r\n" +
            "FROM tblCustomers; \r\n\r\n");
            if (dtCheck.Rows.Count < 1)
            {
                if (TB_Customer_Change_Address.Text == "" || TB_Customer_Change_Idcard.Text == "" || TB_Customer_Change_name.Text == ""|| TB_Customer_Change_PhoneNum.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครับก่อน (แพทต่อไปจะมาอัพเดทให้อัพอันไหนไม่อัพอันไหนก็ได้)");
                }
                else
                {
                    SQL.InputSQLMSSQL(//[] INPUT: 
                    "UPDATE tblCustomers \r\n" +
                    "SET Customername='"+TB_Customer_Change_name.Text+"', IDcardnum='"+TB_Customer_Change_Idcard.Text+"" +
                    "' , Address = '"+TB_Customer_Change_Address.Text+"' , PhoneNumber = '"+TB_Customer_Change_PhoneNum.Text+"' \r\n" +
                    "WHERE IDcardnum = "+TB_Customer_Show_IDcard.Text+"; \r\n\r\n");
                    MessageBox.Show("แก้ไขเรียบร้อย");
                    ShopApp.Class.CustomerInformation.Idcard = "";
                    ShopApp.Class.CustomerInformation.Name = "";
                    ShopApp.Class.CustomerInformation.ID = "";
                    ShopApp.Class.CustomerInformation.phonenum = "";
                    TB_Customer_Change_Address.Text = "";
                    TB_Customer_Change_Idcard.Text = "";
                    TB_Customer_Change_name.Text = "";
                    TB_Customer_Change_PhoneNum.Text = "";
                    TB_Customer_Show_IDcard.Text = "";
                    TB_Customer_Show_name.Text = "";
                }
            }
            else
            {
                MessageBox.Show("เลขบัตรประชาชนนี้มีผุ็ใช้แล้ว");
            }



        }
    }
}
