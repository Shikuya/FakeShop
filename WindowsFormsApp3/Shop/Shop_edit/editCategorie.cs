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
    public partial class editCategorie : Form
    {
        public editCategorie()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT CategorieName, Categorieid \r\n" +
            "FROM tblCategories; \r\n\r\n", new ComboBox[] { CB_Categorie_Show_list });
        }

        private void editCategorie_Load(object sender, EventArgs e)
        {

        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void editCategorie_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void B_Categorie_Save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Categorie = (CB_Categorie_Show_list.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (CB_Categorie_Show_list.Text == "" || TB_Categorie_Chage_name.Text == "")
            {
                MessageBox.Show("กรุณาอย่าเว้นว่างจ้า");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "UPDATE tblCategories \r\n" +
                "SET Categoriename = '" + TB_Categorie_Chage_name + "' \r\n" +
                "WHERE Categorieid= " + Categorie.No + "; \r\n\r\n");
                MessageBox.Show("แก้ไขเรียบร้อย");
                TB_Categorie_Chage_name.Text = "";
                CB_Categorie_Show_list.Text = "";
                CB_Categorie_Show_list.Items.Remove(Categorie.Name);
                CB_Categorie_Show_list.Items.Add(TB_Categorie_Chage_name.Text);
            }
        }
    }
}
