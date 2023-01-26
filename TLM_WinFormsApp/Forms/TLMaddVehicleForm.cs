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
using VinValidLibraryNS;

namespace TLM_WinFormsApp
{
    public partial class TLMaddVehicleForm : Form
    {
        public TLMaddVehicleForm()
        {
            InitializeComponent();
            LoadComboBoxLot();
            LoadComboBoxReason();

        }

        private void AddVehicleForm_Load(Object sender, EventArgs e)
        {
            String  query = ("SELECT * FROM towlot.tlm_owner;");
            TLM_Utils.load_Table(query, dataGridView1_Owner);
            // loadDataGridView(query, dataGridView1_Owner);
        }

        private void Txt_VIN_Box_TextChanged(System.Object sender, System.EventArgs e)
        {
        }

        private void Txt_VIN_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.txt_VIN.Text = this.txt_VIN.Text.ToUpper();   // Make sure VIN is in uppercase.
            this.txt_VIN.Text = VinValidate.ChkVin(this.txt_VIN.Text);       // Check for illegal chacaters.
            if (!VinValidate.ValidateVIN(txt_VIN.Text).valid)
            {                       // Make sure it is a good VIN.
                //e.Cancel ;
            }
        }

        private void Enter_Btn_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }

        private void Save_btn_Click(System.Object sender, System.EventArgs e)
        {
            // Save Data
            //
            int Title = Int32.Parse(this.txt_Title.Text);
            // int LotID = Int32.Parse(this.txt_Lot.Text);

            String  query = ("INSERT INTO towlot.tlm_Vehicle (VIN, Make, Model, Year, Color, OnLot, lot_id, Reason, Title) VALUES('" + this.txt_VIN.Text + "', '" + this.Txt_Make.Text + "', '" + this.txt_Model.Text + "', '" + this.Txt_Year.Text + "', '" + this.txt_Color.Text + "', '" + this.txt_OnLot.Text + "', '" + this.txt_Lot_id.Text + "', '" + this.txt_Reason.Text + "', '" + Title + "');");
            TLM_Utils.save_Data(query);
        }

        private void UpdateTitle_lbl(System.Object sender, System.EventArgs e)
        {

            if (Title_chkBox.Checked)
            {
                txt_Title.Text = "1";
                // title = "1";
            }
            else
            {
                txt_Title.Text = "0";
                // title = "0";
            }
        }

        private void ComboBox_Lot_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            String  comboval = comboBox_Lot.Text;
            // int combovalue = Convert.ToInt32(comboval);
            String  query = ("select * from towlot.tlm_lot where lot = '" + comboval + "';");

            // String constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
            String  constr = TLMUtils.GetConnectionString();
            MySqlConnection  conDataBase = new MySqlConnection(constr);
            MySqlCommand  cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader  myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (myReader.Read())
                {
                    txt_Lot_id.Text = myReader.GetInt32("lot_id").ToString();
                    txt_Lot.Text = myReader.GetString("lot");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

    finally
            {
                if (conDataBase != null)
                {
                    conDataBase.Close();
                }
            }

        }

        private void ComboBox_Reason_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            String  comboval = comboBox_Reason.Text;

            String  query = ("select * from towlot.tlm_reason where reason = '" + comboval + "';");

            String constr = TLMUtils.GetConnectionString();
            MySqlConnection  conDataBase = new MySqlConnection(constr);
            MySqlCommand  cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader  myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (myReader.Read())
                {
                    String  vReason;
                    vReason = myReader.GetString("reason");
                    txt_Reason.Text = vReason;
                }
            }
            catch (Exception ex) {
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

        private void LoadComboBoxLot()
        {
            String  query = ("select * from towlot.tlm_lot;");
            // load_Data(query, "Lot");
            String  constr = TLMUtils.GetConnectionString();
            MySqlConnection  conDataBase = new MySqlConnection(constr);
            MySqlCommand  cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader  myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    String  vLot;
                    vLot = myReader.GetString("lot");
                    comboBox_Lot.Items.Add(vLot);
                }
            }
            catch (Exception ex) {
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

        private void LoadComboBoxReason()
        {
            String  query = ("select * from towlot.tlm_reason;");

            // load_Data(query, "Reason");
            // String constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
            String  constr = TLMUtils.GetConnectionString();
            MySqlConnection  conDataBase = new MySqlConnection(constr);
            MySqlCommand  cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader  myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    String  vReason;
                    vReason = myReader.GetString("reason");
                    comboBox_Reason.Items.Add(vReason);
                }
            }
            catch (Exception ex) {
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
