using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Shop
{
    public partial class SelectProduct : Form
    {/// <summary>
	 /// SQLDafault
	 /// <para[0] Select Product INPUT: {Code} {Product} {Brand} {Categorie}></para>
	 /// </summary>
		private String[] SQLDefault = new String[]
		{
			//[0] Select Product INPUT: {Code} {Product} {Brand} {Categorie}
			"SELECT TOP(50) CodeProduct , Productname , Brandname , Categoriename , PriceSell , Quantity \r\n"+
			"FROM Shop.dbo.tblProducts as a \r\n"+
			"LEFT JOIN Shop.dbo.tblBrand as b on a.BrandID = b.BrandID \r\n"+
			"LEFT JOIN Shop.dbo.tblCategories as c on a.CategorieID = c.CategorieID \r\n"+
			"LEFT JOIN Shop.dbo.tblPrice as d on a.PriceID = d.PriceID \r\n"+
			"LEFT JOIN Shop.dbo.tblStock as e on a.ProductID = e.ProductID \r\n"+
			"WHERE CodeProduct LIKE '{Code}%' or Productname LIKE '{Product}%' or Brandname LIKE '{Brand}%' or Categoriename LIKE '{Categorie}%'; \r\n\r\n",
		};
		public static String ReturnID = "";
		public static Form FormNew;
		public SelectProduct()
        {
            InitializeComponent();
			listproduct();
        }

        private void TB_Select_TextChanged(object sender, EventArgs e)
        {
			listproduct();
		}
		private void listproduct()
        {
			DGVInformation.Rows.Clear();
			DataTable dt = ShopApp.SQL.InputSQLMSSQL(SQLDefault[0]
			.Replace("{Code}", TB_Select.Text)
			.Replace("{Product}", TB_Select.Text)
			.Replace("{Brand}", TB_Select.Text)
			.Replace("{Categorie}", TB_Select.Text));
			for (int a = 0; a < dt.Rows.Count; a++)
			{
				DGVInformation.Rows.Add(dt.Rows[a][0], dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][3], dt.Rows[a][4], dt.Rows[a][5]);
			}
		}
        private void SelectProduct_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
		public static String Showed()
		{
			ReturnID = "";
			FormNew = new SelectProduct();
			FormNew.ShowDialog();
			return ReturnID;
		}

        private void DGVInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			int rowIndex = e.RowIndex;
			DataGridViewRow row = DGVInformation.Rows[rowIndex];
			ReturnID = row.Cells[0].Value.ToString();
			this.Hide();
		}

        private void DGVInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
