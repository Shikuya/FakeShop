using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT zonename , zoneid \n" +
            "FROM GeneralData.dbo.tblzone");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox6.Items.Add(dt.Rows[a][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + comboBox1.SelectedItem + " " + comboBox2.SelectedItem + " " + comboBox3.SelectedItem + " " + textBox1.Text + "", "Show", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult YesNo = MessageBox.Show("Why u Click me ?", "Why?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (YesNo == DialogResult.Yes)
            {
                int a = 1;
                while (a < 10)
                {
                    MessageBox.Show(Convert.ToString(a));
                    a++;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            textBox1.Clear();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Districtname \n" +
                "FROM GeneralData.dbo.tblProvince as a \n" +
                "LEFT JOIN GeneralData.dbo.tblDistrict AS B ON A.provinceid = B.provinceid \n" +
                "WHERE provincename = '" + comboBox1.SelectedItem + "'");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox2.Items.Add(dt.Rows[a][0]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            textBox1.Clear();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Subdistrictname \n" +
            "FROM GeneralData.dbo.tblProvince as a \n" +
            "LEFT JOIN GeneralData.dbo.tblDistrict AS B ON A.provinceid = B.provinceid \n" +
            "LEFT JOIN GeneralData.dbo.tblSubdistrict as c on B.Districtid = c.Districtid \n" +
            "WHERE Districtname = '" + comboBox2.SelectedItem + "'");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox3.Items.Add(dt.Rows[a][0]);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT PostCode \n" +
                "FROM GeneralData.dbo.tblSubdistrict as a \n" +
                "LEFT JOIN GeneralData.dbo.tblDistrict as b on b.DistrictID = a.Districtid \n" +
                "WHERE Subdistrictname = '" + comboBox3.SelectedItem + "'");
            textBox1.Text = Convert.ToString(dt.Rows[0][0]);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT zoneid FROM GeneralData.dbo.tblzone WHERE zonename = '" + comboBox4.SelectedItem + "'");
            ShopApp.SQL.InputSQLMSSQL("INSERT INTO GeneralData.dbo.tblProvince(provincename, provincenameeng, zoneid) \n" +
            "VALUES ('" + textBox2.Text + "','" + textBox5.Text + "','" + dt.Rows[0][0] + "');");
            MessageFinadd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT provinceid FROM GeneralData.dbo.tblprovince WHERE provincename = '" + comboBox5.SelectedItem + "'");
            ShopApp.SQL.InputSQLMSSQL("INSERT INTO GeneralData.dbo.tblDistrict(Districtname, Districtnameeng, Provinceid) \n" +
            "VALUES ('" + textBox4.Text + "','" + textBox3.Text + "','" + dt.Rows[0][0] + "');");
            MessageFinadd();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            textBox1.Text = "";
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Provincename \n" +
            "FROM GeneralData.dbo.tblzone as a \n" +
            "LEFT JOIN GeneralData.dbo.tblProvince AS B ON A.zoneid = B.zoneid \n" +
            "WHERE zonename = '" + comboBox6.SelectedItem + "'");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox1.Items.Add(dt.Rows[a][0]);
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            DataTable dt1 = ShopApp.SQL.InputSQLMSSQL("SELECT provincename , provinceid \n" +
            "FROM GeneralData.dbo.tblzone as a \n" +
            "LEFT JOIN GeneralData.dbo.tblProvince as b on a.zoneid = b.zoneid \n" +
            "WHERE zonename = '" + comboBox8.SelectedItem + "'");
            for (int a = 0; a < dt1.Rows.Count; a++)
            {
                comboBox5.Items.Add(dt1.Rows[a][0]);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Districtname \n" +
              "FROM GeneralData.dbo.tblProvince as a \n" +
              "LEFT JOIN GeneralData.dbo.tblDistrict AS B ON A.provinceid = B.provinceid \n" +
              "WHERE provincename = '" + comboBox9.SelectedItem + "'");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox7.Items.Add(dt.Rows[a][0]);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.Items.Clear();
            DataTable dt1 = ShopApp.SQL.InputSQLMSSQL("SELECT provincename , provinceid \n" +
            "FROM GeneralData.dbo.tblzone as a \n" +
            "LEFT JOIN GeneralData.dbo.tblProvince as b on a.zoneid = b.zoneid \n" +
            "WHERE zonename = '" + comboBox10.SelectedItem + "'");
            for (int a = 0; a < dt1.Rows.Count; a++)
            {
                comboBox9.Items.Add(dt1.Rows[a][0]);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT Districtid FROM GeneralData.dbo.tblDistrict WHERE Districtname = '" + comboBox7.SelectedItem + "'");
            ShopApp.SQL.InputSQLMSSQL("Insert INTO GeneralData.dbo.tblSubdistrict(Subdistrictname ,  Subdistrictnameeng , PostCode , Districtid)" +
                "VALUES('" + textBox7.Text + "', '" + textBox6.Text + "', '" + textBox8.Text + "', '" + dt.Rows[0][0] + "')");
            MessageFinadd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (radioButton3.Checked == true)
                {
                    if ((comboBox3.Text == "") && (textBox1.Text == ""))
                    {
                        MessageBox.Show("อย่าเว้นช่องว่างสำหรับใส่ตำบลนะครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataTable re = ShopApp.SQL.InputSQLMSSQL("SELECT c.Subdistrictid \n" +
                            "FROM GeneralData.dbo.tblProvince as a \n" +
                            "LEFT JOIN GeneralData.dbo.tblDistrict as b on a.provinceid = b.Provinceid \n" +
                            "LEFT JOIN GeneralData.dbo.tblSubdistrict as c on b.DistrictID = c.Districtid \n" +
                            "WHERE provincename='"+ comboBox1.SelectedItem + "' and Districtname='"+ comboBox2.SelectedItem+"' and Subdistrictname = '"+comboBox3.SelectedItem+"'");
                        ShopApp.SQL.InputSQLMSSQL("DELETE FROM GeneralData.dbo.tblSubdistrict WHERE Subdistrictid = " + re.Rows[0][0]);
                        MessageFindelete();
                        Clear();
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if ((comboBox2.Text == ""))
                    {
                        MessageBox.Show("อย่าเว้นช่องว่างสำหรับใส่อำเภอนะครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataTable check = ShopApp.SQL.InputSQLMSSQL("SELECT b.districtid " +
                            "FROM GeneralData.dbo.tblProvince as a " +
                            "LEFT JOIN GeneralData.dbo.tblDistrict as b on a.provinceid = b.Provinceid " +
                            "WHERE provincename = '" + comboBox1.SelectedItem + "' and " +
                            "Districtname = '" + comboBox2.SelectedItem + "'");
                        DataTable ch = ShopApp.SQL.InputSQLMSSQL("SELECT Count(Subdistrictid) \r\n" +
                          "FROM GeneralData.dbo.tblSubdistrict as  a  \r\n" +
                          "LEFT JOIN GeneralData.dbo.tblDistrict as b on a.Districtid = b.Districtid  \r\n" +
                          "WHERE Districtname= '"+comboBox2.SelectedItem+"'; \r\n\r\n");
                        if (Convert.ToInt32(ch.Rows[0][0]) > 0)
                        {
                            MessageBox.Show("กรุณาเช็คด้วยนะครับถ้าตำบลนั้นยังไม่ถูกลบแปลว่าในตำบลนั้นยังมีอำเภอที่ยังไม่ลบอยู่นะครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ShopApp.SQL.InputSQLMSSQL("DELETE FROM GeneralData.dbo.tblDistrict " +
                                "WHERE Districtid = " + check.Rows[0][0]);
                            MessageFindelete();
                        }
                    }
                }

                else
                {
                    if ((comboBox1.Text == ""))
                    {
                        MessageBox.Show("อย่าเว้นช่องว่างสำหรับใส่จังหวัดนะครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataTable checkProvince = ShopApp.SQL.InputSQLMSSQL("SELECT districtid , b.provinceid \r\n" +
                            "FROM GeneralData.dbo.tblDistrict as  a   \r\n" +
                            "LEFT JOIN GeneralData.dbo.tblProvince as b on a.provinceid = b.provinceid   \r\n" +
                            "WHERE provincename= '"+comboBox1.SelectedItem+"'; \r\n\r\n");
                        if(checkProvince.Rows.Count > 0)
                        {
                            MessageBox.Show("กรุณาเช็คด้วยนะครับถ้าตำบลนั้นยังไม่ถูกลบแปลว่าในตำบลนั้นยังมีอำเภอที่ยังไม่ลบอยู่นะครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ShopApp.SQL.InputSQLMSSQL("DELETE FROM GeneralData.dbo.tblProvince \r\n" +
                              "WHERE provinceid = (SELECT provinceid \r\n"+
                            "FROM GeneralData.dbo.tblprovince \r\n" +
                           "WHERE provincename = '"+comboBox1.SelectedItem+"')");
                            MessageFindelete();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณากดที่ Confirm Delete ด้วยครับ.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dr = MessageBox.Show("อ่านหมายเหตุแล้วใช่ไหม.", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            else
            {
            }
        }
        public void Clear()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            DataTable dt = ShopApp.SQL.InputSQLMSSQL("SELECT zonename \n" +
            "FROM GeneralData.dbo.tblzone");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                comboBox4.Items.Add(dt.Rows[a][0]);
                comboBox6.Items.Add(dt.Rows[a][0]);
                comboBox8.Items.Add(dt.Rows[a][0]);
                comboBox10.Items.Add(dt.Rows[a][0]);
            }


        }
        public void MessageFinadd()
        {
            MessageBox.Show("เพิ่มเสร็จเรียบร้อยแล้วครับ , Add Completed.");
            Clear();
        }
        public void MessageFindelete()
        {
            MessageBox.Show("ลบเสร็จเรียบร้อยแล้วครัล , Delete Completed.");
            Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
