using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace ModelLibrary
{
    /// <summary>
    /// ///
    /// </summary>
    public class LotModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Lot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="box"></param>
        public static void LoadLotComboBox(ComboBox box)
        {
            Utils.LoadComboBoxWithStoredProcedures("towlot2", "spLot_Get_All", box, "Lot");
        }
    }
}
