using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class SQL
    {
        private static System.Data.OleDb.OleDbConnection conMSSQL = new System.Data.OleDb.OleDbConnection("Provider=SQLOLEDB;Data Source=166.166.1.24;Initial Catalog=Account;User ID=Shikuya;Password=asd0947937279Shikuya!;");

        public static void LoadComboBoxInformation(String SQLCode, ComboBox cb)
        {
            DataTable dt = SQL.InputSQLMSSQL(SQLCode);
            for (int a = 0; a < dt.Rows.Count; a++)
                cb.Items.Add(new Class.ComboBoxItem(dt.Rows[a][0].ToString(),
                    dt.Rows[a][1].ToString()));
        }
        public static void LoadComboBoxInformation(String SQLCode, ComboBox[] cb)
        {
            DataTable dt = SQL.InputSQLMSSQL(SQLCode);
            for (int a = 0; a < dt.Rows.Count; a++)
                for(int x = 0; x < cb.Length;x++)
                    cb[x].Items.Add(new Class.ComboBoxItem(dt.Rows[a][0].ToString(),
                        dt.Rows[a][1].ToString()));
        }

        public static DataTable InputSQLMSSQL(string  SQLCode)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conMSSQL.State == ConnectionState.Closed)
                    conMSSQL.Open();
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(SQLCode, conMSSQL);
                conMSSQL.Close();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public static DataSet InputSQLMSSQLDS(string SQLCode)
        {
            DataSet ds = new DataSet();
            try
            {
                if (conMSSQL.State == ConnectionState.Closed)
                    conMSSQL.Open();
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(SQLCode, conMSSQL);
                conMSSQL.Close();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds;
        }
    }
}
