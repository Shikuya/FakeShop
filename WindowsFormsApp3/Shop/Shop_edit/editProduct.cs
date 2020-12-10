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
    public partial class editProduct : Form
    {
        public editProduct()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
            "FROM Shop.dbo.tblBrand; \r\n\r\n", new ComboBox[] {CB_Product_Change_Brand_name , CB_Product_Chang_Show_Brand});
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , Categorieid  \r\n" +
            "FROM Shop.dbo.tblCategories ; \r\n\r\n", new ComboBox[] {CB_Product_Change_Categotie_Name , CB_Product_Chang_Show_Categorie});
        }

        private void editProduct_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editProduct_Load(object sender, EventArgs e)
        {

        }

        private void CB_Product_Chang_Show_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(CB_Product_Chang_Show_Brand.Text == "" || CB_Product_Chang_Show_Categorie.Text == "" ))
            {
                ShopApp.Class.ComboBoxItem Categorie = (CB_Product_Chang_Show_Categorie.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem brand = (CB_Product_Chang_Show_Brand.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.LoadComboBoxInformation("SELECT ProductName , ProductID  \r\n" +
                "FROM Shop.dbo.tblProducts \r\n" +
                "WHERE Brandid ="+brand.No+" and Categorieid ="+Categorie.No+" \r\n\r\n", new ComboBox[] {CB_Product_Chang_Show_Product});
            }
            
        }

        private void B_Product_Save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem product = (CB_Product_Chang_Show_Product.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem brand = (CB_Product_Change_Brand_name.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem categorie = (CB_Product_Change_Categotie_Name.SelectedItem as ShopApp.Class.ComboBoxItem);
            
            DataTable dt = ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "SELECT CostPrice \r\n" +
            "FROM SHOP.dbo.tblPrice as a \r\n" +
            "LEFT JOIN SHOP.dbo.tblProducts as b on a.PriceID = b.PriceID \r\n" +
            "WHERE ProductID = "+product.No+"; \r\n\r\n");
            
            if (!(CB_Product_Chang_Show_Product.Text == "" || CB_Product_Chang_Show_Categorie.Text == "" ||
                CB_Product_Chang_Show_Brand.Text == "" || CB_Product_Change_Categotie_Name.Text == "" ||
                CB_Product_Change_Brand_name.Text == "" || TB_Product_Change_Price.Text == "" || TB_Product_Change_Productname.Text == ""))
            {
                    ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "DECLARE @PriceID INT; \r\n \r\n" +

                "INSERT INTO SHOP.dbo.tblPrice(CostPrice, PriceSell , UserID) \r\n" +
                "VALUES('"+dt.Rows[0][0]+"','"+TB_Product_Change_Price.Text+"','"+ShopApp.Class.AccountInfo.AccountNo+"'); \r\n \r\n" +

                "SELECT @PriceID = SCOPE_IDENTITY(); \r\n \r\n" +

                "UPDATE Shop.dbo.tblProducts \r\n" +
                "SET Productname='"+TB_Product_Change_Productname.Text+"', CategorieID='"+categorie.No+"' , PriceID = @PriceID , BrandID = "+brand.No+" \r\n" +
                "WHERE ProductID="+product.No+"; \r\n\r\n");

                MessageBox.Show("บันทึกเรียบร้อยครับ");
                CB_Product_Change_Brand_name.Text = "";
                CB_Product_Change_Categotie_Name.Text = "";
                CB_Product_Chang_Show_Brand.Text = "";
                CB_Product_Chang_Show_Categorie.Text = "";
                CB_Product_Chang_Show_Product.Text = "";
                TB_Product_Change_Price.Text = "";
                TB_Product_Change_Productname.Text = "";
                CB_Product_Chang_Show_Product.Items.Remove(product.Name);
                CB_Product_Chang_Show_Product.Items.Add(TB_Product_Change_Productname.Text);

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบครับ");
            }
        }
    }
}
