using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMAddReasonForm
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
            System.ComponentModel.ComponentResourceManager  resources = (new System.ComponentModel.ComponentResourceManager(typeof(TLMAddReasonForm)));
            this.Exit_btn = (new Button());
            this.lbl_Reason = (new Label());
            this.txt_Reason = (new TextBox());
            this.Save_btn = (new Button());
            this.listBox_Reason = (new ListBox());
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(377, 121);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Location = new System.Drawing.Point(30, 28);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(44, 13);
            this.lbl_Reason.TabIndex = 1;
            this.lbl_Reason.Text = "Reason";
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(94, 21);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(244, 20);
            this.txt_Reason.TabIndex = 2;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(377, 80);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // listBox_Reason
            // 
            this.listBox_Reason.FormattingEnabled = true;
            this.listBox_Reason.Location = new System.Drawing.Point(94, 60);
            this.listBox_Reason.Name = "listBox_Reason";
            this.listBox_Reason.Size = new System.Drawing.Size(244, 95);
            this.listBox_Reason.TabIndex = 4;
            // 
            // TLMaddReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 169);
            this.Controls.Add(this.listBox_Reason);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.lbl_Reason);
            this.Controls.Add(this.Exit_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TLMaddReasonForm";
            this.Text = "Add Reason";
            this.Load += new System.EventHandler(this.TLMAddReasonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button  Exit_btn;
	    private Label  lbl_Reason;
	    private TextBox  txt_Reason;
	    private Button  Save_btn;
	    private ListBox  listBox_Reason;


    }
}