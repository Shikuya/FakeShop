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
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , Categorieid  \r\n" +
            "FROM Shop.dbo.tblCategories ; \r\n\r\n", new ComboBox[] { CB_product_Categoriename });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Brandname , Brandid  \r\n" +
            "FROM Shop.dbo.tblBrand ; \r\n\r\n", new ComboBox[] { CB_product_brandname});
        }

        private void LQuantityProduct_Click(object sender, EventArgs e)
        {

        }

        private void CB_product_Categoriename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_product_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem addbrandid = (CB_product_brandname.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem addcategorieid = (CB_product_Categoriename.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (CB_product_brandname.Text == "" || CB_product_Categoriename.Text == "" || TB_Product_name.Text == "" || TB_product_CostPrice.Text == "" || TB_product_PriceSell.Text == "" || TB_product_Quantity.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ.");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "DECLARE @ProductID INT; \r\n" +
                "DECLARE @PriceID INT; \r\n \r\n" +

                "INSERT INTO Shop.dbo.tblPrice(CostPrice , PriceSell , UserID) \r\n" +
                "VALUES ('" + TB_product_CostPrice.Text + "','" + TB_product_PriceSell.Text + "','" + ShopApp.Class.AccountInfo.AccountNo + "'); \r\n \r\n" +

                "SELECT @PriceID = SCOPE_IDENTITY(); \r\n  \r\n" +

                "INSERT INTO Shop.dbo.tblProducts(Productname , CategorieID,PriceID , brandid)  \r\n" +
                "VALUES ('" + TB_Product_name.Text + "','" + addcategorieid.No + "',@PriceID , "+ addbrandid.No + "); \r\n  \r\n" +

                "SELECT @ProductID = SCOPE_IDENTITY(); \r\n  \r\n" +

                "INSERT INTO Shop.dbo.tblDateAddProduct(ProductID , Quantity ,PriceID)  \r\n" +
                "VALUES (@Productid,'" + TB_product_Quantity.Text + "',@PriceID); \r\n \r\n" +

                "INSERT INTO Shop.dbo.tblStock(ProductID,Quantity)  \r\n" +
                "VALUES (@ProductID,'" + TB_product_Quantity.Text + "'); \r\n\r\n");
                MessageBox.Show("เพิ่มสินค้าเรียบร้อย.");
                CB_product_brandname.Text = "";
                CB_product_Categoriename.Text = "";
                TB_product_CostPrice.Text = "";
                TB_Product_name.Text = "";
                TB_product_PriceSell.Text = "";
                TB_product_Quantity.Text = "";
            }
        }

        private void addproduct_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void addproduct_Load(object sender, EventArgs e)
        {

        }
    }
}
