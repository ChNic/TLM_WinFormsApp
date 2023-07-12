using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TLMUtilsLibraryNS;
using TLMWinFormsLibrary;


namespace TLM_WinFormsApp
{
    internal class TLMStartup
    {
        public TLMStartup()
        {
            TLMStart();
        }

        public void TLMStart()
        {
            string conn = TLMUtils.GetConString();
            string dbName = "towlot";
            //if (conDataBase. != "towlot")
            if (!DBExists( conn,  dbName))
            {
                LoadFromSQL();
            }
            else
            {
                MessageBox.Show("DataBase found.");
                
            }
            // Application.Run(new TLM_MainForm());
            // Close();
        }

        public static bool DBExists(string conn, string dbName)
        {
            bool functionReturnValue = false;

            MySqlConnection dbconn = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.schemata WHERE SCHEMA_NAME=@dbName", dbconn);
            {
                functionReturnValue = false;
                cmd.Parameters.AddWithValue("@dbName", dbName);
                dbconn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    functionReturnValue = true;
                }
                dbconn.Close();
            }

            return functionReturnValue;
        }

        public static void LoadFromSQL()
        {
            String TargetFile = "TowLot.sql";
            string ConnectionString = TLMUtils.GetConString();

            if (!TLM_Utils.SourceFileExists(TargetFile))
                return;

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup mb = new MySqlBackup(cmd);
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ImportFromFile(TargetFile);   //This line will import the file from given path.
                    conn.Close();
                }
                // MessageBox.Show("Data Restore Completed...!!!");
                // Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
