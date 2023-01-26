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
    public partial class TLMAddRateForm : Form
    {
        public TLMAddRateForm()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(System.Object  sender, System.EventArgs  e)
        {
            Close();
        }

        private void Save_btn_Click(System.Object  sender, System.EventArgs  e)
        {

            String   query = ("UPDATE towlot.tlm_rate SET rate = '" + this.txt_Rate.Text + "';");

            if (this.txt_Rate.Text.Length > 0)
            {
                TLM_Utils.save_Data(query);
                MessageBox.Show("Data Saved!");
            }
            else
            {
                MessageBox.Show("No Rate entered");
            }
        }

        private void TLMAddRateForm_Load(System.Object  sender, System.EventArgs  e)
        {
            String   query = "SELECT * FROM tlm_rate;";
            Decimal vRate = TLM_Utils.getRate(query);
            this.txt_Rate.Text = Convert.ToString(vRate);
        }

    }
}
