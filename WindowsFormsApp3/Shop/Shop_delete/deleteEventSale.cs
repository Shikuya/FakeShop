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
    public partial class deleteEventSale : Form
    {
        public deleteEventSale()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT EventSalename , EventSaleID  \r\n" +
            "FROM tblEventSale ; \r\n\r\n", new ComboBox[] {CB_Event_name});
        }

        private void deleteEventSale_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void B_Customer_Delete_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Event = (CB_Event_name.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (CB_Event_name.Text == "")
            {
                MessageBox.Show("กรุณาเลือก Event ก่อนนะครับ");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
            "DELETE FROM tblEventSale \r\n" +
            "WHERE EventSaleID = "+Event.No+"; \r\n\r\n");
                CB_Event_name.Items.Remove(Event.Name);
                MessageBox.Show("ลบเสร็จเรียบร้อยแล้วครับ");
                CB_Event_name.Text = "";
            }
        }
    }
}
