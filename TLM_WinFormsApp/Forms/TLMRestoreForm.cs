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
    public partial class TLMRestoreForm : Form
    {
        public TLMRestoreForm()
        {
            InitializeComponent();
            String Text = ", Loaded MySqlBackup.DLL Version: " + MySql.Data.MySqlClient.MySqlBackup.Version;
        }

        private void TLMRestoreForm_Load(System.Object sender, System.EventArgs e)
        {
            ConnectionString = TLMUtils.GetConnectionString();
            this.txtBox_ConnectionString.Text = ConnectionString;
        }

        private void txtFileName_TextChanged(System.Object sender, System.EventArgs e)
        {
            TargetFile = this.txtFileName.Text;
        }

        private void btnImportFileName_Click(System.Object sender, System.EventArgs e)
        {

            OpenFileDialog  f = new OpenFileDialog();
            if (DefaultFolder != "")
                f.InitialDirectory = DefaultFolder;
            if (System.Windows.Forms.DialogResult.OK == f.ShowDialog())
            {
                this.txtFileName.Text = f.FileName;
                DefaultFolder = System.IO.Path.GetDirectoryName(this.txtFileName.Text);
            }
        }

        private void btnStartImport_Click(System.Object sender, System.EventArgs e)
        {
            if (!TLM_Utils.SourceFileExists(TargetFile))
                return;

            try
            {
                MySqlConnection  conn = new MySqlConnection(ConnectionString);
                MySqlCommand  cmd = new MySqlCommand();
                MySqlBackup  mb = new MySqlBackup(cmd);
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ImportFromFile(TargetFile);   //This line will import the file from given path.
                    conn.Close();
                }
                MessageBox.Show("Data Restore Completed...!!!");
                Close();
            }
            catch (Exception ex)
        	{
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
