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
    public partial class kidmoney : Form
    {
        public kidmoney()
        {
            InitializeComponent();
            if (ShopApp.Shop.Product_Sale.PriceTransport != "")
            {
            TB_Transport.Text = ShopApp.Shop.Product_Sale.Transportname;
            TB_TransportPrice.Text = ShopApp.Shop.Product_Sale.PriceTransport;
            }
            else
            {
                TB_Transport.Text = "-";
                TB_TransportPrice.Text = "0";
            }
            String Tprice = TB_TransportPrice.Text;
            String price = ShopApp.Shop.Product_Sale.Price;
            TB_Balance.Text = (Convert.ToInt32(price) + Convert.ToInt32(Tprice))+"";//คิดมาเป็นชม คิมั่ยออก
        }

        private void TB_Transport_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kidmoney_Load(object sender, EventArgs e)
        {

        }
    }
}
