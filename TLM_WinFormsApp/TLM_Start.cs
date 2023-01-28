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
using System.Windows.Forms;
using TLMUtilsLibraryNS;
using TLMWinFormsLibrary;
using UtilitiesLibrary;

namespace TLM_WinFormsApp
{
    public partial class TLM_Start : Form
    {
        private MySqlConnection conDataBase;

        public TLM_Start()
        {
            InitializeComponent();
            conDataBase = TLM_Startup();
            if (conDataBase.Database != "towlot")
                LoadFromSQL();
            else
            {
                // MessageBox.Show("DataBase found.");
                
            }
            this.Close();
            Application.Run(new TLM_MainForm());
        }

        public MySqlConnection TLM_Startup()
        {
            // TODO Check for DB
            // if not found restore form TowLot.sql

            String query = ("select * from towlot.tlm_lot");
            String constr = TLMUtils.GetConnectionString();
 
            try
            {
                MySqlConnection conDataBase = new MySqlConnection(constr);
                return conDataBase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message DBConnection");
            }
            return null;

        }

        public void LoadFromSQL()
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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
