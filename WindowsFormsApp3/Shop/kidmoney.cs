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
            if (ShopApp.Shop.Product_Sale.Transportname != "")
            {
                TB_Transport.Text = ShopApp.Shop.Product_Sale.Transportname; // ชื่อขนส่ง
                TB_TransportPrice.Text = ShopApp.Shop.Product_Sale.PriceTransport+""; //ราคา
            }
            else
            {
                TB_Transport.Text = "-";
                TB_TransportPrice.Text = "0";
            }
            String Tprice = TB_TransportPrice.Text;
            String price = ShopApp.Shop.Product_Sale.Price+"";
            if (price == "") 
            {
                price = "0";
                
            }
            else if (Tprice == "")
            {
                Tprice = "0";
            }
            try
            {
                TB_Balance.Text = (Convert.ToInt32(price) + Convert.ToInt32(Tprice))+"";
            }
            catch
            {
                Console.WriteLine("");
            }
            
        }

        private void TB_Transport_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kidmoney_Load(object sender, EventArgs e)
        {

        }

        private void B_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void TB_getmoney_TextChanged(object sender, EventArgs e)
        {
            String yod = TB_Balance.Text;
            String get = TB_getmoney.Text;
            try
            {
                int a = (Convert.ToInt32(yod) - Convert.ToInt32(get));
                TB_ton.Text = a+"";
            }
            catch
            {
                Console.WriteLine("");
            }

        }
    }
}
