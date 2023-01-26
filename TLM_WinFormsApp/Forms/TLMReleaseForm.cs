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
    public partial class TLMReleaseForm : Form
    {
        public TLMReleaseForm()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(Object  sender, EventArgs  e)
        {
            //
            // converting chkBx_Title to proper format for MySql DB
            //
            String   vTitle;
            if (chkBx_Title.Text == "1")
            {
                vTitle = "1";
            }
            else
            {
                vTitle = "0";
            }
            int nTitle = Int32.Parse(vTitle);
            //
            // converting OnLot DateTime to proper format for MySql DB
            //
            DateTime   date2 = DateTime.Parse(this.txtBx_OnLot.Text);
            DateTime date1 = Convert.ToDateTime(date2);
            String   vOnLot = date1.ToString("yyyy-MM-dd");
            //
            // converting Released DateTime to proper format for MySql DB
            //
            DateTime   date4 = DateTime.Parse(this.txtBx_Released.Text);
            DateTime date3 = Convert.ToDateTime(date4);
            String   vReleased = date3.ToString("yyyy-MM-dd");
            //
            //	converting AmountDue and AmountPaid to proper format for MySql DB
            //
            double dAmountDue = Convert.ToDouble(this.txtBx_AmountDue.Text);
            double dAmountPaid = Convert.ToDouble(this.txtBx_AmountPaid.Text);
            //
            String   query = "INSERT INTO tlm_transact " +
                "SET " +
                "VIN = '" + this.txtBx_VIN.Text + "', " +
                "Make = '" + this.txtBx_Make.Text + "', " +
                "Model = '" + this.txtBx_Model.Text + "', " +
                "Year = '" + this.txtBx_Year.Text + "', " +
                "Color = '" + this.txtBx_Color.Text + "', " +
                "OnLot = '" + vOnLot + "', " +
                "Reason = '" + this.txtBx_Reason.Text + "', " +
                "Title = '" + nTitle + "', " +
                "Released = '" + vReleased + "', " +
                "How_released = '" + this.txtBx_HowReleased.Text + "', " +
                "Last_name = '" + this.txtBx_LastName.Text + "', " +
                "First_name = '" + this.txtBx_FirstName.Text + "', " +
                "AmountDue = '" + dAmountDue + "', " +
                "AmountPaid = '" + dAmountPaid + "';";
            //
            int result = TLM_Utils.save_Data(query);
            if (result == 0) { MessageBox.Show("Data Saved!"); }
        }

        private void docPrint_PrintPage(Object  sender, System.Drawing.Printing.PrintPageEventArgs  e)
        {

            //e.Graphics.DrawImageUnscaled(Image  "berts.jpg", 30, 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 60, 90, 700, 90);

            String   strDisplay = "Tow Low Management";
            System.Drawing.Font   fntString = new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString, Brushes.Black, 280, 100);
            strDisplay = "Vehicle Release";
            System.Drawing.Font   fntString3 = new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString3, Brushes.Black, 320, 150);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 60, 184, 700, 184);

            System.Drawing.Font   fntString1 = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
            System.Drawing.Font   fntString2 = new System.Drawing.Font("Times New Roman", 10, FontStyle.Regular);

            e.Graphics.DrawString("VIN: ", fntString1, Brushes.Black, 100, 260);
            e.Graphics.DrawString(txtBx_VIN.Text, fntString2, Brushes.Black, 260, 260);

            e.Graphics.DrawString("Make: ", fntString1, Brushes.Black, 100, 280);
            e.Graphics.DrawString(txtBx_Make.Text, fntString2, Brushes.Black, 260, 280);

            e.Graphics.DrawString("Model: ", fntString1, Brushes.Black, 100, 300);
            e.Graphics.DrawString(txtBx_Model.Text, fntString2, Brushes.Black, 260, 300);

            e.Graphics.DrawString("Year: ", fntString1, Brushes.Black, 100, 320);
            e.Graphics.DrawString(txtBx_Year.Text, fntString2, Brushes.Black, 260, 320);

            e.Graphics.DrawString("Color: ", fntString1, Brushes.Black, 100, 340);
            e.Graphics.DrawString(txtBx_Color.Text, fntString2, Brushes.Black, 260, 340);

            e.Graphics.DrawString("On Lot: ", fntString1, Brushes.Black, 100, 360);
            e.Graphics.DrawString(txtBx_OnLot.Text, fntString2, Brushes.Black, 260, 360);

            e.Graphics.DrawString("Reason: ", fntString1, Brushes.Black, 100, 380);
            e.Graphics.DrawString(txtBx_Reason.Text, fntString2, Brushes.Black, 260, 380);

            e.Graphics.DrawString("Title: ", fntString1, Brushes.Black, 100, 400);
            e.Graphics.DrawString(chkBx_Title.Text, fntString2, Brushes.Black, 260, 400);

            e.Graphics.DrawString("Released: ", fntString1, Brushes.Black, 100, 420);
            e.Graphics.DrawString(txtBx_Released.Text, fntString2, Brushes.Black, 260, 420);

            e.Graphics.DrawString("How Released: ", fntString1, Brushes.Black, 100, 440);
            e.Graphics.DrawString(txtBx_HowReleased.Text, fntString2, Brushes.Black, 260, 440);

            e.Graphics.DrawString("Last Name: ", fntString1, Brushes.Black, 100, 460);
            e.Graphics.DrawString(txtBx_LastName.Text, fntString2, Brushes.Black, 260, 460);

            e.Graphics.DrawString("First Name: ", fntString1, Brushes.Black, 100, 480);
            e.Graphics.DrawString(txtBx_FirstName.Text, fntString2, Brushes.Black, 260, 480);

            e.Graphics.DrawString("Amount Due: ", fntString1, Brushes.Black, 100, 500);
            e.Graphics.DrawString(txtBx_AmountDue.Text, fntString2, Brushes.Black, 260, 500);

            e.Graphics.DrawString("Amount Paid: ", fntString1, Brushes.Black, 100, 520);
            e.Graphics.DrawString(txtBx_AmountPaid.Text, fntString2, Brushes.Black, 260, 520);
        }

        private void printToolStripMenuItem_Click(System.Object  sender, System.EventArgs  e)
        {
            if (dlgPrint.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                docPrint.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(System.Object  sender, System.EventArgs  e)
        {
            dlgPrintPreview.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(System.Object  sender, System.EventArgs  e)
        {
            Close();
        }

    }
}
