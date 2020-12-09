using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop.Shop_delete
{
    public partial class deleteBrand : Form
    {
        public deleteBrand()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Brandname , Brandid  \r\n" +
            "FROM tblBrand ; \r\n\r\n", new ComboBox[] { CB_Brand_name });
        }

        private void B_Brand_Delete_Click(object sender, EventArgs e)
        {
            if (CB_Brand_name.Text == "")
            {
                MessageBox.Show("กรุณาอย่าใส่ช่องว่างครับ");
            }
            else
            {
                ShopApp.Class.ComboBoxItem brand = (CB_Brand_name.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: Delete
                "DELETE FROM tblBrand \r\n" +
                "WHERE BrandID = "+brand.No+"; \r\n\r\n");
                MessageBox.Show("ลบเสร็๋จเรียบร้อยแล้วครับ");
                CB_Brand_name.Text = "";
                CB_Brand_name.Items.Remove(brand.Name);
            }

        }

        private void deleteBrand_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }
    }
}
