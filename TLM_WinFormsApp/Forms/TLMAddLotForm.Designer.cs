using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMAddLotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMAddLotForm));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.lbl_Lot = new System.Windows.Forms.Label();
            this.Lot_txt = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.listBox_Lot = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(320, 134);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(88, 27);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // lbl_Lot
            // 
            this.lbl_Lot.AutoSize = true;
            this.lbl_Lot.Location = new System.Drawing.Point(27, 30);
            this.lbl_Lot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lot.Name = "lbl_Lot";
            this.lbl_Lot.Size = new System.Drawing.Size(24, 15);
            this.lbl_Lot.TabIndex = 2;
            this.lbl_Lot.Text = "Lot";
            // 
            // Lot_txt
            // 
            this.Lot_txt.Location = new System.Drawing.Point(98, 27);
            this.Lot_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Lot_txt.Name = "Lot_txt";
            this.Lot_txt.Size = new System.Drawing.Size(220, 23);
            this.Lot_txt.TabIndex = 0;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(320, 91);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(88, 27);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // listBox_Lot
            // 
            this.listBox_Lot.FormattingEnabled = true;
            this.listBox_Lot.ItemHeight = 15;
            this.listBox_Lot.Location = new System.Drawing.Point(98, 62);
            this.listBox_Lot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_Lot.Name = "listBox_Lot";
            this.listBox_Lot.Size = new System.Drawing.Size(172, 109);
            this.listBox_Lot.TabIndex = 4;
            // 
            // TLMAddLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 186);
            this.Controls.Add(this.listBox_Lot);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Lot_txt);
            this.Controls.Add(this.lbl_Lot);
            this.Controls.Add(this.Exit_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TLMAddLotForm";
            this.Text = "TLMAddLotForm";
            this.Load += new System.EventHandler(this.TLMAddLotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button  Exit_btn;
	    private Label  lbl_Lot;
	    private TextBox  Lot_txt;
	    private Button  Save_btn;
	    private ListBox  listBox_Lot;

    }
}