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
    public partial class editTransprort : Form
    {
        public editTransprort()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT tblTransportname, tblTransportid \r\n" +
            "FROM GeneralData.dbo.tblTransport; \r\n\r\n", new ComboBox[] { CB_Transport_Change_Show_TransportName});
        }

        private void editTransprort_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void editTransprort_Load(object sender, EventArgs e)
        {

        }

        private void B_Transport_Save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Transprot = (CB_Transport_Change_Show_TransportName.SelectedItem as ShopApp.Class.ComboBoxItem);
            if (TB_Transport_Change_name.Text == "" || CB_Transport_Change_Show_TransportName.Text == "")
            {
                MessageBox.Show("กรอกข้อมูลก่อนนะครับ");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL(//[] INPUT: 
                "UPDATE GeneralData.dbo.tblTransport \r\n" +
                "SET Transportname = '"+TB_Transport_Change_name+"', TransportDetail= '"+TB_Transport_Change_Detail+"' \r\n" +
                "WHERE TransportID = "+ Transprot.No+ "; \r\n\r\n");
                MessageBox.Show("บันทึกเสร็จสิ้น");
                CB_Transport_Change_Show_TransportName.Text = "";
                TB_Transport_Change_Detail.Text = "";
                TB_Transport_Change_name.Text = "";
                CB_Transport_Change_Show_TransportName.Items.Remove(Transprot.Name);
                CB_Transport_Change_Show_TransportName.Items.Add(TB_Transport_Change_name.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
