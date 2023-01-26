using System.Windows.Forms;
using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMEditVehicleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLMEditVehicleForm));
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
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.Txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Make = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.comboBox_Lot = new System.Windows.Forms.ComboBox();
            this.comboBox_Reason = new System.Windows.Forms.ComboBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_HowReleased = new System.Windows.Forms.TextBox();
            this.lbl_Reased = new System.Windows.Forms.Label();
            this.lbl_HowReleased = new System.Windows.Forms.Label();
            this.txt_OnLot = new System.Windows.Forms.MaskedTextBox();
            this.txt_O_id = new System.Windows.Forms.TextBox();
            this.lbl_O_id = new System.Windows.Forms.Label();
            this.dataGridView1_Own = new System.Windows.Forms.DataGridView();
            this.lbl_owners = new System.Windows.Forms.Label();
            this.txt_Lot_id = new System.Windows.Forms.TextBox();
            this.mTxtB_Released = new System.Windows.Forms.MaskedTextBox();
            this.Release_btn = new System.Windows.Forms.Button();
            this.txtBx_AmountDue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Own)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.CausesValidation = false;
            this.Exit_Btn.Location = new System.Drawing.Point(1013, 487);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(88, 27);
            this.Exit_Btn.TabIndex = 14;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // Title_chkBox
            // 
            this.Title_chkBox.AutoSize = true;
            this.Title_chkBox.Location = new System.Drawing.Point(202, 413);
            this.Title_chkBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Title_chkBox.Name = "Title_chkBox";
            this.Title_chkBox.Size = new System.Drawing.Size(51, 22);
            this.Title_chkBox.TabIndex = 10;
            this.Title_chkBox.Text = "False";
            this.Title_chkBox.UseCompatibleTextRendering = true;
            this.Title_chkBox.UseVisualStyleBackColor = false;
            this.Title_chkBox.CheckedChanged += new System.EventHandler(this.UpdateTitle_lbl);
            // 
            // VIN_lbl
            // 
            this.VIN_lbl.AutoSize = true;
            this.VIN_lbl.Enabled = false;
            this.VIN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VIN_lbl.Location = new System.Drawing.Point(40, 51);
            this.VIN_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VIN_lbl.Name = "VIN_lbl";
            this.VIN_lbl.Size = new System.Drawing.Size(29, 16);
            this.VIN_lbl.TabIndex = 16;
            this.VIN_lbl.Text = "VIN";
            // 
            // txt_VIN
            // 
            this.txt_VIN.Location = new System.Drawing.Point(202, 51);
            this.txt_VIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_VIN.MaxLength = 17;
            this.txt_VIN.Name = "txt_VIN";
            this.txt_VIN.Size = new System.Drawing.Size(187, 23);
            this.txt_VIN.TabIndex = 0;
            this.txt_VIN.Validating += new System.ComponentModel.CancelEventHandler(this.txt_VIN_Validating);
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Make_lbl.Location = new System.Drawing.Point(40, 96);
            this.Make_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(41, 16);
            this.Make_lbl.TabIndex = 17;
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
            this.Model_lbl.TabIndex = 18;
            this.Model_lbl.Text = "Mode";
            // 
            // Year_lbl
            // 
            this.Year_lbl.AutoSize = true;
            this.Year_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_lbl.Location = new System.Drawing.Point(40, 181);
            this.Year_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year_lbl.Name = "Year_lbl";
            this.Year_lbl.Size = new System.Drawing.Size(39, 16);
            this.Year_lbl.TabIndex = 19;
            this.Year_lbl.Text = "Year ";
            // 
            // Color_lbl
            // 
            this.Color_lbl.AutoSize = true;
            this.Color_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Color_lbl.Location = new System.Drawing.Point(40, 231);
            this.Color_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Color_lbl.Name = "Color_lbl";
            this.Color_lbl.Size = new System.Drawing.Size(39, 16);
            this.Color_lbl.TabIndex = 20;
            this.Color_lbl.Text = "Color";
            // 
            // OnLot_lbl
            // 
            this.OnLot_lbl.AutoSize = true;
            this.OnLot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnLot_lbl.Location = new System.Drawing.Point(40, 275);
            this.OnLot_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OnLot_lbl.Name = "OnLot_lbl";
            this.OnLot_lbl.Size = new System.Drawing.Size(80, 16);
            this.OnLot_lbl.TabIndex = 21;
            this.OnLot_lbl.Text = "Date On Lot ";
            // 
            // Lot_lbl
            // 
            this.Lot_lbl.AutoSize = true;
            this.Lot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lot_lbl.Location = new System.Drawing.Point(40, 321);
            this.Lot_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lot_lbl.Name = "Lot_lbl";
            this.Lot_lbl.Size = new System.Drawing.Size(25, 16);
            this.Lot_lbl.TabIndex = 22;
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
            this.Reason_lbl.TabIndex = 23;
            this.Reason_lbl.Text = "Reason";
            // 
            // OwnerLastName_lbl
            // 
            this.OwnerLastName_lbl.AutoSize = true;
            this.OwnerLastName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerLastName_lbl.Location = new System.Drawing.Point(616, 60);
            this.OwnerLastName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerLastName_lbl.Name = "OwnerLastName_lbl";
            this.OwnerLastName_lbl.Size = new System.Drawing.Size(123, 16);
            this.OwnerLastName_lbl.TabIndex = 28;
            this.OwnerLastName_lbl.Text = "Owner\'s Last Name";
            // 
            // OwnerFirstName_lbl
            // 
            this.OwnerFirstName_lbl.AutoSize = true;
            this.OwnerFirstName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerFirstName_lbl.Location = new System.Drawing.Point(616, 102);
            this.OwnerFirstName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerFirstName_lbl.Name = "OwnerFirstName_lbl";
            this.OwnerFirstName_lbl.Size = new System.Drawing.Size(123, 16);
            this.OwnerFirstName_lbl.TabIndex = 29;
            this.OwnerFirstName_lbl.Text = "Owner\'s First Name";
            // 
            // txt_OwnerFirstName
            // 
            this.txt_OwnerFirstName.Location = new System.Drawing.Point(780, 97);
            this.txt_OwnerFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OwnerFirstName.Name = "txt_OwnerFirstName";
            this.txt_OwnerFirstName.ReadOnly = true;
            this.txt_OwnerFirstName.Size = new System.Drawing.Size(340, 23);
            this.txt_OwnerFirstName.TabIndex = 32;
            this.txt_OwnerFirstName.TabStop = false;
            // 
            // txt_OwnerLastName
            // 
            this.txt_OwnerLastName.Location = new System.Drawing.Point(780, 55);
            this.txt_OwnerLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OwnerLastName.Name = "txt_OwnerLastName";
            this.txt_OwnerLastName.ReadOnly = true;
            this.txt_OwnerLastName.Size = new System.Drawing.Size(340, 23);
            this.txt_OwnerLastName.TabIndex = 31;
            this.txt_OwnerLastName.TabStop = false;
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(202, 369);
            this.txt_Reason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(204, 23);
            this.txt_Reason.TabIndex = 8;
            // 
            // txt_Lot
            // 
            this.txt_Lot.Location = new System.Drawing.Point(202, 320);
            this.txt_Lot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Lot.Name = "txt_Lot";
            this.txt_Lot.Size = new System.Drawing.Size(204, 23);
            this.txt_Lot.TabIndex = 6;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(202, 226);
            this.txt_Color.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(187, 23);
            this.txt_Color.TabIndex = 4;
            // 
            // Txt_Year
            // 
            this.Txt_Year.Location = new System.Drawing.Point(202, 177);
            this.Txt_Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Year.Name = "Txt_Year";
            this.Txt_Year.Size = new System.Drawing.Size(82, 23);
            this.Txt_Year.TabIndex = 3;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(202, 132);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(187, 23);
            this.txt_Model.TabIndex = 2;
            // 
            // Txt_Make
            // 
            this.Txt_Make.Location = new System.Drawing.Point(202, 91);
            this.Txt_Make.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Make.Name = "Txt_Make";
            this.Txt_Make.Size = new System.Drawing.Size(187, 23);
            this.Txt_Make.TabIndex = 1;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(874, 487);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(88, 27);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "Update";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // comboBox_Lot
            // 
            this.comboBox_Lot.FormattingEnabled = true;
            this.comboBox_Lot.Location = new System.Drawing.Point(426, 320);
            this.comboBox_Lot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Lot.Name = "comboBox_Lot";
            this.comboBox_Lot.Size = new System.Drawing.Size(187, 23);
            this.comboBox_Lot.TabIndex = 7;
            this.comboBox_Lot.SelectedIndexChanged += new System.EventHandler(this.comboBox_Lot_SelectedIndexChanged);
            // 
            // comboBox_Reason
            // 
            this.comboBox_Reason.FormattingEnabled = true;
            this.comboBox_Reason.Location = new System.Drawing.Point(426, 369);
            this.comboBox_Reason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Reason.Name = "comboBox_Reason";
            this.comboBox_Reason.Size = new System.Drawing.Size(187, 23);
            this.comboBox_Reason.TabIndex = 9;
            this.comboBox_Reason.SelectedIndexChanged += new System.EventHandler(this.comboBox_Reason_SelectedIndexChanged);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(295, 411);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.ReadOnly = true;
            this.txt_Title.Size = new System.Drawing.Size(94, 23);
            this.txt_Title.TabIndex = 88;
            this.txt_Title.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(40, 10);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(202, 14);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ID.MaxLength = 17;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(187, 23);
            this.txt_ID.TabIndex = 35;
            this.txt_ID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Title";
            // 
            // txtB_HowReleased
            // 
            this.txtB_HowReleased.Location = new System.Drawing.Point(202, 493);
            this.txtB_HowReleased.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtB_HowReleased.Name = "txtB_HowReleased";
            this.txtB_HowReleased.Size = new System.Drawing.Size(411, 23);
            this.txtB_HowReleased.TabIndex = 12;
            // 
            // lbl_Reased
            // 
            this.lbl_Reased.AutoSize = true;
            this.lbl_Reased.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reased.Location = new System.Drawing.Point(40, 457);
            this.lbl_Reased.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Reased.Name = "lbl_Reased";
            this.lbl_Reased.Size = new System.Drawing.Size(99, 16);
            this.lbl_Reased.TabIndex = 25;
            this.lbl_Reased.Text = "Date Released";
            // 
            // lbl_HowReleased
            // 
            this.lbl_HowReleased.AutoSize = true;
            this.lbl_HowReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HowReleased.Location = new System.Drawing.Point(40, 498);
            this.lbl_HowReleased.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HowReleased.Name = "lbl_HowReleased";
            this.lbl_HowReleased.Size = new System.Drawing.Size(97, 16);
            this.lbl_HowReleased.TabIndex = 26;
            this.lbl_HowReleased.Text = "How Released";
            // 
            // txt_OnLot
            // 
            this.txt_OnLot.AllowPromptAsInput = false;
            this.txt_OnLot.Location = new System.Drawing.Point(202, 275);
            this.txt_OnLot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_OnLot.Mask = "00/00/0000";
            this.txt_OnLot.Name = "txt_OnLot";
            this.txt_OnLot.Size = new System.Drawing.Size(82, 23);
            this.txt_OnLot.TabIndex = 5;
            // 
            // txt_O_id
            // 
            this.txt_O_id.Location = new System.Drawing.Point(780, 14);
            this.txt_O_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_O_id.Name = "txt_O_id";
            this.txt_O_id.ReadOnly = true;
            this.txt_O_id.Size = new System.Drawing.Size(128, 23);
            this.txt_O_id.TabIndex = 30;
            this.txt_O_id.TabStop = false;
            // 
            // lbl_O_id
            // 
            this.lbl_O_id.AutoSize = true;
            this.lbl_O_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_O_id.Location = new System.Drawing.Point(616, 18);
            this.lbl_O_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_O_id.Name = "lbl_O_id";
            this.lbl_O_id.Size = new System.Drawing.Size(71, 16);
            this.lbl_O_id.TabIndex = 27;
            this.lbl_O_id.Text = "Owner\'s ID";
            // 
            // dataGridView1_Own
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1_Own.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_Own.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Own.Location = new System.Drawing.Point(780, 162);
            this.dataGridView1_Own.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1_Own.Name = "dataGridView1_Own";
            this.dataGridView1_Own.ReadOnly = true;
            this.dataGridView1_Own.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Own.Size = new System.Drawing.Size(340, 173);
            this.dataGridView1_Own.TabIndex = 33;
            this.dataGridView1_Own.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Own_CellDoubleClick);
            // 
            // lbl_owners
            // 
            this.lbl_owners.AutoSize = true;
            this.lbl_owners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_owners.Location = new System.Drawing.Point(891, 338);
            this.lbl_owners.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_owners.Name = "lbl_owners";
            this.lbl_owners.Size = new System.Drawing.Size(75, 16);
            this.lbl_owners.TabIndex = 34;
            this.lbl_owners.Text = "Owners List";
            // 
            // txt_Lot_id
            // 
            this.txt_Lot_id.Location = new System.Drawing.Point(134, 321);
            this.txt_Lot_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Lot_id.Name = "txt_Lot_id";
            this.txt_Lot_id.ReadOnly = true;
            this.txt_Lot_id.Size = new System.Drawing.Size(45, 23);
            this.txt_Lot_id.TabIndex = 94;
            this.txt_Lot_id.TabStop = false;
            // 
            // mTxtB_Released
            // 
            this.mTxtB_Released.AllowPromptAsInput = false;
            this.mTxtB_Released.Location = new System.Drawing.Point(202, 456);
            this.mTxtB_Released.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mTxtB_Released.Mask = "00/00/0000";
            this.mTxtB_Released.Name = "mTxtB_Released";
            this.mTxtB_Released.Size = new System.Drawing.Size(82, 23);
            this.mTxtB_Released.TabIndex = 11;
            // 
            // Release_btn
            // 
            this.Release_btn.Location = new System.Drawing.Point(760, 490);
            this.Release_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Release_btn.Name = "Release_btn";
            this.Release_btn.Size = new System.Drawing.Size(88, 27);
            this.Release_btn.TabIndex = 95;
            this.Release_btn.Text = "Release";
            this.Release_btn.UseVisualStyleBackColor = true;
            this.Release_btn.Click += new System.EventHandler(this.Release_btn_Click);
            // 
            // txtBx_AmountDue
            // 
            this.txtBx_AmountDue.Location = new System.Drawing.Point(426, 451);
            this.txtBx_AmountDue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBx_AmountDue.Name = "txtBx_AmountDue";
            this.txtBx_AmountDue.Size = new System.Drawing.Size(116, 23);
            this.txtBx_AmountDue.TabIndex = 96;
            this.txtBx_AmountDue.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 97;
            this.label2.Text = "MM/DD//YYYY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 98;
            this.label3.Text = "MM/DD/YYYY";
            // 
            // TLMEditVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1135, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_AmountDue);
            this.Controls.Add(this.Release_btn);
            this.Controls.Add(this.mTxtB_Released);
            this.Controls.Add(this.txt_Lot_id);
            this.Controls.Add(this.lbl_owners);
            this.Controls.Add(this.dataGridView1_Own);
            this.Controls.Add(this.lbl_O_id);
            this.Controls.Add(this.txt_O_id);
            this.Controls.Add(this.txt_OnLot);
            this.Controls.Add(this.lbl_HowReleased);
            this.Controls.Add(this.lbl_Reased);
            this.Controls.Add(this.txtB_HowReleased);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.comboBox_Reason);
            this.Controls.Add(this.comboBox_Lot);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Txt_Make);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.Txt_Year);
            this.Controls.Add(this.txt_Color);
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
            this.Name = "TLMEditVehicleForm";
            this.Text = "Vehicle Edit Form";
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            this.Click += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Own)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button  Exit_Btn;
	    public System.Windows.Forms.CheckBox  Title_chkBox;
	    private System.Windows.Forms.Label  VIN_lbl;
	    public System.Windows.Forms.TextBox  txt_VIN;
	    private System.Windows.Forms.Label  Make_lbl;
	    private System.Windows.Forms.Label  Model_lbl;
	    private System.Windows.Forms.Label  Year_lbl;
	    private System.Windows.Forms.Label  Color_lbl;
	    private System.Windows.Forms.Label  OnLot_lbl;
	    private System.Windows.Forms.Label  Lot_lbl;
	    private System.Windows.Forms.Label  Reason_lbl;
	    private System.Windows.Forms.Label  OwnerLastName_lbl;
	    private System.Windows.Forms.Label  OwnerFirstName_lbl;
	    public System.Windows.Forms.TextBox  txt_OwnerFirstName;
	    public System.Windows.Forms.TextBox  txt_OwnerLastName;
	    public System.Windows.Forms.TextBox  txt_Reason;
	    public System.Windows.Forms.TextBox  txt_Lot;
	    public System.Windows.Forms.TextBox  txt_Color;
	    public System.Windows.Forms.TextBox  Txt_Year;
	    public System.Windows.Forms.TextBox  txt_Model;
	    public System.Windows.Forms.TextBox  Txt_Make;
	    private System.Windows.Forms.Button  Save_btn;
	    public System.Windows.Forms.ComboBox  comboBox_Lot;
	    public System.Windows.Forms.ComboBox  comboBox_Reason;
	    public System.Windows.Forms.TextBox  txt_Title;
	    private System.Windows.Forms.Label  ID;
	    public System.Windows.Forms.TextBox  txt_ID;
	    private System.Windows.Forms.Label  label1;
	    public System.Windows.Forms.TextBox  txtB_HowReleased;
	    private System.Windows.Forms.Label  lbl_Reased;
	    private System.Windows.Forms.Label  lbl_HowReleased;
	    public System.Windows.Forms.MaskedTextBox  txt_OnLot;
	    public System.Windows.Forms.TextBox  txt_O_id;
	    private System.Windows.Forms.Label  lbl_O_id;
	    private System.Windows.Forms.DataGridView  dataGridView1_Own;
	    private System.Windows.Forms.Label  lbl_owners;
	    public System.Windows.Forms.TextBox  txt_Lot_id;
	    public System.Windows.Forms.MaskedTextBox  mTxtB_Released;
	    private System.Windows.Forms.Button  Release_btn;
	    public System.Windows.Forms.TextBox  txtBx_AmountDue;
	    private System.Windows.Forms.Label label2;
	    private System.Windows.Forms.Label label3;

    }
}