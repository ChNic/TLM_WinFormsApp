using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLMUtilsLibraryNS;
using TLMWinFormsLibrary;

namespace TLM_WinFormsApp
{
    public partial class TLMAddLotForm : Form
    {
        public TLMAddLotForm()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }

        private void Save_btn_Click(System.Object sender, System.EventArgs e)
        {

            String query = ("INSERT INTO towlot.tlm_lot ( lot ) VALUES('" + this.Lot_txt.Text + "');");

            if (this.Lot_txt.Text.Length > 0)
            {

                TLM_Utils.save_Data(query);
                MessageBox.Show("Data Saved!");
            }
            else
            {
                MessageBox.Show("No Lot entered");

            }
        }

        private void TLMAddLotForm_Load(System.Object sender, System.EventArgs e)
        {
            String query = ("select * from towlot.tlm_lot;");
            // load_Data(query, "Lot");
            // String constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
            String constr = TLMUtils.GetConnectionString();
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    String vLot = myReader.GetString("lot");
                    listBox_Lot.Items.Add(vLot);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conDataBase != null)
                {
                    conDataBase.Close();
                }
            }

        }
    }
}
