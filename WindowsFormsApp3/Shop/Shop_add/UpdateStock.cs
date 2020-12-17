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
    public partial class updateStock : Form
    {
        public updateStock()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
            "FROM Shop.dbo.tblBrand; \r\n\r\n", new ComboBox[] { CB_Brand_list });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename, Categorieid \r\n" +
            "FROM Shop.dbo.tblCategories; \r\n\r\n", new ComboBox[] { CB_Categorie_list });
        }

        private void updateStock_Load(object sender, EventArgs e)
        {

        }

        private void CB_Product_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_Brand_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(CB_Categorie_list.Text == "" || CB_Brand_list.Text == ""))
            {
                ShopApp.Class.ComboBoxItem Categorie = (CB_Categorie_list.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem brand = (CB_Brand_list.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.LoadComboBoxInformation("SELECT ProductName , ProductID  \r\n" +
                "FROM Shop.dbo.tblProducts \r\n" +
                "WHERE Brandid =" + brand.No + " and Categorieid =" + Categorie.No + " \r\n\r\n", new ComboBox[] { CB_Product_list });
            }
            
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem product = (CB_Product_list.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "DECLARE @Quantity INT; \r\n \r\n" +

            "SELECT @Quantity = (SELECT Quantity \r\n" +
            "FROM Shop.dbo.tblProducts as a \r\n" +
            "LEFT JOIN SHOP.dbo.tblStock as b on a.ProductID = b.ProductID \r\n" +
            "WHERE a.ProductID = "+product.No+"); \r\n \r\n" +

            "UPDATE Shop.dbo.tblStock \r\n" +
            "SET Quantity = @Quantity + "+TB_update_Stock.Text+"\r\n" +
            "WHERE ProductID = "+product.No+"; \r\n\r\n");
            MessageBox.Show("บันทึกเรียบร้อยครับ");
            TB_update_Stock.Text = "";
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }
    }
}
