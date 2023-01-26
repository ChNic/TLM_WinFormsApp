using MySql.Data.MySqlClient;
using System;
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
    public partial class TLMBackupForm : Form
    {
        public TLMBackupForm()
        {
            InitializeComponent();
            String  Text = ", Loaded MySqlBackup.DLL Version: " + MySql.Data.MySqlClient.MySqlBackup.Version;
        }

        private void TLMBackup_Load(System.Object  sender, System.EventArgs  e)
        {

            // TLMBackupForm.ConnectionString = TLM_Utils.getConnSettings();
            TLMBackupForm.ConnectionString = TLMUtils.GetConnectionString();
            this.txtBox_ConnectionString.Text = TLMBackupForm.ConnectionString;
            this.txtFileName.Text = this.saveFileDialog.InitialDirectory;
        }

        private void txtFileName_TextChanged(System.Object  sender, System.EventArgs  e)
        {
            TLMBackupForm.TargetFile = this.txtFileName.Text;
        }

        private void btnExportAs_Click(System.Object  sender, System.EventArgs  e)
        {

            SaveFileDialog   sfd =  new SaveFileDialog();
            if (TLMBackupForm.DefaultFolder != "")
                sfd.InitialDirectory = TLMBackupForm.DefaultFolder;
            sfd.Filter = "*.sql|*.sql|*.*|*.*";
            DateTime   dtn = System.DateTime.Now;
            String   DateTimeNow = dtn.ToString("yyyy-MM-dd HHmmss");
            sfd.FileName = "TowLotMgmt Dump " + DateTimeNow + ".sql";
            if (System.Windows.Forms.DialogResult.OK == sfd.ShowDialog())
            {
                this.txtFileName.Text = sfd.FileName;
                TLMBackupForm.DefaultFolder = System.IO.Path.GetDirectoryName(this.txtFileName.Text);
            }
        }

        private void btnBackup_Click(System.Object  sender, System.EventArgs  e)
        {

            if (!TLM_Utils.TargetDirectoryIsValid(TargetFile))
            {
                return;
            }

            MySqlConnection conn =  new MySqlConnection(TLMBackupForm.ConnectionString);

            MySqlCommand  cmd =  new MySqlCommand();

            MySqlBackup   mb =  new MySqlBackup(cmd);
            try
            {
                cmd.Connection = conn;
                conn.Open();

                mb.ExportInfo.AddCreateDatabase = true;
                mb.ExportInfo.ExportTableStructure = true;
                mb.ExportInfo.ExportRows = true;
                mb.ExportInfo.RecordDumpTime = true;
                mb.ExportInfo.ResetAutoIncrement = false;
                mb.ExportInfo.ExportFunctions = true;
                mb.ExportInfo.ExportProcedures = true;
                mb.ExportInfo.ExportTriggers = true;
                mb.ExportInfo.ExportEvents = true;
                mb.ExportInfo.ExportViews = true;
                mb.ExportInfo.InsertLineBreakBetweenInserts = true;

                mb.ExportToFile(TargetFile);    //This line will export the file to given path.
                conn.Close();
                MessageBox.Show("Data Backup Completed...!!!");
                Close();
            }
            catch (Exception ex)
	{
                MessageBox.Show(ex.Message);
            }
            }
        }
}
