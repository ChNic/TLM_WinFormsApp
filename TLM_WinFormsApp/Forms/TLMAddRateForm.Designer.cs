using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMAddRateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMAddRateForm));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(301, 115);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(88, 27);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(122, 38);
            this.txt_Rate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(116, 23);
            this.txt_Rate.TabIndex = 1;
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Location = new System.Drawing.Point(43, 38);
            this.lbl_Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(30, 15);
            this.lbl_Rate.TabIndex = 2;
            this.lbl_Rate.Text = "Rate";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(301, 63);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(88, 27);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // TLMAddRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 180);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.lbl_Rate);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.Exit_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TLMAddRateForm";
            this.Text = "Add Rate";
            this.Load += new System.EventHandler(this.TLMAddRateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button  Exit_btn;
		private TextBox  txt_Rate;
		private Label  lbl_Rate;
		private Button  Save_btn;

   }
}