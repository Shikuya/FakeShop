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
    public partial class Mainshop : Form
    {
        public Mainshop()
        {
            InitializeComponent();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TSM_1_Customer_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addcustomer());

        }

        private void TSM_1_Customer_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editCustomer());
        }
        private void TSM_1_Customer_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteCustomer());
        }

        private void TSM_1_Categorie_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addCategorie());
        }

        private void TSM_1_Categorie_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editCategorie());
        }

        private void TSM_1_Categorie_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteCategorie());
        }

        private void TSM_1_brand_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addBrand());
        }

        private void TSM_1_brand_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editBrand());
        }

        private void TSM_1_brand_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteBrand());
        }

        private void TSM_1_product_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addproduct());
        }

        private void TSM_1_product_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editProduct());
        }

        private void TSM_1_product_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteProduct());
        }

        private void TSM_1_transport_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addTransport());
        }

        private void TSM_1_transport_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editTransprort());
        }

        private void TSM_1_transport_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteTransport());
        }

        private void TSM_1_event_add_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.add.addEventSale());
        }

        private void TSM_1_event_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_edit.editEventSale());
        }

        private void TSM_1_event_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.Shop_delete.deleteEventSale());
        }

        private void TSM_3_MenuShop_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.SaleProduct());
        }

        private void Mainshop_Load(object sender, EventArgs e)
        {

        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.ChangPage(this, new ShopApp.Shop.updateStock());
        }
    }
}
