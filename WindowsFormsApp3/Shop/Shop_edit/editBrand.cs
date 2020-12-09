using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop.Shop_edit
{
    public partial class editBrand : Form
    {
        public editBrand()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT BrandName, Brandid \r\n" +
            "FROM tblBrand; \r\n\r\n", new ComboBox[] {CB_Brand_Show_list});
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editBrand_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void editBrand_Load(object sender, EventArgs e)
        {

        }

        private void B_Brand_Save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Brand = (CB_Brand_Show_list.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (CB_Brand_Show_list.Text == "" || TB_Brand_Change_name.Text == "")
            {
                MessageBox.Show("กรุณาอย่าเว้นว่างจ้า");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "UPDATE tblBrand \r\n" +
                "SET Brandname = '"+TB_Brand_Change_name+"' \r\n" +
                "WHERE BrandID= "+ Brand.No+"; \r\n\r\n");
                MessageBox.Show("แก้ไขเรียบร้อย");
                TB_Brand_Change_name.Text = "";
                CB_Brand_Show_list.Text = "";
                CB_Brand_Show_list.Items.Remove(Brand.Name);
                CB_Brand_Show_list.Items.Add(TB_Brand_Change_name.Text);
            }
        }
    }
}
