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

    public partial class SaleProduct : Form
    {
        /// <summary>
		/// SQLDafault
		/// <para>[0] Select Product INPUT: {Brandid} {Categorieid} </para>
        /// <para>[1] Select Quantity INPUT: {Productid} </para>
        /// <para>[2] Select PriceSell and Quantity INPUT: {Productid} </para>
        /// <para>[3] CheckCode Event INPUT: {Eventname} </para>
        /// <para>[4] Input Full option Confirm Order INPUT: {Idcrad} {Productid} {Quantity} {Idevent} {PriceProduct} {PriceTransport} {IdTransport}</para>
		/// </summary>
		private String[] SQLDefault = new String[]
        {
			//[0] Select Product INPUT: {Brandid} {Categorieid}
			"SELECT ProductName , ProductID   \r\n"+
            "FROM Shop.dbo.tblProducts  \r\n"+
            "WHERE Brandid = {Brandid} and Categorieid = {Categorieid} ; \r\n\r\n",

            //[1] Select Quantity INPUT: {Productid}
			"SELECT Quantity  \r\n"+
            "FROM Shop.dbo.tblProducts as a  \r\n"+
            "LEFT JOIN Shop.dbo.tblStock as b on a.ProductId = b.ProductId  \r\n"+
            "WHERE a.ProductId = {Productid}; \r\n\r\n",

            //[2] Select PriceSell and Quantity INPUT: {Productid} 
			"SELECT PriceSell ,Quantity  \r\n"+
            "FROM SHOP.dbo.tblProducts as a  \r\n"+
            "LEFT JOIN SHOP.dbo.tblPrice as b on a.PriceID = b.PriceID  \r\n"+
            "LEFT JOIN SHOP.dbo.tblStock as c on a.PriceID = c.ProductID  \r\n"+
            "WHERE a.ProductID = {Productid}  ; \r\n\r\n",

            //[3] CheckCode Event INPUT: {Eventname} 
			"SELECT EventSalename , Discountpercen , EventSaleid \r\n"+
            "FROM Shop.dbo.tblEventSale  \r\n"+
            "WHERE EventSalename = '{Eventname} '; \r\n ; \r\n\r\n",

            //[4] Input Full option Confirm Order INPUT: {Idcrad} {Productid} {Quantity} {Idevent} {PriceProduct} {PriceTransport} {IdTransport}
			"DECLARE @CustomerID INT; \r\n  \r\n"+

            "  \r\n"+
            "SELECT @CustomerID = (SELECT CustomerID  \r\n"+
            "FROM Account.dbo.tblCustomers  \r\n"+
            "WHERE IDcardnum = {Idcrad}); \r\n  \r\n"+

            "  \r\n"+
            "INSERT INTO SHOP.dbo.tblOrderProducts(CustomerID,ProductID , Quantity , EventSaleID , PriceProduct , PriceTransport , TransportID)  \r\n"+
            "VALUES (@CustomerID,'{Productid}','{Quantity}','{Idevent}','{PriceProduct}','{PriceTransport}','{IdTransport}'); \r\n  \r\n"+

            "  \r\n"+
            "DECLARE @Quantity INT; \r\n  \r\n"+

            "  \r\n"+
            "SELECT @Quantity = (SELECT Quantity  \r\n"+
            "FROM Shop.dbo.tblStock  \r\n"+
            "WHERE ProductID = {Productid}); \r\n  \r\n"+

            "  \r\n"+
            "UPDATE Shop.dbo.tblStock  \r\n"+
            "SET Quantity = @Quantity - 10  \r\n"+
            "WHERE ProductID = {Productid}; \r\n ; \r\n\r\n",

        };
        public SaleProduct()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
           "FROM Shop.dbo.tblBrand; \r\n\r\n", new ComboBox[] { CB_SaleProduct_Show_Brand });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename, Categorieid \r\n" +
            "FROM Shop.dbo.tblCategories; \r\n\r\n", new ComboBox[] { CB_SaleProduct_Show_Cateorie });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Transportname, Transportid \r\n" +
            "FROM GeneralData.dbo.tblTransport; \r\n\r\n", new ComboBox[] { CB_Select_Transport });

        }

        private void CB_SaleProduct_Show_Cateorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_SaleProduct_Show_Brand.Text = "";
        }

        private void ChB_Checked_Code_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_Checked_Code.Checked == true)
            {
                TB_Code_UseCode.ReadOnly = false;
                TB_Code_UseCode.BackColor = Color.White;
            }
            else
            {
                TB_Code_UseCode.ReadOnly = true;
                TB_Code_UseCode.BackColor = Color.Gray;
                TB_Code_UseCode.Text = "";
            }
        }

        private void CB_SaleProduct_Show_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(CB_SaleProduct_Show_Brand.Text == "" || CB_SaleProduct_Show_Cateorie.Text == ""))
            {
                ShopApp.Class.ComboBoxItem Categorie = (CB_SaleProduct_Show_Cateorie.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem brand = (CB_SaleProduct_Show_Brand.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.LoadComboBoxInformation(SQLDefault[0]
                    .Replace("{Brandid}", brand.No)
                    .Replace("{Categorieid}", Categorie.No), new ComboBox[] { CB_SaleProduct_Show_Product });
            }
        }

        private void SaleProduct_SizeChanged(object sender, EventArgs e)
        {
        }

        private void CB_SaleProduct_Show_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_SaleProduct_Show_Quantity.Items.Clear();
            ShopApp.Class.ComboBoxItem product = (CB_SaleProduct_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[1]
                .Replace("{Productid}" , product.No));
            for(int a = 1; a <= Convert.ToInt32(dt.Rows[0][0]) && !(a > 15); a++)
            {
                CB_SaleProduct_Show_Quantity.Items.Add(a);
            }
        }

        private void TB_Console_produc_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Select_Customer_Click(object sender, EventArgs e)
        {
            TB_Show_Customer_name.Text = "";
            TB_Show_Customer_IDcard.Text = "";
            ShopApp.Shop.SelectCustomer Select = new ShopApp.Shop.SelectCustomer();
            Select.Show();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void SaleProduct_MouseMove(object sender, MouseEventArgs e)
        {
            TB_Show_Customer_name.Text = ShopApp.Class.CustomerInformation.Name;
            TB_Show_Customer_IDcard.Text = ShopApp.Class.CustomerInformation.Idcard;
        }

        private void B_Checked_Code_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Categorie = (CB_SaleProduct_Show_Cateorie.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem brand = (CB_SaleProduct_Show_Brand.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem product = (CB_SaleProduct_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt1 = ShopApp.SQL.InputSQLMSSQL(SQLDefault[3]
                .Replace("{Eventname}" , TB_Code_UseCode.Text));
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
                .Replace("{Productid}",product.No));
            if (dt1.Rows.Count < 1)
            {
                TB_Console_Code.Text = "Code : " + TB_Code_UseCode.Text + " . \r\n" +
                        "Status Error . \r\n";
                TB_Console_produc.Text = "Brand : " + brand.Name + " . \r\n" +
                        "Categorie : " + Categorie.Name + ". \r\n" +
                        "Product : " + product.Name + ".  Stock : " + dt.Rows[0][1] + ". \r\n" +
                        "Price : " + Convert.ToInt32(dt.Rows[0][0]) * Convert.ToInt32(CB_SaleProduct_Show_Quantity.SelectedItem) + " . ";
            }
            else
            {
                TB_Console_Code.Text = "Code : " + TB_Code_UseCode.Text + " . \r\n" +
                    "Status Activate . \r\n" +
                    "Discount : " + dt1.Rows[0][1] + " %";


                TB_Console_produc.Text = "";
                TB_Console_produc.Text = "Brand : " + brand.Name + " . \r\n" +
                "Categorie : " + Categorie.Name + ". \r\n" +
                "Product : " + product.Name + ".  Stock : " + dt.Rows[0][1] + ". \r\n" +
                "Price : " + (((Convert.ToInt32(dt.Rows[0][0]) * Convert.ToInt32(CB_SaleProduct_Show_Quantity.SelectedItem)) -((Convert.ToInt32(dt.Rows[0][0]) * Convert.ToInt32(CB_SaleProduct_Show_Quantity.SelectedItem)) * Convert.ToInt32(dt1.Rows[0][1]) / 100))) + " . ";
                DataTable eventid = ShopApp.SQL.InputSQLMSSQL("");
            }
        }

        private void B_Confirm_Informaion_Click(object sender, EventArgs e)
        {// กดปุ่ม Confirm
                DataTable dt1 = ShopApp.SQL.InputSQLMSSQL(SQLDefault[3]
                    .Replace("{Eventname}" , TB_Code_UseCode.Text));
                ShopApp.Class.ComboBoxItem product = (CB_SaleProduct_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem Product = (CB_SaleProduct_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (!(CB_SaleProduct_Show_Product.Text == "" || CB_SaleProduct_Show_Brand.Text =="" ||
                CB_SaleProduct_Show_Cateorie.Text == "" || CB_SaleProduct_Show_Quantity.Text == ""||
                CB_Select_Transport.Text == "" || TB_Show_Customer_IDcard.Text == ""))
            {
                //ShopApp.SQL.InputSQLMSSQL(SQLDefault[4]
                //    .Replace("{Idcard}",)
                //    .Replace("{Productid}",)
                //    .Replace("{Quantity}",)
                //    .Replace("{Idevent}",)
                //    .Replace("{PriceProduct}",)
                //    .Replace("{PriceTransport}",)
                //    .Replace("{IdTransport}",))
            }
        }

        private void CB_SaleProduct_Show_Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Categorie = (CB_SaleProduct_Show_Cateorie.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem brand = (CB_SaleProduct_Show_Brand.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem product = (CB_SaleProduct_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[2]
                .Replace("{Productid}" , product.No));
            TB_Console_produc.Text = "Brand : " + brand.Name + " . \r\n" +
                "Categorie : " + Categorie.Name + ". \r\n" +
            "Product : " + product.Name + ".  Stock : " + dt.Rows[0][1] + ". \r\n" +
            "Price : " + Convert.ToInt32(dt.Rows[0][0]) * Convert.ToInt32(CB_SaleProduct_Show_Quantity.SelectedItem) + " . ";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            TB_Show_Customer_name.Text = ShopApp.Class.CustomerInformation.Name;
            TB_Show_Customer_IDcard.Text = ShopApp.Class.CustomerInformation.Idcard;
        }

        private void CB_Select_Transport_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Price_Transport.ReadOnly = false;
        }
    }
}
