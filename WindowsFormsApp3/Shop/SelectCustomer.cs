using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop
{
    public partial class SelectCustomer : Form
    {
        public static String ReturnID = "";
        public static Form FormNew;


        public SelectCustomer()
        {
            InitializeComponent();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT TOP(50)* \r\n" +
            "FROM Account.dbo.tblCustomers; \r\n\r\n");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                DGVInformation.Rows.Add(dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][4], dt.Rows[a][3] , dt.Rows[a][0]);
            }

        }

        public static String Showed()
        {
            ReturnID = "";
            FormNew = new SelectCustomer();
            FormNew.ShowDialog();
            return ReturnID;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DGVInformation.Rows.Clear();
            //[] INPUT: 
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT TOP (50) * \r\n" +
            "FROM Account.dbo.tblCustomers \r\n" +
            "WHERE Customername LIKE '" + TB_Select.Text + "%' or IDcardnum LIKE '" + TB_Select.Text + "%' or Address LIKE '" + TB_Select.Text + "%' or PhoneNumber LIKE '" + TB_Select.Text + "%'; \r\n\r\n");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                DGVInformation.Rows.Add(dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][4], dt.Rows[a][3] , dt.Rows[a][0]);
            }
        }

        private void a(object sender, EventArgs e)
        {

        }

        private void DGVInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DGVInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = DGVInformation.Rows[rowIndex];
            ShopApp.Class.CustomerInformation.Name = row.Cells[0].Value.ToString();
            ShopApp.Class.CustomerInformation.Idcard = row.Cells[1].Value.ToString();
            ShopApp.Class.CustomerInformation.phonenum = row.Cells[2].Value.ToString();
            ReturnID = row.Cells[4].Value.ToString();
            this.Hide();
        }

        private void SelectCustomer_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

