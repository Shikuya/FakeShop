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
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT TOP(50)* \r\n" +
            "FROM tblCustomers; \r\n\r\n");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                DGVInformation.Rows.Add(dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][4], dt.Rows[a][3]);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DGVInformation.Rows.Clear();
            //[] INPUT: 
            DataTable dt =ShopApp.SQL.InputSQLMSSQL("SELECT TOP (50) * \r\n" +
            "FROM tblCustomers \r\n" +
            "WHERE Customername LIKE '"+TB_Select.Text+ "%' or IDcardnum LIKE '" + TB_Select.Text + "%' or Address LIKE '" + TB_Select.Text + "%' or PhoneNumber LIKE '" + TB_Select.Text + "%'; \r\n\r\n");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                DGVInformation.Rows.Add(dt.Rows[a][1],dt.Rows[a][2],dt.Rows[a][4],dt.Rows[a][3]);
            }
        }

        private void a(object sender, EventArgs e)
        {

        }
    }
}
