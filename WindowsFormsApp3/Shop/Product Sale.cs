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

    public partial class Product_Sale : Form
    {
        /// <summary>
        /// SQLDafault
        /// <para>[0] Select name and id card customer INPUT: {CUSTOMERID}</para>
        /// <para>[1] Select Event INPUT: {Eventname}</para>
        /// <para>[2] Select Product INPUT: {CodeProduct} </para>
        /// </summary>
        private String[] SQLDefault = new String[]
    {
			//[0] Select name and id card customer INPUT: {CUSTOMERID} 
			"Select Customername , IDcardnum \r\n"+
            "FROM Account.dbo.tblCustomers \r\n"+
            "Where CustomerID = {CUSTOMERID}; \r\n\r\n",

            //[1] Select Event INPUT: {Eventname} 
			"SELECT EventSalename , Status , Discountpercen , EventSaleID \r\n"+
            "FROM SHOP.dbo.tblEventSale \r\n"+
            "WHERE EventSalename = N'{Eventname}'; \r\n\r\n",

            //[2] Select Product INPUT: {CodeProduct} 
			"Select CodeProduct , a.Productname , Quantity , PriceSell , a.ProductID \r\n"+
            "FROM SHOP.dbo.tblProducts as a \r\n"+
            "LEFT JOIN SHOP.dbo.tblPrice as d on a.PriceID = d.PriceID \r\n"+
            "LEFT JOIN SHOP.dbo.tblStock as e on a.ProductID = e.ProductID \r\n"+
            "WHERE a.CodeProduct = {CodeProduct} ; \r\n\r\n",
              };

        int ProductCurrentSelectIndex = -1;

        public Product_Sale()
        {
            InitializeComponent();
        }

        private void B_Select_Customer_Click(object sender, EventArgs e)
        {
            ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]
                    .Replace("{CUSTOMERID}", ShopApp.Shop.SelectCustomer.Showed()));
            TB_name_Customer.Text = "";

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chb_on_off_code_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_on_off_code.Checked == true)
            {
                TB_Code_UseCode.ReadOnly = false;
            }
            else
            {
                ConsoleCode("-", "-", "0");
                TB_Code_UseCode.Text = "";
                TB_Code_UseCode.ReadOnly = true;

            }
        }

        private void ConsoleCode(String code, String status, string discount)
        {
            TB_Console_StatusCode.Text = ("    Code : " + code + " \r\n" +
              "  Status : " + status + " \r\n" +
               "Discount : " + discount + " %");
        }

        private void B_Checked_Code_Click(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[1].Replace("{Eventname}", TB_Code_UseCode.Text));
            if (dt.Rows.Count < 1)
            {
                ConsoleCode(TB_Code_UseCode.Text, "Not Found", "0");
            }
            else
            {
                if (!((Convert.ToInt32(dt.Rows[0][1]) == 1)))
                {
                    ConsoleCode(dt.Rows[0][0] + "", "expire", "0");
                }
                else
                {
                    ConsoleCode(dt.Rows[0][0] + "", "Activate", dt.Rows[0][2] + "");
                }

            }
        }

        private void Product_Sale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable Select = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
                    .Replace("{CodeProduct}", TB_Select_Product.Text));
                if (Select.Rows.Count < 1)
                {
                    MessageBox.Show("ไม่พบสินค้านี้");
                }
                else
                {
                    DGV_Product.Rows.Add(Select.Rows[0][0], Select.Rows[0][1], 1, Select.Rows[0][3], Select.Rows[0][4]);
                }
                TB_Select_Product.Text = "";
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Product_Sale_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void DGV_Product_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void B_AddProduct_Click(object sender, EventArgs e)
        {
            DataTable Select = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
             .Replace("{CodeProduct}", TB_Select_Product.Text));
            if (Select.Rows.Count < 1)
            {
                MessageBox.Show("ไม่พบสินค้านี้");
            }
            else
            {
                DGV_Product.Rows.Add(Select.Rows[0][0], Select.Rows[0][1], 1, Select.Rows[0][3], Select.Rows[0][4], Select.Rows[0][5]);
            }
            TB_Select_Product.Text = "";
        }

        private void B_Delete_Product_Click(object sender, EventArgs e)
        {
        }

        private void DGV_Product_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2) {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("โปรแกรมกากเโปรแกรมค้าง!!");
                }
            }
        }

        private void DGV_Product_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = DGV_Product.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow != -1)
                {
                    ProductCurrentSelectIndex = currentMouseOverRow;
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("ลบออก"));
                    m.Show(DGV_Product, new Point(e.X, e.Y));
                    m.MenuItems[0].Click += new System.EventHandler(this.Delete_Product_Click);
                }
            }
        }

        private void Delete_Product_Click(object sender, EventArgs e)
        {
            if (ProductCurrentSelectIndex != -1)
            {
                DGV_Product.Rows.RemoveAt(ProductCurrentSelectIndex);
                ProductCurrentSelectIndex = -1;

            }
        }

        private void DGV_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
