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
    public partial class editEventSale : Form
    {
        public editEventSale()
        {
            InitializeComponent();
            ShopApp.SQL.LoadComboBoxInformation("SELECT EventSalename , EventSaleID  \r\n" +
            "FROM Shop.dbo.tblEventSale ; \r\n\r\n", new ComboBox[] {CB_Event_Select_Name});
        }

        private void editEventSale_Load(object sender, EventArgs e)
        {

        }

        private void editEventSale_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void B_Event_Save_Click(object sender, EventArgs e)
        {
            ShopApp.Class.ComboBoxItem Event = (CB_Event_Select_Name.SelectedItem as ShopApp.Class.ComboBoxItem);
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT EventSaleName \r\n" +
                "From Shop.dbo.tblEventSale \r\n" +
                "WHERE EventSaleName = '"+TB_Event_Change_name.Text+"' ");
            if(TB_Event_Change_name.Text == ""||TB_Event_Change_Discount.Text == "")
            {
                if (dt.Rows.Count < 1)
                {
                    SQL.InputSQLMSSQL(//[] INPUT: 
                    "UPDATE Shop.dbo.tblEventSale \r\n" +
                    "SET EventSalename='"+TB_Event_Change_name.Text+"', Description='"+TB_Event_Change_Discount.Text+"'" +
                    " , Description = '"+TB_Event_Change_Descliption.Text+"' \r\n" +
                    "WHERE EventSaleID="+Event.No+"; \r\n\r\n");
                    MessageBox.Show("บันทึกเสร็จสิ้น");
                    TB_Event_Change_Descliption.Text = "";
                    TB_Event_Change_Discount.Text = "";
                    TB_Event_Change_name.Text = "";
                    CB_Event_Select_Name.Items.Remove(Event.Name);
                    CB_Event_Select_Name.Items.Add(TB_Event_Change_name.Text);
                }
                else
                {
                    MessageBox.Show("ในระบบีชื่อนี้อยู่แล้วกรุณาลองชื่อใหม่ครับ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาอย่าเว้นว่างจ้า");
            }
        }
    }
}
