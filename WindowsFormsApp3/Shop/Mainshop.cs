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
            ShopApp.Shop.add.addcustomer customer = new ShopApp.Shop.add.addcustomer();
            customer.Owner = this;
            customer.MdiParent = this;
            customer.Show();
            customer.WindowState = FormWindowState.Maximized;
            customer.Select();
            customer.MaximizeBox = false;
            customer.MinimizeBox = false;
            customer.FormBorderStyle = FormBorderStyle.None;

        }

        private void TSM_1_Customer_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editCustomer customer = new ShopApp.Shop.Shop_edit.editCustomer();
            customer.Owner = this;
            customer.MdiParent = this;
            customer.Show();
            customer.WindowState = FormWindowState.Maximized;
            customer.Select();
            customer.MaximizeBox = false;
            customer.MinimizeBox = false;
            customer.FormBorderStyle = FormBorderStyle.None;
        }
        private void TSM_1_Customer_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteCustomer customer = new ShopApp.Shop.Shop_delete.deleteCustomer();
            customer.Owner = this;
            customer.MdiParent = this;
            customer.Show();
            customer.WindowState = FormWindowState.Maximized;
            customer.Select();
            customer.MaximizeBox = false;
            customer.MinimizeBox = false;
            customer.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_Categorie_add_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.add.addCategorie categorie = new ShopApp.Shop.add.addCategorie();
            categorie.Owner = this;
            categorie.MdiParent = this;
            categorie.Show();
            categorie.WindowState = FormWindowState.Maximized;
            categorie.Select();
            categorie.MaximizeBox = false;
            categorie.MinimizeBox = false;
            categorie.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_Categorie_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editCategorie categorie = new ShopApp.Shop.Shop_edit.editCategorie();
            categorie.Owner = this;
            categorie.MdiParent = this;
            categorie.Show();
            categorie.WindowState = FormWindowState.Maximized;
            categorie.Select();
            categorie.MaximizeBox = false;
            categorie.MinimizeBox = false;
            categorie.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_Categorie_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteCategorie categorie = new ShopApp.Shop.Shop_delete.deleteCategorie();
            categorie.Owner = this;
            categorie.MdiParent = this;
            categorie.Show();
            categorie.WindowState = FormWindowState.Maximized;
            categorie.Select();
            categorie.MaximizeBox = false;
            categorie.MinimizeBox = false;
            categorie.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_brand_add_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.add.addBrand brand = new ShopApp.Shop.add.addBrand();
            brand.Owner = this;
            brand.MdiParent = this;
            brand.Show();
            brand.WindowState = FormWindowState.Maximized;
            brand.Select();
            brand.MaximizeBox = false;
            brand.MinimizeBox = false;
            brand.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_brand_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editBrand brand = new ShopApp.Shop.Shop_edit.editBrand();
            brand.Owner = this;
            brand.MdiParent = this;
            brand.Show();
            brand.WindowState = FormWindowState.Maximized;
            brand.Select();
            brand.MaximizeBox = false;
            brand.MinimizeBox = false;
            brand.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_brand_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteBrand brand = new ShopApp.Shop.Shop_delete.deleteBrand();
            brand.Owner = this;
            brand.MdiParent = this;
            brand.Show();
            brand.WindowState = FormWindowState.Maximized;
            brand.Select();
            brand.MaximizeBox = false;
            brand.MinimizeBox = false;
            brand.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_product_add_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.add.addproduct product = new ShopApp.Shop.add.addproduct();
            product.Owner = this;
            product.MdiParent = this;
            product.Show();
            product.WindowState = FormWindowState.Maximized;
            product.Select();
            product.MaximizeBox = false;
            product.MinimizeBox = false;
            product.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_product_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editProduct product = new ShopApp.Shop.Shop_edit.editProduct();
            product.Owner = this;
            product.MdiParent = this;
            product.Show();
            product.WindowState = FormWindowState.Maximized;
            product.Select();
            product.MaximizeBox = false;
            product.MinimizeBox = false;
            product.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_product_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteProduct product = new ShopApp.Shop.Shop_delete.deleteProduct();
            product.Owner = this;
            product.MdiParent = this;
            product.Show();
            product.WindowState = FormWindowState.Maximized;
            product.Select();
            product.MaximizeBox = false;
            product.MinimizeBox = false;
            product.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_transport_add_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.add.addTransport transport = new ShopApp.Shop.add.addTransport();
            transport.Owner = this;
            transport.MdiParent = this;
            transport.Show();
            transport.WindowState = FormWindowState.Maximized;
            transport.Select();
            transport.MaximizeBox = false;
            transport.MinimizeBox = false;
            transport.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_transport_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editTransprort transport = new ShopApp.Shop.Shop_edit.editTransprort();
            transport.Owner = this;
            transport.MdiParent = this;
            transport.Show();
            transport.WindowState = FormWindowState.Maximized;
            transport.Select();
            transport.MaximizeBox = false;
            transport.MinimizeBox = false;
            transport.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_transport_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteTransport transport = new ShopApp.Shop.Shop_delete.deleteTransport();
            transport.Owner = this;
            transport.MdiParent = this;
            transport.Show();
            transport.WindowState = FormWindowState.Maximized;
            transport.Select();
            transport.MaximizeBox = false;
            transport.MinimizeBox = false;
            transport.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_event_add_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.add.addEventSale eventsale = new ShopApp.Shop.add.addEventSale();
            eventsale.Owner = this;
            eventsale.MdiParent = this;
            eventsale.Show();
            eventsale.WindowState = FormWindowState.Maximized;
            eventsale.Select();
            eventsale.MaximizeBox = false;
            eventsale.MinimizeBox = false;
            eventsale.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_event_edit_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_edit.editEventSale eventsale = new ShopApp.Shop.Shop_edit.editEventSale();
            eventsale.Owner = this;
            eventsale.MdiParent = this;
            eventsale.Show();
            eventsale.WindowState = FormWindowState.Maximized;
            eventsale.Select();
            eventsale.MaximizeBox = false;
            eventsale.MinimizeBox = false;
            eventsale.FormBorderStyle = FormBorderStyle.None;
        }

        private void TSM_1_event_delete_Click(object sender, EventArgs e)
        {
            ShopApp.Shop.Shop_delete.deleteEventSale eventsale = new ShopApp.Shop.Shop_delete.deleteEventSale();
            eventsale.Owner = this;
            eventsale.MdiParent = this;
            eventsale.Show();
            eventsale.WindowState = FormWindowState.Maximized;
            eventsale.Select();
            eventsale.MaximizeBox = false;
            eventsale.MinimizeBox = false;
            eventsale.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
