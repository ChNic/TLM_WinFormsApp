namespace TLM_WinFormsApp
{
    partial class TLMRestoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMRestoreForm));
            this.txtBox_ConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnectString = new System.Windows.Forms.Button();
            this.btnImportFileName = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnStartImport = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtBox_ConnectionString
            // 
            this.txtBox_ConnectionString.Location = new System.Drawing.Point(212, 37);
            this.txtBox_ConnectionString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_ConnectionString.Name = "txtBox_ConnectionString";
            this.txtBox_ConnectionString.Size = new System.Drawing.Size(423, 23);
            this.txtBox_ConnectionString.TabIndex = 0;
            // 
            // btnConnectString
            // 
            this.btnConnectString.Location = new System.Drawing.Point(49, 33);
            this.btnConnectString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnectString.Name = "btnConnectString";
            this.btnConnectString.Size = new System.Drawing.Size(117, 27);
            this.btnConnectString.TabIndex = 1;
            this.btnConnectString.Text = "Connect String";
            this.btnConnectString.UseVisualStyleBackColor = true;
            // 
            // btnImportFileName
            // 
            this.btnImportFileName.Location = new System.Drawing.Point(49, 100);
            this.btnImportFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImportFileName.Name = "btnImportFileName";
            this.btnImportFileName.Size = new System.Drawing.Size(117, 27);
            this.btnImportFileName.TabIndex = 2;
            this.btnImportFileName.Text = "Import File";
            this.btnImportFileName.UseVisualStyleBackColor = true;
            this.btnImportFileName.Click += new System.EventHandler(this.btnImportFileName_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(212, 104);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(423, 23);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnStartImport
            // 
            this.btnStartImport.Location = new System.Drawing.Point(322, 163);
            this.btnStartImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartImport.Name = "btnStartImport";
            this.btnStartImport.Size = new System.Drawing.Size(138, 27);
            this.btnStartImport.TabIndex = 4;
            this.btnStartImport.Text = "Restore / Import";
            this.btnStartImport.UseVisualStyleBackColor = true;
            this.btnStartImport.Click += new System.EventHandler(this.btnStartImport_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 27);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TLMRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStartImport);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnImportFileName);
            this.Controls.Add(this.btnConnectString);
            this.Controls.Add(this.txtBox_ConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TLMRestoreForm";
            this.Text = "MyMainForm";
            this.Load += new System.EventHandler(this.TLMRestoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_ConnectionString;
	    private System.Windows.Forms.Button btnConnectString;
	    private System.Windows.Forms.Button btnImportFileName;
	    private System.Windows.Forms.TextBox txtFileName;
	    private System.Windows.Forms.Button btnStartImport;
	    private System.Windows.Forms.ProgressBar progressBar1;
	    private System.Windows.Forms.Label label1;
	    private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public
            static String ConnectionString = "";
            static String DefaultFolder = "";
            static String TargetFile = "";


    }
}