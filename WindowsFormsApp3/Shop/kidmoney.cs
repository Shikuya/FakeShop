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
        /// <para>[0]INSERT ORDER 1/2 INPUT: {Customer} {Event} {PriceOrder} {PriceTransport} {TransportID} </para> 
        /// <para>[1]INSERT ORDER 2/2 INPUT: {Quantity} {OrderID} {ProductID} </para>
        /// </summary> 
        private String[] SQLDefault = new String[]
         { 
             //[0]INSERT ORDER 1/2 INPUT: 
            "DECLARE @OrderID INT; \r\n " +
             "INSERT INTO SHOP.dbo.tblOrderProducts (CustomerID,EventSaleID , PriceOrder , PriceTransport , TransportID) \r\n " +
             "VALUES('{Customer}','{Event}','{PriceOrder}','{PriceTransport}','{TransportID}'); \r\n " +
             "SELECT @OrderID = SCOPE_IDENTITY(); \r\n " +
             "SELECT @OrderID ;",

            //[1]INSERT ORDER 2/2 INPUT: {Quantity} {OrderID} {ProductID} 
             "DECLARE @Stock INT; \r\n " +
             " \r\n " +
             "SELECT @Stock = (SELECT Quantity \r\n " +
             "FROM SHOP.dbo.tblStock \r\n " +
             "WHERE ProductID= {ProductID}); \r\n " +
             " \r\n " +
             " UPDATE SHOP.dbo.tblStock \r\n " +
             "SET Quantity = @Stock - '{Quantity}' \r\n " +
             "WHERE ProductID = {ProductID};  \r\n " +
             " \r\n " +
             "INSERT INTO SHOP.dbo.tblOrderDetail(OrderID , ProductID , Quantity) \r\n " +
             "VALUES ('{OrderID}','{ProductID}','{Quantity}'); "
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
                if(TB_DisCount.Text == "")
                {
                    TB_DisCount.Text = "0";
                }
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

        private void B_Confirm_Click(object sender, EventArgs e) //กดปุ่ม
        {
            if (Convert.ToString(ShopApp.Shop.Product_Sale.TransportID) == "")
            {
                ShopApp.Shop.Product_Sale.TransportID = "0";
            }
            //if(ShopApp.Shop.Product_Sale.)
            DataTable dt = SQL.InputSQLMSSQL(SQLDefault[0].Replace("{Customer}", ShopApp.Shop.SelectCustomer.ReturnID)
                .Replace("{Event}", ShopApp.Shop.Product_Sale.Discount)
                .Replace("{PriceOrder}",""+ShopApp.Shop.Product_Sale.Price)
                .Replace("{PriceTransport}",""+ShopApp.Shop.Product_Sale.PriceTransport)
                .Replace("{TransportID}",ShopApp.Shop.Product_Sale.TransportID));

            for (int a = 0; a < ShopApp.Shop.Product_Sale.IDPrductDGV.Count; a++)
            {//เพิมเติม Detail ใช้ไม่ได้
                SQL.InputSQLMSSQL(SQLDefault[1].Replace("{Quantity}", "" + ShopApp.Shop.Product_Sale.QuantityDGV)
                    .Replace("{OrderID}" , ""+dt.Rows[0][0])
                    .Replace("ProductID" , ""+ShopApp.Shop.Product_Sale.IDPrductDGV));
            }
            MessageBox.Show("a");
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
