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
    public partial class deleteTransport : Form
    {
        public deleteTransport()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT Transportname , TransportID  \r\n" +
            "FROM General.dbo.tbltransport ; \r\n\r\n", new ComboBox[] {CB_Transport_name});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CB_Transport_name.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลก่อนนะครับ");
            }
            else
            {
                ShopApp.Class.ComboBoxItem Tran = (CB_Transport_name.SelectedItem as ShopApp.Class.ComboBoxItem);
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "DELETE FROM GeneralData.dbo.tblTransport \r\n" +
                "WHERE TransportID = "+Tran.No+"; \r\n\r\n");
                CB_Transport_name.Items.Remove(Tran.Name);
                MessageBox.Show("ลบขนส่งนี้เรียบร้อย");
                CB_Transport_name.Text = "";
            }

        }

        private void deleteTransport_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteTransport_Load(object sender, EventArgs e)
        {

        }
    }
}
