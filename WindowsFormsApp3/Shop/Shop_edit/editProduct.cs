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
            "FROM tblBrand; \r\n\r\n", new ComboBox[] {CB_Product_Change_Brand_name , CB_Product_Chang_Show_Brand});
            ShopApp.SQL.LoadComboBoxInformation("SELECT Customername , CustomerID  \r\n" +
            "FROM tblCustomers ; \r\n\r\n", new ComboBox[] {CB_Product_Change_Categotie_Name , CB_Product_Chang_Show_Categorie});
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
            ShopApp.SQL.LoadComboBoxInformation("SELECT ProductName , ProductID  \r\n" +
            "FROM tblProducts ; \r\n\r\n", new ComboBox[] {CB_Product_Chang_Show_Product});
        }

        private void B_Product_Save_Click(object sender, EventArgs e)
        {
            if (CB_Product_Chang_Show_Product.Text == "" || CB_Product_Chang_Show_Categorie.Text == "" ||
                CB_Product_Chang_Show_Brand.Text == "" || CB_Product_Change_Categotie_Name.Text == "" ||
                CB_Product_Change_Brand_name.Text == "" || TB_Product_Change_Price.Text == "" || TB_Product_Change_Productname.Text == "")
            {

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบครับ");
            }
        }
    }
}
