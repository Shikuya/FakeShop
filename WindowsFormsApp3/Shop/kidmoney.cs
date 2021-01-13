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
        /// <summary> 
        /// SQLDafault 
        /// <para>[0] OrderProduct INPUT: {CustomerID} {ProductID} {Quantity} {EventSale} {PriceProduct} {PriceTransport} {TransportID} {CodeProduct}</para> 
        /// </summary> 
        private String[] SQLDefault = new String[]
         { 
            //[0] OrderProduct INPUT: {CustomerID} {ProductID} {Quantity} {EventSale} {PriceProduct} {PriceTransport} {TransportID} {CodeProduct}
            "DECLARE @Productid INT; \r\n " +
             "DECLARE @Stock INT; \r\n " +

             "SELECT @Productid = (SELECT ProductID \r\n " +
             "FROM SHOP.dbo.tblProducts \r\n " +
             "WHERE CodeProduct = '{CodeProduct}'); \r\n " +

             "SELECT @Stock = (SELECT Quantity \r\n " +
             "FROM SHOP.dbo.tblStock \r\n " +
             "WHERE ProductID= @Productid); \r\n " +

             "INSERT INTO SHOP.dbo.tblOrderProducts(CustomerID,ProductID,Quantity,EventSaleID,PriceProduct,PriceTransport,TransportID) \r\n " +
             "VALUES ('{CustomerID}',@Productid,'{Quantity}','{EventSale}','{PriceProduct}','{PriceTransport}','{TransportID}'); \r\n " +
          
             "UPDATE SHOP.dbo.tblStock \r\n " +
             "SET Quantity = @Stock - '{Quantity}' \r\n " +
             "WHERE ProductID = @Productid; \r\n ", 

         };
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
                TB_PriceProduct.Text = price;
                TB_DisCount.Text = ShopApp.Shop.Product_Sale.Discount;
                TB_Balance.Text = ((Convert.ToInt32(price) -(Convert.ToInt32(price) * Convert.ToInt32(TB_DisCount.Text) / 100)) + Convert.ToInt32(Tprice))+"";
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
            DataTable dt = SQL.InputSQLMSSQL(SQLDefault[0].Replace("{CustomerID}", ShopApp.Shop.SelectCustomer.ReturnID)
                .Replace("ProductID", ""));
        }

        private void TB_getmoney_TextChanged(object sender, EventArgs e)
        {
            String yod = TB_Balance.Text;
            String get = TB_getmoney.Text;
            try
            {
                if (TB_getmoney.Text != "")
                {
                    if(Convert.ToInt32(TB_getmoney.Text) > Convert.ToInt32(yod))
                    {
                        int a = (Convert.ToInt32(get) - Convert.ToInt32(yod));
                        TB_ton.Text = a+"";
                    }
                    else
                    {
                        TB_ton.Text = "0";
                    }

                }
                else
                {
                    TB_ton.Text = "0";
                }

            }
            catch
            {
                Console.WriteLine("");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
