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
    /// 
    /// </summary>
    public class OwnerModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int VehicleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public static void LoadOwnerDataGrid(DataGridView view)
        {
            Utils.LoadDataGridwithStoredProcedure("towlot2", "spOwner_Get", view);
        }
    }
}
