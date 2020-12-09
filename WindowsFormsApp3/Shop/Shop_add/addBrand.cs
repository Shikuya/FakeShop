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
    public partial class addBrand : Form
    {
        public addBrand()
        {
            InitializeComponent();
        }

        private void B_add_brand_Click(object sender, EventArgs e)
        {
            ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "INSERT INTO tblBrand(Brandname) \r\n" +
            "VALUES ('"+ TBBrand_Add_Brand +"'); \r\n\r\n");
        }

        private void CBCategorie_Add_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TBBrand_Add_Brand.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบครับ");
            }
            else
            {
            ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblBrand(Brandname) \r\n"+
            "VALUES('"+TBBrand_Add_Brand.Text+"'); ");
                MessageBox.Show("เพิ่ม Brand เรียบร้อยแล้วครับ");
                TBBrand_Add_Brand.Text = "";
            }

        }

        private void addBrand_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this , panel1);
        }
    }
}
