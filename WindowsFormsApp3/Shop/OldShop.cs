using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Shop
{
    public partial class OldShop : Form
    {

        public OldShop()
        {
            //Start Program
            InitializeComponent();
            Re();
            tabControl1.Visible = false;
            GBTESTCODE.Visible = false;
            GBorder.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { //คลิกรูปออก
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void SHOP_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Cleartex();
            Re();
            //ตัวเลือก RadioButton Add ได้ถูกกด
            if (RBAdd.Checked == true)
            {
                //Page Add Categorie
                tabControl1.Visible = true;
                GBTESTCODE.Visible = false;
                BCategorie.Text = "Add Categorie";
                TBNameCategorie.Visible = true;
                CBNameCategorie.Visible = false;
                TBcategorieDesciption.ReadOnly = false;
                TBcategorieDesciption.BackColor = Color.White;
                TBQuantityProduct.BackColor = Color.White;
                TBQuantityProduct.ForeColor = Color.Black;


                //Page Add Product
                TBProductName.Visible = true;
                CBProduct.Visible = false;
                GBProduct.Text = "Add Product";
                TBCostProduct.ReadOnly = false;
                TBSellProduct.ReadOnly = false;
                TBQuantityProduct.ReadOnly = false;
                Bproduct.Text = "Add Product";
                TBCostProduct.BackColor = Color.White;
                TBSellProduct.BackColor = Color.White;

                //Page Add Event
                TBSalePer.ReadOnly = false;
                TBdescliptionEvent.ReadOnly = false;
                TBSalePer.BackColor = Color.White;
                TBdescliptionEvent.BackColor = Color.White;
                TBdescliptionEvent.ForeColor = Color.Black;
                TBSalePer.ForeColor = Color.Black;
                BEVENT.Text = "Add Event";
                CBNAMEVENT.Visible = false;

                //Page Add Transport
                CBnametran.Visible = false;
                TBtransportDetail.ReadOnly = false;
                TBtransportDetail.BackColor = Color.White;
                BTransport.Text = "Add Transport";

                //Page Add Brand
                CBbra.Visible = false;
                BBrand.Text = "Add Brand";

                //Page Add Customer
                TBnamecustomer.ReadOnly = false;
                TBIDCARD.ReadOnly = false;
                TBADDRESS.ReadOnly = false;
                TBPHONENUM.ReadOnly = false;
                CBCustomer.Visible = false;
                BCustomer.Text = "Add Customer";

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Cleartex();
            Re();
            //ตัวเลือก RadioButton Delete ได้้ถูกกด
            if (RBDelete.Checked == true)
            {
                //Page Delete Cateegorie
                tabControl1.Visible = true;
                GBTESTCODE.Visible = false;
                CBNameCategorie.Visible = true;
                TBNameCategorie.Visible = false;
                TBcategorieDesciption.Text = "";
                TBcategorieDesciption.ReadOnly = true;
                BCategorie.Text = "Delete Categorie";
                TBQuantityProduct.BackColor = Color.White;
                TBQuantityProduct.ForeColor = Color.Black;
                TBcategorieDesciption.BackColor = System.Drawing.Color.Black;

                //Page Delete Product
                TBQuantityProduct.Text = "";
                TBQuantityProduct.BackColor = Color.Black;
                TBQuantityProduct.ForeColor = Color.Green;
                TBQuantityProduct.ReadOnly = true;
                TBProductName.Visible = false;
                CBProduct.Visible = true;
                GBProduct.Text = "DELETE Product";
                TBCostProduct.ReadOnly = true;
                TBSellProduct.ReadOnly = true;
                Bproduct.Text = "Delete product";
                TBCostProduct.BackColor = Color.Black;
                TBSellProduct.BackColor = Color.Black;

                //Page Delete Event
                TBSalePer.ReadOnly = true;
                TBdescliptionEvent.ReadOnly = true;
                TBSalePer.BackColor = Color.Black;
                TBdescliptionEvent.BackColor = Color.Black;
                TBdescliptionEvent.ForeColor = Color.LightGreen;
                TBSalePer.ForeColor = Color.LightGreen;
                BEVENT.Text = "Delete Event";
                CBNAMEVENT.Visible = true;

                //Page Delete Transport
                CBnametran.Visible = true;
                TBtransportDetail.ReadOnly = true;
                TBtransportDetail.BackColor = Color.Black;
                BTransport.Text = "Delete Transport";

                //Page Delete Brand
                CBbra.Visible = true;
                BBrand.Text = "Delete Brand";

                //Page Delete Customer
                TBnamecustomer.ReadOnly = true;
                TBIDCARD.ReadOnly = true;
                TBADDRESS.ReadOnly = true;
                TBPHONENUM.ReadOnly = true;
                CBCustomer.Visible = true;
                BCustomer.Text = "Delete Customer";
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            //มีการกดปุ่ม ใน Page Brand
            if (e.KeyCode == Keys.Enter)
            {
                InputBrand();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ปุ่มใน Add Brand
            ShopApp.Class.ComboBoxItem brandid = (CBNameBrand.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (RBAdd.Checked == true)
            {
                if (TBbrand_add__brand.Text == "")
                {
                    MessageBox.Show("กรุณาอย่าเว้นช่องว่างครับ");
                }
                else
                {
                    InputBrand();
                }

            }
            else
            {
                if (CBbra.Text == "")
                {
                    MessageBox.Show("กรุณาอย่าเว้นช่องว่างครับ");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("DELETE FROM tblBrand \r\n" +
                    "WHERE BrandID = " + brandid.No + " ; \r\n\r\n");
                    MessageBox.Show("ลบแแบรนเรียบร้อยจร้า");
                    Cleartex();
                    Re();
                }
            }
        }

        private void InputBrand()
        {
            ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblbrand(brandname) \r\n" +
            "VALUES ('" + TBbrand_add__brand.Text + "'); \r\n\r\n" +
            "SELECT Scope()");
            MessageBox.Show("เพิ่มแบรนเสร็จเรียบร้อย.");
            Cleartex();
            Re();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Brand")
            {
                Cleartex();
            }
            else if (tabControl1.SelectedTab.Text == "Categorie")
            {

            }
            else if (tabControl1.SelectedTab.Text == "Product")
            {

            }
            else if (tabControl1.SelectedTab.Text == "Event")
            {

            }
            else if (tabControl1.SelectedTab.Text == "Transport")
            {

            }
            else if (tabControl1.SelectedTab.Text == "Stock")
            {

            }
            else if (tabControl1.SelectedTab.Text == "Customer")
            {

            }
        }

        private void Re()
        {
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
            "FROM tblBrand; \r\n\r\n", new ComboBox[] { CBNameBrand, CBBrandNameproduct, CBTBrandname, CBstockBrandname, CBbra, CBOBRAND });
            ShopApp.SQL.LoadComboBoxInformation("SELECT EventSalename , EventSaleID  \r\n" +
            "FROM tblEventSale ; \r\n\r\n", new ComboBox[] { CBNAMEVENT, CBnameeventlist, CBTCODE, CBOevnet });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Transportname , TransportID  \r\n" +
            "FROM tbltransport ; \r\n\r\n", new ComboBox[] { CBnametran, CBOTransport });
            ShopApp.SQL.LoadComboBoxInformation("SELECT Customername , CustomerID  \r\n" +
            "FROM tblCustomers ; \r\n\r\n", new ComboBox[] { CBCustomer, CBOCustomer });
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBNameBrand.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBNameCategorie.Items.Clear();
            if (RBDelete.Checked == true)
            {
                for (int a = 0; a < dd.No.Length; a++)
                {
                    ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , CategorieID  \r\n" +
                "FROM tblCategories as a \r\n" +
                "LEFT JOIN tblBrand as b on a.BrandID = b.BrandID \r\n" +
                "WHERE b.BrandID = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBNameCategorie });
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cleartex();
            Re();
        }
        private void Cleartex()
        {
            TBNameCategorie.Text = "";
            TBcategorieDesciption.Text = "";
            TBbrand_add__brand.Text = "";
            TBcategorieDesciption.Text = "";
            TBProductName.Text = "";
            TBQuantityProduct.Text = "";
            TBConsoleStock.Text = "";
            TBSellProduct.Text = "";
            TBCostProduct.Text = "";
            TBNameEvent.Text = "";
            TBdescliptionEvent.Text = "";
            TBSalePer.Text = "";
            TBtransportDetail.Text = "";
            TBnameTran.Text = "";
            TBnamecustomer.Text = "";
            TBIDCARD.Text = "";
            TBADDRESS.Text = "";
            TBPHONENUM.Text = "";
            TBconsoleTestcode.Text = "";
            TBOconsole.Text = "";
            TBOpriceproduct.Text = "";
            TBOpricetransport.Text = "";

            CBBrandNameproduct.Items.Clear();
            CBcategorieProduct.Items.Clear();
            CBNameBrand.Items.Clear();
            CBNameCategorie.Items.Clear();
            CBProduct.Items.Clear();
            CBNAMEVENT.Items.Clear();
            CBnameeventlist.Items.Clear();
            CBnametran.Items.Clear();
            CBstockBrandname.Items.Clear();
            CBstockCategorie.Items.Clear();
            CBstockProduct.Items.Clear();
            CBCustomer.Items.Clear();
            CBTBrandname.Items.Clear();
            CBTcategoriename.Items.Clear();
            CBTproductname.Items.Clear();
            CBbra.Items.Clear();
            CBTCODE.Items.Clear();
            CBOBRAND.Items.Clear();
            CBOCATEGORIE.Items.Clear();
            CBOCustomer.Items.Clear();
            CBOevnet.Items.Clear();
            CBOProduct.Items.Clear();
            CBOquantity.Items.Clear();
            CBOTransport.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void RBOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (RBOFF.Checked == true)
            {
                tabControl1.Visible = false;
                GBTESTCODE.Visible = false;
            }
            else
            {
                tabControl1.Visible = true;
                GBTESTCODE.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem addbrandid = (CBBrandNameproduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem addcategorieid = (CBcategorieProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (RBAdd.Checked == true)
            {
                if (CBBrandNameproduct.Text == "" || CBcategorieProduct.Text == "" || TBProductName.Text == "" || TBCostProduct.Text == "" || TBSellProduct.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ.");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                    "DECLARE @ProductID INT; \r\n" +
                    "DECLARE @PriceID INT; \r\n \r\n" +

                    "INSERT INTO tblPrice(CostPrice , PriceSell , UserID) \r\n" +
                    "VALUES ('" + TBCostProduct.Text + "','" + TBSellProduct.Text + "','" + ShopApp.Class.AccountInfo.AccountNo + "'); \r\n \r\n" +

                    "SELECT @PriceID = SCOPE_IDENTITY(); \r\n  \r\n" +

                    "INSERT INTO tblProducts(Productname , CategorieID,PriceID)  \r\n" +
                    "VALUES ('" + TBProductName.Text + "','" + addcategorieid.No + "',@PriceID); \r\n  \r\n" +

                    "SELECT @ProductID = SCOPE_IDENTITY(); \r\n  \r\n" +

                    "INSERT INTO tblDateAddProduct(ProductID , Quantity ,PriceID)  \r\n" +
                    "VALUES (@Productid,'" + TBQuantityProduct.Text + "',@PriceID); \r\n \r\n" +

                    "INSERT INTO tblStock(ProductID,Quantity)  \r\n" +
                    "VALUES (@ProductID,'" + TBQuantityProduct.Text + "'); \r\n\r\n");
                    MessageBox.Show("เพิ่มสินค้าเรียบร้อย.");
                    Cleartex();
                    Re();
                }

            }
            else
            {
                if (CBBrandNameproduct.Text == "" || CBcategorieProduct.Text == "" || CBProduct.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ.");
                }
                else
                {
                    MessageBox.Show("ไม่อนุญาติให้ลบ.");
                }
            }
        }

        private void BCategorie_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem ad = (CBNameBrand.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem de = (CBNameCategorie.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (RBAdd.Checked == true)
            {
                if (TBNameCategorie.Text == "" || CBNameBrand.Text == "")
                {
                    MessageBox.Show("กรุณาอย่าเว้นช่องว่างครับ");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblCategories(Categoriename , BrandID ,ShortDesciption) \r\n" +
                    "VALUES ('" + TBNameCategorie.Text + "'," + ad.No + ",'" + TBcategorieDesciption.Text + "'); \r\n\r\n");
                    MessageBox.Show("เพิ่มเสร็จเรียบร้อย.");
                    Cleartex();
                    Re();
                }

            }
            else
            {
                if (CBNameCategorie.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ.");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("DELETE FROM tblCategories \r\n" +
                "WHERE CategorieID = " + de.No + "; \r\n\r\n");
                    MessageBox.Show("ลบเสร็จเรียบร้อย.");
                    Cleartex();
                    Re();
                }
            }
        }

        private void CBBrandNameproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBBrandNameproduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBcategorieProduct.Items.Clear();
            for (int a = 0; a < dd.No.Length; a++)
            {
                ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , CategorieID  \r\n" +
            "FROM tblCategories as a \r\n" +
            "LEFT JOIN tblBrand as b on a.BrandID = b.BrandID \r\n" +
            "WHERE b.BrandID = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBcategorieProduct });
            }
        }

        private void CBcategorieProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBcategorieProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBProduct.Items.Clear();
            for (int a = 0; a < dd.No.Length; a++)
            {
                ShopApp.SQL.LoadComboBoxInformation("SELECT Productname , ProductID  \r\n" +
                "FROM tblProducts as a \r\n" +
                "LEFT JOIN tblCategories as b on a.categorieid = b.categorieid \r\n" +
                "WHERE b.categorieid = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBProduct });
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (RBAdd.Checked == true)
            {
                if (TBNameEvent.Text == "" || TBSalePer.Text == "" || TBdescliptionEvent.Text == "")
                {
                    MessageBox.Show("กรุณากอรกข้อมูลให้ครบถ้วนด้วยนะครับ.");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblEventSale(Discountpercen , Description ,EventSalename) \r\n" +
                    "VALUES('" + TBSalePer.Text + "','" + TBdescliptionEvent.Text + "','" + TBNameEvent.Text + "'); \r\n\r\n");
                    MessageBox.Show("เพิ่มอีเว้นลดราคาเรียบร้อยแล้วจ้า.");
                    Cleartex();
                    Re();
                }
            }
            else
            {
                if (TBNameEvent.Text == "" || TBSalePer.Text == "" || TBdescliptionEvent.Text == "")
                {
                    MessageBox.Show("กรุณากอรกข้อมูลให้ครบถ้วนด้วยนะครับ.");
                }
                else
                {
                    MessageBox.Show("ไม่อนุญาติให้ลบเพราะจะะมาดูประวัตไม่ได้.");
                }
            }
        }

        private void CBnameeventlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBnameeventlist.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT EVENTSALENAME , Discountpercen , Description  \r\n" +
            "FROM  tblEventSale \r\n" +
            "WHERE EventSaleID = " + dd.No + "; \r\n\r\n");
            TBConsolenameevent.Text = "Name Event is " + dt.Rows[0][0] + ". \r\n" +
                "Discountpercen is " + dt.Rows[0][1] + " %. \r\n" +
                "Description : " + dt.Rows[0][2] + ".";
        }

        private void BTransport_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem tranid = (CBnametran.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (RBAdd.Checked == true)
            {
                if (TBnameTran.Text == "")
                {
                    MessageBox.Show("อย่าเว้นช่องว่างนะครับ");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblTransport(Transportname , TransportDetail) \r\n" +
                    "VALUES ('" + TBnameTran.Text + "','" + TBtransportDetail.Text + "'); \r\n\r\n");
                    MessageBox.Show("เพิ่มขนส่งเรียบร้อย.");
                    Cleartex();
                }
            }
            else
            {
                if (CBnametran.Text == "")
                {
                    MessageBox.Show("อย่าเว้นช่องว่างนะครับ");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL("DELETE FROM tblTransport \r\n" +
            "WHERE TransportID = " + tranid.No + " ; \r\n\r\n");
                    MessageBox.Show("ลบขนส่งนั้นเรียบร้อย");
                    Cleartex();
                    Re();
                }
            }
        }

        private void CBstockBrandname_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBstockCategorie.Items.Clear();
            CBstockProduct.Items.Clear();
            TBConsoleStock.Text = "";
            ShopApp.Class.ComboBoxItem BrandID = (CBstockBrandname.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , Categorieid  \r\n" +
            "FROM tblCategories as a \r\n" +
            "LEFT JOIN tblbrand as b on a.BrandID = b.BrandID \r\n" +
            "WHERE a.BrandID = " + BrandID.No + " ; \r\n\r\n", new ComboBox[] { CBstockCategorie });
        }

        private void CBstockCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBstockProduct.Items.Clear();
            ShopApp.Class.ComboBoxItem CategorisID = (CBstockCategorie.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.SQL.LoadComboBoxInformation("SELECT Productname , Productid  \r\n" +
            "FROM tblProducts as a \r\n" +
            "LEFT JOIN tblCategories as b on a.CategorieID = b.CategorieID \r\n" +
            "WHERE a.CategorieID = " + CategorisID.No + " ; \r\n\r\n", new ComboBox[] { CBstockProduct });
        }

        private void CBstockProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem idproduct = (CBstockProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Productname , Quantity , PriceSell \r\n" +
            "FROM tblProducts as a \r\n" +
            "LEFT JOIN tblStock as b on a.ProductID = b.ProductID \r\n" +
            "LEFT JOIN tblPrice as c on a.PriceID = c.PriceID  \r\n" +
            "WHERE a.ProductID = " + idproduct.No + "; \r\n\r\n");
            TBConsoleStock.Text = "name : " + dt.Rows[0][0] + " . \r\n" +
                "Quantity IN Stock : " + dt.Rows[0][1] + " . \r\n" +
                "PriceSell : " + dt.Rows[0][2] + " BTH.";
        }

        private void BCustomer_Click(object sender, EventArgs e)
        {
            if (RBAdd.Checked == true)
            {
                if (TBADDRESS.Text == "" || TBIDCARD.Text == "" || TBnamecustomer.Text == "" || TBPHONENUM.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วนด้วยครับ.");
                }
                else
                {
                    ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                    "INSERT INTO tblCustomers(Customername , IDcardnum , Address , PhoneNumber) \r\n" +
                    "VALUES ('" + TBnamecustomer.Text + "','" + TBIDCARD.Text + "','" + TBADDRESS.Text + "','" + TBPHONENUM.Text + "'); \r\n\r\n");
                    MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้วครับ");
                    Cleartex();
                }
            }
            else
            {
                Cleartex();
                Re();
                if (CBCustomer.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบครับ");
                }
                else
                {
                    ShopApp.Class.ComboBoxItem idcustomer = (CBCustomer.SelectedItem as ShopApp.Class.ComboBoxItem);
                    ShopApp.SQL.InputSQLMSSQL(
                    "DELETE FROM tblCustomers \r\n" +
                    "WHERE CustomerID = " + idcustomer.No + "; \r\n\r\n");
                    MessageBox.Show("ลบผู้ใช้เรียบร้อยแล้ว");
                    Cleartex();
                }
            }
        }

        private void RBTESTCODE_CheckedChanged(object sender, EventArgs e)
        {
            Cleartex();
            Re();
            if (RBTESTCODE.Checked == true)
            {
                tabControl1.Visible = false;
                GBTESTCODE.Visible = true;
            }
        }

        private void CBBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTBrandname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBTBrandname.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBTcategoriename.Items.Clear();
            if (RBTESTCODE.Checked == true)
            {
                for (int a = 0; a < dd.No.Length; a++)
                {
                    ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , CategorieID  \r\n" +
                    "FROM tblCategories as a \r\n" +
                    "LEFT JOIN tblBrand as b on a.BrandID = b.BrandID \r\n" +
                    "WHERE b.BrandID = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBTcategoriename });
                }
            }
        }

        private void CBTcategoriename_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBTcategoriename.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBTproductname.Items.Clear();
            for (int a = 0; a < dd.No.Length; a++)
            {
                ShopApp.SQL.LoadComboBoxInformation("SELECT Productname , ProductID  \r\n" +
            "FROM tblProducts as a \r\n" +
            "LEFT JOIN tblCategories as b on a.categorieid = b.categorieid \r\n" +
            "WHERE b.categorieid = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBTproductname });
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (CBTBrandname.Text == "" || CBTcategoriename.Text == "" || CBTCODE.Text == "" || CBTproductname.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบจร้า");
            }
            else
            {
                ShopApp.Class.ComboBoxItem idproduct = (CBTproductname.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem idevent = (CBTCODE.SelectedItem as ShopApp.Class.ComboBoxItem);
                DataSet ds = ShopApp.SQL.InputSQLMSSQLDS(//[] INPUT: 
                "SELECT Productname , Quantity , PriceSell  \r\n" +
                "FROM tblProducts as a  \r\n" +
                "LEFT JOIN tblStock as b on a.ProductID = b.ProductID  \r\n" +
                "LEFT JOIN tblPrice as c on a.PriceID = c.PriceID   \r\n" +
                "WHERE a.ProductID = " + idproduct.No + " ; \r\n" +

                "SELECT Discountpercen \r\n" +
                "FROM tblEventSale \r\n" +
                "WHERE EventSaleID = " + idevent.No + "; \r\n\r\n");
                TBconsoleTestcode.Text = "Product : " + ds.Tables[0].Rows[0][0] + ". \r\n" +
                "Quantity : " + ds.Tables[0].Rows[0][1] + ". \r\n" +
                "Full Price : " + ds.Tables[0].Rows[0][2] + ". \r\n" +
                "Code : " + CBTCODE.SelectedItem + ". \r\n " +
                "DiscountPer : " + ds.Tables[1].Rows[0][0] + "% . \r\n" +
                "Price : " + (Convert.ToInt32(ds.Tables[0].Rows[0][2]) - (Convert.ToInt32(ds.Tables[0].Rows[0][2]) * Convert.ToInt32(ds.Tables[1].Rows[0][0]) / 100)) + ".";
            }


        }

        private void RBOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (RBOrder.Checked == true)
            {
                GBorder.Visible = true;
                GBTESTCODE.Visible = false;
                tabControl1.Visible = false;
            }
            else
            {
                GBorder.Visible = false;
            }
        }

        private void GBorder_Enter(object sender, EventArgs e)
        {

        }

        private void CBOBRAND_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CBOBRAND.SelectedItem as ShopApp.Class.ComboBoxItem);
            CBOCATEGORIE.Items.Clear();
            if (RBOrder.Checked == true)
            {
                for (int a = 0; a < dd.No.Length; a++)
                {
                    ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , CategorieID  \r\n" +
                "FROM tblCategories as a \r\n" +
                "LEFT JOIN tblBrand as b on a.BrandID = b.BrandID \r\n" +
                "WHERE b.BrandID = " + dd.No + "; \r\n\r\n", new ComboBox[] { CBOCATEGORIE });
                }
            }
        }

        private void CBOCATEGORIE_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOProduct.Items.Clear();
            ShopApp.Class.ComboBoxItem CategorisID = (CBOCATEGORIE.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.SQL.LoadComboBoxInformation("SELECT Productname , Productid  \r\n" +
            "FROM tblProducts as a \r\n" +
            "LEFT JOIN tblCategories as b on a.CategorieID = b.CategorieID \r\n" +
            "WHERE a.CategorieID = " + CategorisID.No + " ; \r\n\r\n", new ComboBox[] { CBOProduct });
        }

        private void CBOProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOquantity.Items.Clear();
            ShopApp.Class.ComboBoxItem count = (CBOProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Quantity \r\n" +
            "FROM tblProducts as a \r\n" +
            "LEFT JOIN tblStock as b on a.ProductID = b.ProductID \r\n" +
            "WHERE a.ProductID = " + count.No + "; \r\n\r\n");
            for (int a = 1; a <= Convert.ToInt32(dt.Rows[0][0]); a++)
            {
                CBOquantity.Items.Add(a);
            }
        }

        private void CBOquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem product = (CBOProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
            ShopApp.Class.ComboBoxItem idevent = (CBOevnet.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (CBOevnet.Text == "")
            {
                DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT PriceSell \r\n" +
                "FROM tblPrice as a \r\n" +
                "LEFT JOIN tblProducts as b on a.PriceID = b.PriceID \r\n" +
                "WHERE ProductID = " + product.No + ";");
                TBOconsole.Text = "" + (Convert.ToInt32(dt.Rows[0][0]) * Convert.ToInt32(CBOquantity.SelectedItem));
            }
            else
            {
                DataSet ds = ShopApp.SQL.InputSQLMSSQLDS("SELECT PriceSell \r\n" +
                "FROM tblPrice as a \r\n" +
                "LEFT JOIN tblProducts as b on a.PriceID = b.PriceID \r\n" +
                "WHERE ProductID = " + product.No + "; \r\n\r\n" +

                "SELECT Discountpercen \r\n" +
                "FROM tblEventSale \r\n" +
                "WHERE EventSaleID = " + idevent.No + "; \r\n\r\n");
                TBOconsole.Text = "" + (Convert.ToInt32(ds.Tables[0].Rows[0][0]) * Convert.ToInt32(CBOquantity.SelectedItem));
                TBOconsole.Text = "" + (Convert.ToInt32(ds.Tables[0].Rows[0][0]) * Convert.ToInt32(CBOquantity.SelectedItem) - (Convert.ToInt32(ds.Tables[0].Rows[0][0]) * Convert.ToInt32(CBOquantity.SelectedItem) * Convert.ToInt32(ds.Tables[1].Rows[0][0]) / 100));
            }


        }

        private void BOCLEAR_Click(object sender, EventArgs e)
        {
            Cleartex();
            Re();
        }

        private void BOADD_Click(object sender, EventArgs e)
        {
            if (CBOBRAND.Text == "" || CBOCATEGORIE.Text == "" || CBOCustomer.Text == "" || CBOevnet.Text == "" || CBOProduct.Text == "" || CBOquantity.Text == "" || CBOTransport.Text == "" || TBOpriceproduct.Text == "" || TBOpricetransport.Text == "")
            {
                MessageBox.Show("กรอกข้อมูลให้เรียบร้อยนนะจ๊ะ");
            }
            else
            {
                ShopApp.Class.ComboBoxItem CUSTOMERID = (CBOCustomer.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem ProductID = (CBOProduct.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem Eventid = (CBOevnet.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.Class.ComboBoxItem TransportID = (CBOTransport.SelectedItem as ShopApp.Class.ComboBoxItem);
                DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Quantity \r\n" +
                "FROM tblStock \r\n" +
                "WHERE ProductID = " + ProductID.No + "; \r\n\r\n");
                ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblOrderProducts(CustomerID , ProductID , Quantity , EventSaleID , PriceProduct , PriceTransport , TransportID) \r\n" +
                "VALUES ('" + CUSTOMERID.No + "','" + ProductID.No + "','" + CBOquantity.SelectedItem + "','" + Eventid.No + "','" + TBOpriceproduct.Text + "','" + TBOpricetransport.Text + "','" + TransportID.No + "'); \r\n\r\n" +
                "UPDATE tblStock \r\n" +
                "SET Quantity = " + (Convert.ToInt32(dt.Rows[0][0]) - Convert.ToInt32(CBOquantity.SelectedItem)) + " \r\n" +
                "WHERE ProductID = " + ProductID.No + "; \r\n\r\n");
                MessageBox.Show("สั่งออเดอร์นี้เข้าไปเรียบร้ออยจร้า");
            }

        }

        private void CBCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBPHONENUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void TBADDRESS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void TBIDCARD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void TBnamecustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}