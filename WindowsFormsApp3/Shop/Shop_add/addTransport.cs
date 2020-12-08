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
    public partial class addTransport : Form
    {
        public addTransport()
        {
            InitializeComponent();
        }

        private void B_transport_add_Click(object sender, EventArgs e)
        {
            if (TB_transport_name.Text == "")
            {
                MessageBox.Show("อย่าเว้นช่องว่างนะครับ");
            }
            else
            {
                ShopApp.SQL.InputSQLMSSQL("INSERT INTO tblTransport(Transportname , TransportDetail) \r\n" +
                "VALUES ('" + TB_transport_name.Text + "','" + TB_transport_Detail.Text + "'); \r\n\r\n");
                MessageBox.Show("เพิ่มขนส่งเรียบร้อย.");
                TB_transport_Detail.Text = "";
                TB_transport_name.Text = "";
            }
        }
    }
}
