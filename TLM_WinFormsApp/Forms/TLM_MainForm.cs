using System.Windows.Forms;
using TLMUtilsLibraryNS;
using TLMWinFormsLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TLM_WinFormsApp
{
    public partial class TLM_MainForm  : Form
    {
        public TLM_MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            TLMStartup startup = new TLMStartup();
            MainFormLoad();

        }

        private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
        { 
            Close();
        }

        private void VehicleToolStripMenuItem_Click_1(Object sender, EventArgs e) 
        {
            // Add Vehicle
            TLMaddVehicleForm frm1 = new TLMaddVehicleForm();
            frm1.ShowDialog();

        }

        private void ownerToolStripMenuItem_Click_1(Object sender, EventArgs e) 
        {
            // Add Owner
            TLMOnerForm  frm2 = new TLMOnerForm();
            frm2.ShowDialog();

        }

        private void carToolStripMenuItem1_Click(Object sender, EventArgs e) 
        {
            // Edit Car
            TLMEditVehicleForm  frm6 = new TLMEditVehicleForm();
            frm6.ShowDialog();

        }

        private void ownerToolStripMenuItem1_Click(Object sender, EventArgs e)
        {
            //Edit Owner
            TLMOnerForm  frm2 = new TLMOnerForm();
            frm2.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {

            TLMEditVehicleForm  frm6 = new TLMEditVehicleForm();

            frm6.txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm6.txt_VIN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm6.Txt_Make.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm6.txt_Model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm6.Txt_Year.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm6.txt_Color.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm6.txt_OnLot.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm6.txt_Lot_id.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm6.txt_Lot.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm6.txt_Reason.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm6.Title_chkBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "1")
            {
                frm6.Title_chkBox.Checked = true;
                frm6.txt_Title.Text = "1";
            }
            else
            {
                frm6.Title_chkBox.Checked = false;
                frm6.txt_Title.Text = "0";
            }
            frm6.mTxtB_Released.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm6.txtB_HowReleased.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frm6.txt_OwnerFirstName.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frm6.txt_OwnerLastName.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frm6.txt_O_id.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frm6.txtBx_AmountDue.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();

            frm6.ShowDialog();

        }

        private void refreshTableToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            String  query = ("SELECT id,VIN, Make, Model, Year, Color, OnLot, c.lot_id, lot, Reason, Title, Released, How_released, First_name, Last_name, o.O_id, AmountDue FROM towlot.tlm_vehicle AS c LEFT JOIN towlot.tlm_owner AS o ON c.Owner_id = o.O_id LEFT JOIN towlot.tlm_lot AS l ON c.lot_id = l.lot_id  ORDER BY c.id ASC;");
            TLM_Utils.load_Table(query, dataGridView1);
            //dataGridView1.DataSource = load_Table(query);

        }
        private void updateAmtDueToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            TLM_Utils.CalculateAmountDue();
            String query = ("SELECT id,VIN, Make, Model, Year, Color, OnLot, c.lot_id, lot, Reason, Title, Released, How_released, First_name, Last_name, o.O_id, AmountDue FROM towlot.tlm_vehicle AS c LEFT JOIN towlot.tlm_owner AS o ON c.Owner_id = o.O_id LEFT JOIN towlot.tlm_lot AS l ON c.lot_id = l.lot_id  ORDER BY c.id ASC;");
            TLM_Utils.load_Table(query, dataGridView1);
            //dataGridView1.DataSource = load_Table(query);

        }
        private void helpToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            //TLMAboutForm frm8 = new TLMAboutForm();
            //TLMHelpForm frm9 = new TLMHelpForm();
            /*String message = " Help is not yet implemented ";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show((" Help is not yet implemented "), "", button, icon );
            */
            //frm9.ShowDialog();
            // TODO -- Need to add help.

        }
        private void aboutToolStripMenuItem_Click_1(Object sender, EventArgs e)
        {
            TLMAboutFrom frm8 = new TLMAboutFrom();
            frm8.ShowDialog();

        }
        private void backupToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            TLMBackupForm frm9 = new TLMBackupForm();
            frm9.ShowDialog();

        }
        private void exitToolStripMenuItem1_Click(Object sender, EventArgs e)
        {
            Close();

        }
        private void restoreDataToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            TLMRestoreForm  frm10 = new TLMRestoreForm();
            frm10.ShowDialog();

        }
        private void deleteToolStripMenuItem_Click(Object sender, EventArgs e) 
        {
            String  message = " Delete is not yet implemented ";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, "Delete", button, icon);

        }
        private void MainFormLoad()
        {

            // Load main Window
            String query = ("SELECT id, VIN, Make, Model, Year, Color, OnLot, c.lot_id, lot, Reason, Title, Released, How_released, First_name, Last_name, o.O_id, AmountDue FROM towlot.tlm_vehicle AS c LEFT JOIN towlot.tlm_owner AS o ON c.Owner_id = o.O_id LEFT JOIN towlot.tlm_lot AS l ON c.lot_id = l.lot_id ORDER BY c.id ASC ;");
            TLM_Utils.load_Table(query, dataGridView1);
        }

        private void lotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add Lots
            TLMAddLotForm frm3 = new TLMAddLotForm();
            frm3.ShowDialog();

        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add and Modify Rate
            TLMAddRateForm frm4 = new TLMAddRateForm();
            frm4.ShowDialog();

        }

        private void reasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add Reasons
            TLMAddReasonForm frm5 = new TLMAddReasonForm();
            frm5.ShowDialog();

        }
    }
}