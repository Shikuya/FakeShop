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
    public partial class deleteCategorie : Form
    {
        public deleteCategorie()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Categoriename , Categorieid  \r\n" +
            "FROM tblCategories ; \r\n\r\n", new ComboBox[] { CB_Categorie_name });
        }

        private void B_Categorie_Delete_Click(object sender, EventArgs e)
        {
            if (CB_Categorie_name.Text == "")
            {
                MessageBox.Show("กรุณาอย่าใส่ช่องว่างครับ");
            }
            else
            {
                ShopApp.Class.ComboBoxItem Categorie = (CB_Categorie_name.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: Delete
                "DELETE FROM tblCategories \r\n" +
                "WHERE Categorieid = " + Categorie.No + "; \r\n\r\n");
                MessageBox.Show("ลบเสร็๋จเรียบร้อยแล้วครับ");
                CB_Categorie_name.Text = "";
                CB_Categorie_name.Items.Remove(Categorie.Name);
            }
        }

        private void deleteCategorie_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }
    }
}
