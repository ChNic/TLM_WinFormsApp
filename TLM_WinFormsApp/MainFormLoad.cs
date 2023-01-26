using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLMWinFormsLibrary;

namespace TLM_WinFormsApp
{
    internal class MainFormLoadCS : TLM_MainForm
    {

        public static void MainFormLoad()
        {
            // Load main Window
            String query = ("SELECT id,VIN, Make, Model, Year, Color, OnLot, c.lot_id, lot, Reason, Title, Released, How_released, First_name, Last_name, o.O_id, AmountDue FROM towlot.tlm_car AS c LEFT JOIN towlot.tlm_owner AS o ON c.Owner_id = o.O_id LEFT JOIN towlot.tlm_lot AS l ON c.lot_id = l.lot_id ORDER BY c.id ASC ;");
            TLM_Utils.CalculateAmountDue();
            TLM_Utils.load_Table(query, dataGridView1);
        }

    }
}
