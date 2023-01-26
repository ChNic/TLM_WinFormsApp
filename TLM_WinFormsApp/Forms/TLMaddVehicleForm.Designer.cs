using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMaddVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMaddVehicleForm));
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Title_chkBox = new System.Windows.Forms.CheckBox();
            this.VIN_lbl = new System.Windows.Forms.Label();
            this.txt_VIN = new System.Windows.Forms.TextBox();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.Model_lbl = new System.Windows.Forms.Label();
            this.Year_lbl = new System.Windows.Forms.Label();
            this.Color_lbl = new System.Windows.Forms.Label();
            this.OnLot_lbl = new System.Windows.Forms.Label();
            this.Lot_lbl = new System.Windows.Forms.Label();
            this.Reason_lbl = new System.Windows.Forms.Label();
            this.OwnerLastName_lbl = new System.Windows.Forms.Label();
            this.OwnerFirstName_lbl = new System.Windows.Forms.Label();
            this.txt_OwnerFirstName = new System.Windows.Forms.TextBox();
            this.txt_OwnerLastName = new System.Windows.Forms.TextBox();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.txt_Lot = new System.Windows.Forms.TextBox();
            this.txt_OnLot = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.Txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Make = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.comboBox_Lot = new System.Windows.Forms.ComboBox();
            this.comboBox_Reason = new System.Windows.Forms.ComboBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Lot_id = new System.Windows.Forms.TextBox();
            this.dataGridView1_Owner = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Owner)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.CausesValidation = false;
            this.Exit_Btn.Location = new System.Drawing.Point(1013, 487);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(88, 27);
            this.Exit_Btn.TabIndex = 12;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // Title_chkBox
            // 
            this.Title_chkBox.AutoSize = true;
            this.Title_chkBox.Location = new System.Drawing.Point(175, 410);
            this.Title_chkBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Title_chkBox.Name = "Title_chkBox";
            this.Title_chkBox.Size = new System.Drawing.Size(48, 19);
            this.Title_chkBox.TabIndex = 8;
            this.Title_chkBox.Text = "Title";
            this.Title_chkBox.UseVisualStyleBackColor = false;
            this.Title_chkBox.CheckedChanged += new System.EventHandler(this.UpdateTitle_lbl);
            // 
            // VIN_lbl
            // 
            this.VIN_lbl.AutoSize = true;
            this.VIN_lbl.Enabled = false;
            this.VIN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VIN_lbl.Location = new System.Drawing.Point(40, 30);
            this.VIN_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VIN_lbl.Name = "VIN_lbl";
            this.VIN_lbl.Size = new System.Drawing.Size(29, 16);
            this.VIN_lbl.TabIndex = 13;
            this.VIN_lbl.Text = "VIN";
            // 
            // txt_VIN
            // 
            this.txt_VIN.Location = new System.Drawing.Point(175, 27);
            this.txt_VIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_VIN.MaxLength = 17;
            this.txt_VIN.Name = "txt_VIN";
            this.txt_VIN.Size = new System.Drawing.Size(187, 23);
            this.txt_VIN.TabIndex = 0;
            this.txt_VIN.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_VIN_Validating);
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Make_lbl.Location = new System.Drawing.Point(40, 85);
            this.Make_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(41, 16);
            this.Make_lbl.TabIndex = 14;
            this.Make_lbl.Text = "Make";
            // 
            // Model_lbl
            // 
            this.Model_lbl.AutoSize = true;
            this.Model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Model_lbl.Location = new System.Drawing.Point(40, 136);
            this.Model_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Model_lbl.Name = "Model_lbl";
            this.Model_lbl.Size = new System.Drawing.Size(42, 16);
            this.Model_lbl.TabIndex = 15;
            this.Model_lbl.Text = "Mode";
            // 
            // Year_lbl
            // 
            this.Year_lbl.AutoSize = true;
            this.Year_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_lbl.Location = new System.Drawing.Point(40, 181);
            this.Year_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year_lbl.Name = "Year_lbl";
            this.Year_lbl.Size = new System.Drawing.Size(36, 16);
            this.Year_lbl.TabIndex = 16;
            this.Year_lbl.Text = "Year";
            // 
            // Color_lbl
            // 
            this.Color_lbl.AutoSize = true;
            this.Color_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Color_lbl.Location = new System.Drawing.Point(40, 231);
            this.Color_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Color_lbl.Name = "Color_lbl";
            this.Color_lbl.Size = new System.Drawing.Size(39, 16);
            this.Color_lbl.TabIndex = 17;
            this.Color_lbl.Text = "Color";
            // 
            // OnLot_lbl
            // 
            this.OnLot_lbl.AutoSize = true;
            this.OnLot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnLot_lbl.Location = new System.Drawing.Point(40, 275);
            this.OnLot_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OnLot_lbl.Name = "OnLot_lbl";
            this.OnLot_lbl.Size = new System.Drawing.Size(77, 16);
            this.OnLot_lbl.TabIndex = 18;
            this.OnLot_lbl.Text = "Date On Lot";
            // 
            // Lot_lbl
            // 
            this.Lot_lbl.AutoSize = true;
            this.Lot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lot_lbl.Location = new System.Drawing.Point(40, 317);
            this.Lot_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lot_lbl.Name = "Lot_lbl";
            this.Lot_lbl.Size = new System.Drawing.Size(25, 16);
            this.Lot_lbl.TabIndex = 19;
            this.Lot_lbl.Text = "Lot";
            // 
            // Reason_lbl
            // 
            this.Reason_lbl.AutoSize = true;
            this.Reason_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reason_lbl.Location = new System.Drawing.Point(40, 370);
            this.Reason_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reason_lbl.Name = "Reason_lbl";
            this.Reason_lbl.Size = new System.Drawing.Size(55, 16);
            this.Reason_lbl.TabIndex = 20;
            this.Reason_lbl.Text = "Reason";
            // 
            // OwnerLastName_lbl
            // 
            this.OwnerLastName_lbl.AutoSize = true;
            this.OwnerLastName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerLastName_lbl.Location = new System.Drawing.Point(14, 456);
            this.OwnerLastName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerLastName_lbl.Name = "OwnerLastName_lbl";
            this.OwnerLastName_lbl.Size = new System.Drawing.Size(123, 16);
            this.OwnerLastName_lbl.TabIndex = 22;
            this.OwnerLastName_lbl.Text = "Owner\'s Last Name";
            // 
            // OwnerFirstName_lbl
            // 
            this.OwnerFirstName_lbl.AutoSize = true;
            this.OwnerFirstName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerFirstName_lbl.Location = new System.Drawing.Point(14, 492);
            this.OwnerFirstName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerFirstName_lbl.Name = "OwnerFirstName_lbl";
            this.OwnerFirstName_lbl.Size = new System.Drawing.Size(123, 16);
            this.OwnerFirstName_lbl.TabIndex = 23;
            this.OwnerFirstName_lbl.Text = "Owner\'s First Name";
            // 
            // txt_OwnerFirstName
            // 
            this.txt_OwnerFirstName.Location = new System.Drawing.Point(175, 490);
            this.txt_OwnerFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OwnerFirstName.Name = "txt_OwnerFirstName";
            this.txt_OwnerFirstName.Size = new System.Drawing.Size(340, 23);
            this.txt_OwnerFirstName.TabIndex = 10;
            // 
            // txt_OwnerLastName
            // 
            this.txt_OwnerLastName.Location = new System.Drawing.Point(175, 456);
            this.txt_OwnerLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OwnerLastName.Name = "txt_OwnerLastName";
            this.txt_OwnerLastName.Size = new System.Drawing.Size(340, 23);
            this.txt_OwnerLastName.TabIndex = 9;
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(340, 226);
            this.txt_Reason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(116, 23);
            this.txt_Reason.TabIndex = 25;
            this.txt_Reason.Visible = false;
            // 
            // txt_Lot
            // 
            this.txt_Lot.Location = new System.Drawing.Point(340, 177);
            this.txt_Lot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Lot.Name = "txt_Lot";
            this.txt_Lot.Size = new System.Drawing.Size(116, 23);
            this.txt_Lot.TabIndex = 24;
            this.txt_Lot.Visible = false;
            // 
            // txt_OnLot
            // 
            this.txt_OnLot.Location = new System.Drawing.Point(175, 267);
            this.txt_OnLot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OnLot.Name = "txt_OnLot";
            this.txt_OnLot.Size = new System.Drawing.Size(116, 23);
            this.txt_OnLot.TabIndex = 5;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(175, 223);
            this.txt_Color.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(116, 23);
            this.txt_Color.TabIndex = 4;
            // 
            // Txt_Year
            // 
            this.Txt_Year.Location = new System.Drawing.Point(175, 173);
            this.Txt_Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Year.Name = "Txt_Year";
            this.Txt_Year.Size = new System.Drawing.Size(116, 23);
            this.Txt_Year.TabIndex = 3;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(175, 128);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(187, 23);
            this.txt_Model.TabIndex = 2;
            // 
            // Txt_Make
            // 
            this.Txt_Make.Location = new System.Drawing.Point(175, 77);
            this.Txt_Make.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Make.Name = "Txt_Make";
            this.Txt_Make.Size = new System.Drawing.Size(187, 23);
            this.Txt_Make.TabIndex = 1;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(1013, 428);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(88, 27);
            this.Save_btn.TabIndex = 11;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // comboBox_Lot
            // 
            this.comboBox_Lot.AllowDrop = true;
            this.comboBox_Lot.FormattingEnabled = true;
            this.comboBox_Lot.Location = new System.Drawing.Point(175, 313);
            this.comboBox_Lot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Lot.Name = "comboBox_Lot";
            this.comboBox_Lot.Size = new System.Drawing.Size(187, 23);
            this.comboBox_Lot.TabIndex = 6;
            this.comboBox_Lot.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Lot_SelectedIndexChanged);
            // 
            // comboBox_Reason
            // 
            this.comboBox_Reason.AllowDrop = true;
            this.comboBox_Reason.FormattingEnabled = true;
            this.comboBox_Reason.Location = new System.Drawing.Point(175, 365);
            this.comboBox_Reason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Reason.Name = "comboBox_Reason";
            this.comboBox_Reason.Size = new System.Drawing.Size(187, 23);
            this.comboBox_Reason.TabIndex = 7;
            this.comboBox_Reason.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Reason_SelectedIndexChanged);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(268, 407);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(94, 23);
            this.txt_Title.TabIndex = 26;
            this.txt_Title.Visible = false;
            // 
            // txt_Lot_id
            // 
            this.txt_Lot_id.Location = new System.Drawing.Point(113, 313);
            this.txt_Lot_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Lot_id.Name = "txt_Lot_id";
            this.txt_Lot_id.Size = new System.Drawing.Size(45, 23);
            this.txt_Lot_id.TabIndex = 94;
            // 
            // dataGridView1_Owner
            // 
            this.dataGridView1_Owner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Owner.Location = new System.Drawing.Point(712, 77);
            this.dataGridView1_Owner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1_Owner.Name = "dataGridView1_Owner";
            this.dataGridView1_Owner.Size = new System.Drawing.Size(355, 173);
            this.dataGridView1_Owner.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(805, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Owners On File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(383, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "I = 1 O = 0 Q = 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "MM/DD/YYYY";
            // 
            // TLMaddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1135, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_Owner);
            this.Controls.Add(this.txt_Lot_id);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.comboBox_Reason);
            this.Controls.Add(this.comboBox_Lot);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Txt_Make);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.Txt_Year);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_OnLot);
            this.Controls.Add(this.txt_Lot);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.txt_OwnerLastName);
            this.Controls.Add(this.txt_OwnerFirstName);
            this.Controls.Add(this.OwnerFirstName_lbl);
            this.Controls.Add(this.OwnerLastName_lbl);
            this.Controls.Add(this.Reason_lbl);
            this.Controls.Add(this.Lot_lbl);
            this.Controls.Add(this.OnLot_lbl);
            this.Controls.Add(this.Color_lbl);
            this.Controls.Add(this.Year_lbl);
            this.Controls.Add(this.Model_lbl);
            this.Controls.Add(this.Make_lbl);
            this.Controls.Add(this.txt_VIN);
            this.Controls.Add(this.VIN_lbl);
            this.Controls.Add(this.Title_chkBox);
            this.Controls.Add(this.Exit_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TLMaddVehicleForm";
            this.Text = "Vehicle Entry Form";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Owner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button  Exit_Btn;
		private System.Windows.Forms.CheckBox  Title_chkBox;
		private System.Windows.Forms.Label  VIN_lbl;
		private System.Windows.Forms.TextBox  txt_VIN;
		private System.Windows.Forms.Label  Make_lbl;
		private System.Windows.Forms.Label  Model_lbl;
		private System.Windows.Forms.Label  Year_lbl;
		private System.Windows.Forms.Label  Color_lbl;
		private System.Windows.Forms.Label  OnLot_lbl;
		private System.Windows.Forms.Label  Lot_lbl;
		private System.Windows.Forms.Label  Reason_lbl;
		private System.Windows.Forms.Label  OwnerLastName_lbl;
		private System.Windows.Forms.Label  OwnerFirstName_lbl;
		private System.Windows.Forms.TextBox  txt_OwnerFirstName;
		private System.Windows.Forms.TextBox  txt_OwnerLastName;
		private System.Windows.Forms.TextBox  txt_Reason;
		private System.Windows.Forms.TextBox  txt_Lot;
		private System.Windows.Forms.TextBox  txt_OnLot;
		private System.Windows.Forms.TextBox  txt_Color;
		private System.Windows.Forms.TextBox  Txt_Year;
		private System.Windows.Forms.TextBox  txt_Model;
		private System.Windows.Forms.TextBox  Txt_Make;
		private System.Windows.Forms.Button  Save_btn;
		private System.Windows.Forms.ComboBox  comboBox_Lot;
		private System.Windows.Forms.ComboBox  comboBox_Reason;
		private System.Windows.Forms.TextBox  txt_Title;
		private System.Windows.Forms.TextBox  txt_Lot_id;
		private System.Windows.Forms.DataGridView  dataGridView1_Owner;
		private System.Windows.Forms.Label  label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;

    }
}