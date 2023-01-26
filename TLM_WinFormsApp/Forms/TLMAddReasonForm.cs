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
    public partial class TLMAddReasonForm : Form
    {
        public TLMAddReasonForm()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }

        private void Save_btn_Click(System.Object sender, System.EventArgs e)
        {

            String query = ("INSERT INTO towlot.tlm_reason ( reason ) VALUES('" + this.txt_Reason.Text + "');");

            if (this.txt_Reason.Text.Length > 0)
            {
                // MessageBox.Show("Reason is not empty");
                TLM_Utils.save_Data(query);
            }
            else
            {
                MessageBox.Show("No Reason entered");
            }
        }

        private void TLMAddReasonForm_Load(System.Object sender, System.EventArgs e)
        {
            String query = ("select * from towlot.tlm_reason;");

            // load_Data(query, "Reason");
            // String  constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
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
                    String vReason;
                    vReason = myReader.GetString("reason");
                    listBox_Reason.Items.Add(vReason);
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
