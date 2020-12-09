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
        /// <summary>
		/// SQLDafault
		/// <para>[0] Select id card in dataBase INPUT: {IDCARD}</para>
        /// <para>[1] INPSERT Customer INPUT: {NAME} {IDCARD} {ADDRESS} {PHONENUM}</para>
        /// <para>ddd</para>
		/// </summary>
		private String[] SQLDefault = new String[]
        {
			//[0] Select id card in dataBase INPUT: {IDCARD}
            $"SELECT IDcardnum \r\n"+
            "FROM tblCustomers \r\n"+
            "WHERE IDcardnum = {IDCARD}; \r\n\r\n",
            //[1] INPSERT Customer INPUT: {NAME} {IDCARD} {ADDRESS} {PHONENUM}
			"INSERT INTO tblCustomers(Customername , IDcardnum , Address , PhoneNumber)  \r\n"+
            "VALUES ('{NAME}','{IDCARD}','{ADDRESS}','{PHONENUM}'); \r\n",
        };
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
                DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]
                    .Replace("{IDCARD}", TB_customer_idcard.Text));
                if (dt.Rows.Count < 1)
                {
                    // [1] INPSERT Customer INPUT: {NAME} {IDCARD} {ADRESS} {PHONENUM}
                    ShopApp.SQL.InputSQLMSSQL(SQLDefault[1]
                        .Replace("{NAME}", TB_Customer_name.Text)
                        .Replace("{IDCARD}" , TB_customer_idcard.Text)
                        .Replace("{ADDRESS}", TB_customer_address.Text)
                        .Replace("{PHONENUM}", TB_customer_Phonenum.Text));
                    MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้วครับ");
                    TB_customer_address.Text = "";
                    TB_customer_idcard.Text = "";
                    TB_customer_Phonenum.Text = "";
                    TB_Customer_name.Text = "";
                }
                else
                {
                    MessageBox.Show("เลขบัตรประชาชนนี้มีอยู่ในระบบแล้วครับ");
                }

            }
        }

        private void addcustomer_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this , panel1);
        }

        private void BCustomer_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }
    }
}
