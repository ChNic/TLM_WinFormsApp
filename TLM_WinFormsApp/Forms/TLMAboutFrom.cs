using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLM_WinFormsApp
{
    public partial class TLMAboutFrom : Form
    {
        public TLMAboutFrom()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
