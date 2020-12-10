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
        public SaleProduct()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
           "FROM Shop.dbo.tblBrand; \r\n\r\n", new ComboBox[] {CB_SaleProduct_Show_Brand});
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename, Categorieid \r\n" +
            "FROM Shop.dbo.tblCategories; \r\n\r\n", new ComboBox[] { CB_SaleProduct_Show_Cateorie });

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void CB_SaleProduct_Show_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaleProduct_SizeChanged(object sender, EventArgs e)
        {
        }

        private void SaleProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
