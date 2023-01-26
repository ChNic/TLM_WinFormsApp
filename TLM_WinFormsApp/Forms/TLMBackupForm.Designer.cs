namespace TLM_WinFormsApp
{
    partial class TLMBackupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMBackupForm));
            this.SuspendLayout();
            // 
            // TLMBackupForm
            // 
            this.btnBackup = (new System.Windows.Forms.Button());
            this.txtFileName = (new System.Windows.Forms.TextBox());
            this.saveFileDialog = (new System.Windows.Forms.SaveFileDialog());
            this.btnEsportAs = (new System.Windows.Forms.Button());
            this.txtBox_ConnectionString = (new System.Windows.Forms.TextBox());
            this.btnConnectString = (new System.Windows.Forms.Button());
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(458, 184);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(121, 52);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup / Export";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(127, 60);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(236, 20);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "sql";
            this.saveFileDialog.InitialDirectory = "C\\Backups";
            // 
            // btnEsportAs
            // 
            this.btnEsportAs.Location = new System.Drawing.Point(35, 56);
            this.btnEsportAs.Name = "btnEsportAs";
            this.btnEsportAs.Size = new System.Drawing.Size(75, 23);
            this.btnEsportAs.TabIndex = 5;
            this.btnEsportAs.Text = "ExportAs";
            this.btnEsportAs.UseVisualStyleBackColor = true;
            this.btnEsportAs.Click += new System.EventHandler(this.btnExportAs_Click);
            // 
            // txtBox_ConnectionString
            // 
            this.txtBox_ConnectionString.Location = new System.Drawing.Point(146, 14);
            this.txtBox_ConnectionString.Name = "txtBox_ConnectionString";
            this.txtBox_ConnectionString.Size = new System.Drawing.Size(455, 20);
            this.txtBox_ConnectionString.TabIndex = 6;
            // 
            // btnConnectString
            // 
            this.btnConnectString.Location = new System.Drawing.Point(35, 12);
            this.btnConnectString.Name = "btnConnectString";
            this.btnConnectString.Size = new System.Drawing.Size(105, 23);
            this.btnConnectString.TabIndex = 7;
            this.btnConnectString.Text = "Connection String";
            this.btnConnectString.UseVisualStyleBackColor = true;
            // 
            // TLMBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 261);
            this.Controls.Add(this.btnConnectString);
            this.Controls.Add(this.txtBox_ConnectionString);
            this.Controls.Add(this.btnEsportAs);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TLMBackupForm";
            this.Text = "TLMBackup";
            this.Load += new System.EventHandler(this.TLMBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button  btnBackup;
	    private System.Windows.Forms.TextBox  txtFileName;
	    private System.Windows.Forms.SaveFileDialog  saveFileDialog;
	    private System.Windows.Forms.Button  btnEsportAs;
	    private System.Windows.Forms.TextBox  txtBox_ConnectionString;
	    private System.Windows.Forms.Button  btnConnectString;

        public
            static String ConnectionString = "";
            static String DefaultFolder = "";
            static String TargetFile = "";
    }
}