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
        public static String Transportname;
        public static int PriceTransport;
        public static int Price;
        public static String Discount;
        /// <summary>
        /// SQLDafault
        /// <para>[0] Select name and id card customer INPUT: {CUSTOMERID}</para>
        /// <para>[1] Select Event INPUT: {Eventname}</para>
        /// <para>[2] Select Product INPUT: {CodeProduct} </para>
        /// <para>//[3] Select Quantity Product INPUT: {ProductID} </para>
        /// </summary>
        private String[] SQLDefault = new String[]
    {
			//[0] Select name and id card customer INPUT: {CUSTOMERID} 
			"Select Customername , PhoneNumber \r\n"+
            "FROM Account.dbo.tblCustomers \r\n"+
            "Where CustomerID = {CUSTOMERID}; \r\n\r\n",

            //[1] Select Event INPUT: {Eventname} 
			"SELECT EventSalename , Status , Discountpercen , EventSaleID \r\n"+
            "FROM SHOP.dbo.tblEventSale \r\n"+
            "WHERE EventSalename = '{Eventname}'; \r\n\r\n",

            //[2] Select Product INPUT: {CodeProduct} 
			"Select CodeProduct , a.Productname , Quantity , PriceSell , a.ProductID  \r\n"+
            "FROM SHOP.dbo.tblProducts as a  \r\n"+
            "LEFT JOIN SHOP.dbo.tblPrice as b on a.PriceID = b.PriceID  \r\n"+
            "LEFT JOIN SHOP.dbo.tblStock as c on a.ProductID = c.ProductID \r\n"+
            "WHERE a.CodeProduct = {CodeProduct} ; \r\n\r\n",

            //[3] Select Quantity Product INPUT: {ProductID}
            "SELECT Quantity \r\n " +
             "FROM SHOP.dbo.tblStock \r\n " +
             "WHERE ProductID = '{ProductID}'; "
              };

        int ProductCurrentSelectIndex = -1;
        public Product_Sale()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Transportname, Transportid \r\n" +
            "FROM GeneralData.dbo.tblTransport; \r\n\r\n", new ComboBox[] { CB_Select_Transport });
        }

        private void B_Select_Customer_Click(object sender, EventArgs e)
        {
            String a = ShopApp.Shop.SelectCustomer.Showed();
            if (a != "")
            {
                DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]
                        .Replace("{CUSTOMERID}", a));
                TB_name_Customer.Text = "" + dt.Rows[0][0];
                TB_phone_Customer.Text = "0" + dt.Rows[0][1];
            }
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
                try
                {
                    if (!((Convert.ToInt32(dt.Rows[0][1]) == 0))) //Chaeck Status 0 = ทำงานได้ 1 = หมดอายุ
                    {
                        ConsoleCode(dt.Rows[0][0] + "", "expire", "0");
                    }
                    else
                    {
                        ConsoleCode(dt.Rows[0][0] + "", "Activate", dt.Rows[0][2] + "");
                    }
                }
                catch
                {
                    ConsoleCode(TB_Code_UseCode.Text, "Error", "0");
                }
            }
            if (dt.Rows[0][2] != "")
            {
                Discount = ""+dt.Rows[0][2];
            }
            else
            {
                Discount = "";
            }
        }

        private void Product_Sale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProduct();
            }
        }
        private void addProduct()
        {
            DataTable Select = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
              .Replace("{CodeProduct}", TB_Select_Product.Text));
            if (Select.Rows.Count < 1)
            {
                MessageBox.Show("ไม่พบสินค้านี้");
            }
            else
            {
                int x = 0;
                for (int a = 0; a < DGV_Product.Rows.Count; a++)
                {
                    if (TB_Select_Product.Text == DGV_Product.Rows[a].Cells[0].Value.ToString())
                    {
                        int dgv = Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString());
                        DGV_Product.Rows[a].Cells[2].Value = dgv + 1;
                        x = 1; // ซ้ำข้างใน
                        DGV_Product.Rows[a].Cells[3].Value = Convert.ToInt32(Select.Rows[0][3]) * Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString());
                    }
                }
                if (x == 0)
                {
                    DGV_Product.Rows.Add(Select.Rows[0][0], Select.Rows[0][1], 1, Select.Rows[0][3], Select.Rows[0][4], Select.Rows[0][3]);
                }
                Balance();

            }
            TB_Select_Product.Text = "";
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
            addProduct();
        }

        private void B_Delete_Product_Click(object sender, EventArgs e)
        {
        }

        private void DGV_Product_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("ใส่ได้แต่ตัวเลขครับ.");
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
                    Balance();
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

        private void B_Confirm_money_Click(object sender, EventArgs e)
        {

        }

        private void TB_Totalbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_id_Customer_TextChanged(object sender, EventArgs e)
        {

        }

        public void TB_name_Customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Delete_Product_Click_1(object sender, EventArgs e)
        {
        }

        private void DGV_Product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //String ProductID = DGV_Product.Rows[1].Cells[4].Value.ToString; //แก้ให้มันได้
            //DataTable dt =  SQL.InputSQLMSSQL(SQLDefault[3].Replace("{ProductID}" ,));
            for (int a = 0; a < DGV_Product.Rows.Count; a++)
            {
                if (Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString()) < 1)
                {
                    DGV_Product.Rows[a].Cells[2].Value = 1;
                }
                else if(Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString()) > 10)
                {

                }
                DGV_Product.Rows[a].Cells[3].Value = Convert.ToInt32(DGV_Product.Rows[a].Cells[5].Value) * Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString());
                Balance();
            }
        }
        private void Balance()
        {
            int yod = 0;
            for (int z = 0; z < DGV_Product.Rows.Count; z++)
            {
                yod = yod + Convert.ToInt32(DGV_Product.Rows[z].Cells[3].Value);
            }
            TB_Balance_product.Text = "" + yod;
        }

        private void B_ClearTab_Click(object sender, EventArgs e)
        {
            DGV_Product.Rows.Clear();
            TB_Balance_product.Text = "";
            TB_Code_UseCode.Text = "";
            TB_name_Customer.Text = "";
            TB_phone_Customer.Text = "";
            TB_Select_Product.Text = "";
            ConsoleCode("-", "-", "0");
            Chb_on_off_code.Checked = false;
            CB_Select_Transport.Items.Clear();
            TB_Transport.Text = "";
            TB_Transport.ReadOnly = true;
            ShopApp.SQL.LoadComboBoxInformation("SELECT Transportname, Transportid \r\n" +
            "FROM GeneralData.dbo.tblTransport; \r\n\r\n", new ComboBox[] { CB_Select_Transport });

        }

        private void B_list_Product_Click(object sender, EventArgs e)
        {
            String b = ShopApp.Shop.SelectProduct.Showed();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
              .Replace("{CodeProduct}", b));
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("ไม่พบสินค้านี้");
            }
            else
            {
                int x = 0;
                for (int a = 0; a < DGV_Product.Rows.Count; a++)
                {
                    if (b == DGV_Product.Rows[a].Cells[0].Value.ToString())
                    {
                        int dgv = Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString());
                        DGV_Product.Rows[a].Cells[2].Value = dgv + 1;
                        x = 1; // ซ้ำข้างใน
                        DGV_Product.Rows[a].Cells[3].Value = Convert.ToInt32(dt.Rows[0][3]) * Convert.ToInt32(DGV_Product.Rows[a].Cells[2].Value.ToString());
                    }
                }
                if (x == 0)
                {
                    DGV_Product.Rows.Add(dt.Rows[0][0], dt.Rows[0][1], 1, dt.Rows[0][3], dt.Rows[0][4], dt.Rows[0][3]);
                }
                Balance();
            }
        }

        private void Product_Sale_Load(object sender, EventArgs e)
        {

        }

        public void CB_Select_Transport_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Transport.ReadOnly = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void TB_Transport_TextChanged(object sender, EventArgs e)
        {

        }

        public void TB_Code_UseCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Confirm_Order_Click(object sender, EventArgs e)
        {
            int dont = 0;
            if (TB_Transport.Text != "")
            {
                
                Transportname =  CB_Select_Transport.Text;
                if (TB_Transport.Text != "0")
                {
                    try
                    {
                        PriceTransport = Convert.ToInt32(TB_Transport.Text);
                    }
                    catch
                    {
                        dont = 1;
                    }
                    
                }
            }
            try
            {
                Price = Convert.ToInt32(TB_Balance_product.Text);
            }
            catch
            {
                dont = 1;
            }
            if (dont == 0)
            {
                Form kidmoney = new ShopApp.Shop.kidmoney();
                kidmoney.Show();
            }
            else
            {
                MessageBox.Show("กรุณาใส่เป็นตัวเลขครับ");
            }

        }
    }
}
