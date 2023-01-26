using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLMWinFormsLibrary;

namespace TLM_WinFormsApp
{
    public partial class TLMOnerForm  : Form
    {
        public TLMOnerForm()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            String   query = ("SELECT * FROM towlot.tlm_owner;");

            TLM_Utils.load_Table(query, dataGridView1);
        }

        private void Exit_button_Click(System.Object  sender, System.EventArgs  e)
        {
            Close();
        }

        private void Save_btn_Click(System.Object  sender, System.EventArgs  e)
        {

            String  query = ("INSERT INTO towlot.tlm_owner(Last_name,First_name,Address,City,State,Zip,Zip_plus,Phone) VALUES('" + this.txt_LastName.Text + "', '" + this.txt_FirstName.Text + "', '" + this.txt_Address.Text + "', '" + this.txt_City.Text + "', '" + this.txt_State.Text + "', '" + this.txt_Zip.Text + "', '" + this.txt_ZipPlus4.Text + "', '" + this.txt_Phone.Text + "');");

            TLM_Utils.save_Data(query);
            MessageBox.Show("Data Saved!");
        }

        private void Update_btn_Click(System.Object  sender, System.EventArgs  e)
        {
            if ((this.txt_LastName.Text) != "")
            {
                int ID = Int32.Parse(this.txtB_ID.Text);
                //int PH = Int32.Parse(this.txt_Phone.Text);
                //MessageBox.Show("ID= "+ ID +" Phone= "+ this.txt_Phone.Text);
                String   query = ("UPDATE towlot.tlm_owner SET O_id='" + ID + "', Last_name='" + this.txt_LastName.Text + "', First_name='" + this.txt_FirstName.Text + "', Address='" + this.txt_Address.Text + "', City='" + this.txt_City.Text + "', State='" + this.txt_State.Text + "', Zip='" + this.txt_Zip.Text + "', Zip_plus='" + this.txt_ZipPlus4.Text + "', Phone='" + this.txt_Phone.Text + "' WHERE O_id='" + ID + "';");
                //String  query = ("UPDATE towlot.tlm_owner SET O_id='"+ID+"', Last_name='"+ this.txt_LastName.Text +"', First_name='"+ this.txt_FirstName.Text +"', Address=this.'"+ txt_Address.Text +"', City='"+ this.txt_City.Text +"', State='"+ this.txt_State.Text +"', Zip='"+ this.txt_Zip.Text +"', Zip_plus='"+ this.txt_ZipPlus4.Text +"', Phone='"+ this.txt_Phone.Text +"' WHERE O_id='Double.Parse(this.txtB_ID.Text)';");

                TLM_Utils.save_Data(query);
                MessageBox.Show("Data Saved!");
            }
            else
            {
                MessageBox.Show("No data entered to update.");
            }
        }

        private void dataGridView1_CellDoubleClick(System.Object  sender, System.Windows.Forms.DataGridViewCellEventArgs  e)
        {
            // int Row = e.RowIndex;
            this.txtB_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txt_LastName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txt_FirstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txt_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txt_City.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.txt_State.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.txt_Zip.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.txt_ZipPlus4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            this.txt_Phone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

    }
}
