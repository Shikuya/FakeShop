﻿using System;
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
    public partial class addCategorie : Form
    {
        public addCategorie()
        {
            InitializeComponent();
        }

        private void B_categorie_add_Click(object sender, EventArgs e)
        {
            if (TB_categorie_descliption.Text == "" || TB_categorie_name.Text == "")
            {
                MessageBox.Show("กรอกข้อมูลให้ครบจ้า");
            }
            else
            {
            ShopApp.SQL.InputSQLMSSQL("INSERT INTO Shop.dbo.tblCategories(Categoriename , ShortDesciption) \r\n" +
            "VALUES('"+TB_categorie_name.Text+"', '"+TB_categorie_descliption.Text+"'); ");
                MessageBox.Show("เพิ่ม Categorie นี้เรียบร้อยแล้วครับ.");
                TB_categorie_descliption.Text = "";
                TB_categorie_name.Text = "";
            }

        }

        private void addCategorie_SizeChanged(object sender, EventArgs e)
        {
            ShopApp.Class.Formulatwo.CenterSize(this, panel1);
        }

        private void addCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
