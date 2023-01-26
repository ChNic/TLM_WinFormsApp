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
    public partial class TLMEditVehicleForm : Form
    {
        public TLMEditVehicleForm()
        {
            InitializeComponent();
            LoadComboBoxLot();
            LoadComboBoxReason();

        }

        private void EditCarForm_Load(Object sender, EventArgs e)
        {
            String query = ("SELECT * FROM towlot.tlm_owner;");
            //loadDataGridView(query);
            TLM_Utils.load_Table(query, dataGridView1_Own);
            //dataGridView1_Own.DataSource = load_Table(query);
        }

        private void txt_VIN_Box_TextChanged(Object sender, EventArgs e)
        {
        }

        private void txt_VIN_Validating(Object sender, CancelEventArgs e)
        {
            this.txt_VIN.Text = this.txt_VIN.Text.ToUpper();   // Make sure VIN is in uppercase.
            this.txt_VIN.Text = VinValidate.ChkVin(this.txt_VIN.Text);       // Check for illegal chacaters.
            if (!VinValidate.ValidateVIN(txt_VIN.Text).valid)
            {                       // Make sure it is a good VIN.
                e.Cancel = true;
            }
        }

        private void Enter_Btn_Click(Object sender, EventArgs e)
        {
            Close();
        }

        private void Save_btn_Click(Object sender, EventArgs e)
        {
            // Save Data
            //
            int Title = Int32.Parse(this.txt_Title.Text);
            // converting OnLot DateTime to proper format for MySql DB
            DateTime date2 = DateTime.Parse(this.txt_OnLot.Text);
            DateTime date1 = Convert.ToDateTime(date2);
            String OnLot = date1.ToString("s");
            // checking Released DateTime and converting to proper format for MySql DB.
            String Released = TLMUtils.GetStringDate(this.mTxtB_Released.Text);
            if (String.IsNullOrEmpty(Released))
            {
                //MessageBox.Show("Released= " + Released + ":");
                String query = ("UPDATE towlot.tlm_vehicle Set VIN='" + this.txt_VIN.Text + "', Make='" + this.Txt_Make.Text + "', Model='" + this.txt_Model.Text + "', Year='" + this.Txt_Year.Text + "', Color='" + this.txt_Color.Text + "', OnLot='" + OnLot + "', lot_id='" + txt_Lot_id.Text + "', Reason='" + this.txt_Reason.Text + "', Title='" + Title + "',  Owner_id='" + this.txt_O_id.Text + "' WHERE id='" + this.txt_ID.Text + "' ;");
                TLM_Utils.save_Data(query);
                MessageBox.Show("Data Saved!");

            }
            else
            {
                String query = ("UPDATE towlot.tlm_vehicle Set VIN='" + this.txt_VIN.Text + "', Make='" + this.Txt_Make.Text + "', Model='" + this.txt_Model.Text + "', Year='" + this.Txt_Year.Text + "', Color='" + this.txt_Color.Text + "', OnLot='" + OnLot + "', lot_id='" + txt_Lot_id.Text + "', Reason='" + this.txt_Reason.Text + "', Title='" + Title + "', Released='" + Released + "', How_released='" + txtB_HowReleased.Text + "', Owner_id='" + this.txt_O_id.Text + "' WHERE id='" + this.txt_ID.Text + "' ;");
                TLM_Utils.save_Data(query);
                MessageBox.Show("Data Saved!");
            }
            // UpDate Database!!
        }

        private void UpdateTitle_lbl(Object sender, EventArgs e)
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

        private void comboBox_Lot_SelectedIndexChanged(Object sender, EventArgs e)
        {
            String comboval = comboBox_Lot.Text;

            String query = ("select * from towlot.tlm_lot where lot = '" + comboval + "';");

            // String constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
            String constr = TLMUtils.GetConnectionString();
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (myReader.Read())
                {
                    txt_Lot_id.Text = myReader.GetInt32("lot_id").ToString();
                    txt_Lot.Text = myReader.GetInt32("lot").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_Reason_SelectedIndexChanged(Object sender, EventArgs e)
        {

            String comboval = comboBox_Reason.Text;
            String query = ("select * from towlot.tlm_reason where reason = '" + comboval + "';");
            // String constr = L"datasource=localhost; port=3306; username=root; password=Pa55w0rd#8; database=towlot";
            String constr = TLMUtils.GetConnectionString();
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (myReader.Read())
                {
                    String vReason;
                    vReason = myReader.GetString("reason");
                    txt_Reason.Text = vReason;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Own_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            // int Row = e.RowIndex;
            this.txt_O_id.Text = dataGridView1_Own.CurrentRow.Cells[0].Value.ToString();
            this.txt_OwnerLastName.Text = dataGridView1_Own.CurrentRow.Cells[1].Value.ToString();
            this.txt_OwnerFirstName.Text = dataGridView1_Own.CurrentRow.Cells[2].Value.ToString();
        }

        private void Release_btn_Click(System.Object sender, System.EventArgs e)
        {

            TLMReleaseForm frm7 = new TLMReleaseForm();

            //// frm7.txtBx_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //frm7.txtBx_VIN.Text = this.txt_VIN.Text;
            //frm7.txtBx_Make.Text = this.Txt_Make.Text;
            //frm7.txtBx_Model.Text = this.txt_Model.Text;
            //frm7.txtBx_Year.Text = this.Txt_Year.Text;
            //frm7.txtBx_Color.Text = this.txt_Color.Text;
            //frm7.txtBx_OnLot.Text = this.txt_OnLot.Text;
            ////frm7.txtBx_Lot_id.Text = this.txt_Lot_id.Text;
            ////frm7.txtbx_Lot.Text = this.txt_Lot.Text;
            //frm7.txtBx_Reason.Text = this.txt_Reason.Text;
            //frm7.chkBx_Title.Text = this.Title_chkBox.Text;
            //if (this.Title_chkBox.Text)
            //{
            //    frm7.chkBx_Title.Checked = true;
            //}
            //else
            //{
            //    frm7.chkBx_Title.Checked = false;
            //}
            //frm7.txtBx_Released.Text = this.mTxtB_Released.Text;
            //frm7.txtBx_HowReleased.Text = this.txtB_HowReleased.Text;
            //frm7.txtBx_FirstName.Text = this.txt_OwnerFirstName.Text;
            //frm7.txtBx_LastName.Text = this.txt_OwnerLastName.Text;
            //frm7.txtBx_AmountDue.Text = this.txtBx_AmountDue.Text;
            ////
            frm7.ShowDialog();
        }

        private void LoadComboBoxLot()
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
                    comboBox_Lot.Items.Add(vLot);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadComboBoxReason()
        {
            String query = ("select * from towlot.tlm_reason;");

            // load_Data(query, "Reason");
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
                    String vReason;
                    vReason = myReader.GetString("reason");
                    comboBox_Reason.Items.Add(vReason);
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
