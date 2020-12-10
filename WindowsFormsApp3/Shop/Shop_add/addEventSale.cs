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
    public partial class addEventSale : Form
    {
        public addEventSale()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT EventSalename , EventSaleID  \r\n" +
            "FROM Shop.dbo.tblEventSale ; \r\n\r\n", new ComboBox[] {CB_event_list});
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void B_event_add_Click(object sender, EventArgs e)
        {
            if (TB_event_name.Text == "" || TB_event_persent.Text == "" || TB_event_descliption.Text == "")
            {
                MessageBox.Show("กรุณากอรกข้อมูลให้ครบถ้วนด้วยนะครับ.");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL("INSERT INTO Shop.dbo.tblEventSale(Discountpercen , Description ,EventSalename) \r\n" +
                "VALUES('" + TB_event_persent.Text + "','" + TB_event_descliption.Text + "','" + TB_event_name.Text + "'); \r\n\r\n");
                MessageBox.Show("เพิ่ม Event เสร็จร้อยแล้วจ้า.");
                CB_event_list.Items.Add(TB_event_name.Text);
                TB_event_descliption.Text = "";
                TB_event_name.Text = "";
                TB_event_persent.Text = "";
            }
        }

        private void CB_event_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem dd = (CB_event_list.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT EVENTSALENAME , Discountpercen , Description  \r\n" +
            "FROM  Shop.dbo.tblEventSale \r\n" +
            "WHERE EventSaleID = " + dd.No + "; \r\n\r\n");
            TB_event_console_list.Text = "Name Event is " + dt.Rows[0][0] + ". \r\n" +
                "Discountpercen is " + dt.Rows[0][1] + " %. \r\n" +
                "Description : " + dt.Rows[0][2] + ".";
        }

        private void addEventSale_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void addEventSale_Load(object sender, EventArgs e)
        {

        }
    }
}
