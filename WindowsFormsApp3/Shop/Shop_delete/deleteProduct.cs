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
    public partial class deleteProduct : Form
    {
        public deleteProduct()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Baradname , BaradID  \r\n" +
            "FROM Shop.dbo.tblBarad ; \r\n\r\n", new ComboBox[] { CB_Product_Baradname });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , CategorieID  \r\n" +
            "FROM Shop.dbo.tblCategories ; \r\n\r\n", new ComboBox[] { CB_Product_Categoriename });
        }

        private void deleteProduct_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void B_Product_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (CB_Product_Productname.Text == "" || CB_Product_Categoriename.Text == "" || CB_Product_Baradname.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลก่อนนะครับ");
            }
            else
            {
                ShopApp.Class.ComboBoxItem Product = (CB_Product_Productname.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "DELETE FROM Shop.dbo.tblProducts \r\n" +
                "WHERE ProductID = "+Product.No+"; \r\n\r\n");
                CB_Product_Productname.Items.Remove(Product.Name);
                MessageBox.Show("ลบสินค้านี้เรียบร้อยครับ");
                CB_Product_Baradname.Text = "";
                CB_Product_Categoriename.Text = "";
                CB_Product_Productname.Text = "";
            }

        }

        private void CB_Product_Baradname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem categorie = (CB_Product_Categoriename.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem brand = (CB_Product_Baradname.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.SQL.LoadComboBoxInformation("SELECT Productname , ProductID  \r\n" +
            "FROM Shop.dbo.tblProducts " +
            "WHERE BrandID = "+brand.No+" and Categorieid = "+categorie.No+"; \r\n\r\n", new ComboBox[] { CB_Product_Productname });
        }

        private void deleteProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
