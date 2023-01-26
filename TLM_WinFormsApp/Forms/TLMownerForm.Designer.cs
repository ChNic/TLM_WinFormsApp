using System.Windows.Forms;
using TLM_WinFormsApp.Properties;

namespace TLM_WinFormsApp
{
    partial class TLMOnerForm
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

            System.Windows.Forms.DataGridViewCellStyle   dataGridViewCellStyle1 = ( new System.Windows.Forms.DataGridViewCellStyle());
            System.ComponentModel.ComponentResourceManager   resources = ( new System.ComponentModel.ComponentResourceManager(typeof(TLMOnerForm)));
            this.Exit_btn = ( new System.Windows.Forms.Button());
            this.lbl_LastName = ( new System.Windows.Forms.Label());
            this.lbl_FirstName = ( new System.Windows.Forms.Label());
            this.lbl_Address = ( new System.Windows.Forms.Label());
            this.lbl_City = ( new System.Windows.Forms.Label());
            this.lbl_State = ( new System.Windows.Forms.Label());
            this.lbl_Zip = ( new System.Windows.Forms.Label());
            this.lbl_Zip_Plus4 = ( new System.Windows.Forms.Label());
            this.lbl_Phone = ( new System.Windows.Forms.Label());
            this.txt_LastName = ( new System.Windows.Forms.TextBox());
            this.txt_FirstName = ( new System.Windows.Forms.TextBox());
            this.txt_Address = ( new System.Windows.Forms.TextBox());
            this.txt_City = ( new System.Windows.Forms.TextBox());
            this.txt_State = ( new System.Windows.Forms.TextBox());
            this.txt_Zip = ( new System.Windows.Forms.TextBox());
            this.txt_ZipPlus4 = ( new System.Windows.Forms.TextBox());
            this.Save_btn = ( new System.Windows.Forms.Button());
            this.dataGridView1 = ( new System.Windows.Forms.DataGridView());
            this.Update_btn = ( new System.Windows.Forms.Button());
            this.lbl_ID = ( new System.Windows.Forms.Label());
            this.txtB_ID = ( new System.Windows.Forms.TextBox());
            this.txt_Phone = ( new System.Windows.Forms.MaskedTextBox());
            (( System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(605, 236);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click +=  new System.EventHandler(this.Exit_button_Click);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(28, 40);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 9;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(28, 68);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 10;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(28, 101);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 11;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(28, 130);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(24, 13);
            this.lbl_City.TabIndex = 12;
            this.lbl_City.Text = "City";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(28, 160);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(32, 13);
            this.lbl_State.TabIndex = 13;
            this.lbl_State.Text = "State";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(28, 185);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(22, 13);
            this.lbl_Zip.TabIndex = 14;
            this.lbl_Zip.Text = "Zip";
            // 
            // lbl_Zip_Plus4
            // 
            this.lbl_Zip_Plus4.AutoSize = true;
            this.lbl_Zip_Plus4.Location = new System.Drawing.Point(28, 215);
            this.lbl_Zip_Plus4.Name = "lbl_Zip_Plus4";
            this.lbl_Zip_Plus4.Size = new System.Drawing.Size(54, 13);
            this.lbl_Zip_Plus4.TabIndex = 15;
            this.lbl_Zip_Plus4.Text = "Zip Plus 4";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(28, 236);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phone.TabIndex = 16;
            this.lbl_Phone.Text = "Phone";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(154, 33);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(201, 20);
            this.txt_LastName.TabIndex = 0;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(154, 65);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(201, 20);
            this.txt_FirstName.TabIndex = 1;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(154, 94);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(201, 20);
            this.txt_Address.TabIndex = 2;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(154, 123);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(201, 20);
            this.txt_City.TabIndex = 3;
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(154, 153);
            this.txt_State.MaxLength = 2;
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(63, 20);
            this.txt_State.TabIndex = 4;
            // 
            // txt_Zip
            // 
            this.txt_Zip.Location = new System.Drawing.Point(154, 182);
            this.txt_Zip.MaxLength = 5;
            this.txt_Zip.Name = "txt_Zip";
            this.txt_Zip.Size = new System.Drawing.Size(100, 20);
            this.txt_Zip.TabIndex = 5;
            // 
            // txt_ZipPlus4
            // 
            this.txt_ZipPlus4.Location = new System.Drawing.Point(154, 208);
            this.txt_ZipPlus4.MaxLength = 4;
            this.txt_ZipPlus4.Name = "txt_ZipPlus4";
            this.txt_ZipPlus4.Size = new System.Drawing.Size(100, 20);
            this.txt_ZipPlus4.TabIndex = 6;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(398, 236);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 17;
            this.Save_btn.Text = "Add";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click +=  new System.EventHandler(this.Save_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(281, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick +=  new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(503, 236);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 19;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click +=  new System.EventHandler(this.Update_btn_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(31, 13);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 20;
            this.lbl_ID.Text = "ID";
            // 
            // txtB_ID
            // 
            this.txtB_ID.Location = new System.Drawing.Point(154, 5);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.ReadOnly = true;
            this.txtB_ID.Size = new System.Drawing.Size(100, 20);
            this.txtB_ID.TabIndex = 21;
            this.txtB_ID.TabStop = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(154, 239);
            this.txt_Phone.Mask = "(999) 000-0000";
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(85, 20);
            this.txt_Phone.TabIndex = 22;
            // 
            // TLMownerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 308);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txtB_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.txt_ZipPlus4);
            this.Controls.Add(this.txt_Zip);
            this.Controls.Add(this.txt_State);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Zip_Plus4);
            this.Controls.Add(this.lbl_Zip);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.Exit_btn);
            this.Icon = ((System.Drawing.Icon ) (resources.GetObject("$this.Icon")));
            this.Name = "TLMownerForm";
            this.Text = "Add Owner";
            (( System.ComponentModel.ISupportInitialize )(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button  Exit_btn;
		private System.Windows.Forms.Label   lbl_LastName;
		private System.Windows.Forms.Label   lbl_FirstName;
		private System.Windows.Forms.Label   lbl_Address;
		private System.Windows.Forms.Label   lbl_City;
		private System.Windows.Forms.Label   lbl_State;
		private System.Windows.Forms.Label   lbl_Zip;
		private System.Windows.Forms.Label   lbl_Zip_Plus4;
		private System.Windows.Forms.Label   lbl_Phone;
		private System.Windows.Forms.TextBox   txt_LastName;
		private System.Windows.Forms.TextBox   txt_FirstName;
		private System.Windows.Forms.TextBox   txt_Address;
		private System.Windows.Forms.TextBox   txt_City;
		private System.Windows.Forms.TextBox   txt_State;
		private System.Windows.Forms.TextBox   txt_Zip;
		private System.Windows.Forms.TextBox   txt_ZipPlus4;
		private System.Windows.Forms.Button   Save_btn;
		private System.Windows.Forms.DataGridView   dataGridView1;
		private System.Windows.Forms.Button   Update_btn;
		private System.Windows.Forms.Label   lbl_ID;
		private System.Windows.Forms.TextBox   txtB_ID;
		private System.Windows.Forms.MaskedTextBox   txt_Phone;

}
}