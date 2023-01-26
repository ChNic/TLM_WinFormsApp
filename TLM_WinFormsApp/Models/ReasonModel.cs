
using MySql.Data.MySqlClient;
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
    public class ReasonModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="box"></param>
        public static void LoadReasonComboBox(ComboBox box)
        {
            Utils.LoadComboBoxWithStoredProcedures("towlot2", "spReason_Get_All", box, "Reason");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="reason"></param>
        public static void ReasonInsertWithStoredProcedures(string db, string reason)
        {
            MySqlParameter[] pms = new MySqlParameter[1];
            pms[0] = new MySqlParameter("rea", MySqlDbType.VarChar);
            pms[0].Value = reason;
            try
            {
                string query = "spReason_Insert";
                Utils.Save_DataStoredProcedure(db, query, pms);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
                //MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="reason"></param>
        public static void ReasonGetAllWithStoredProcedures(string db, string reason)
        {
            MySqlParameter[] pms = new MySqlParameter[1];
            pms[0] = new MySqlParameter("rea", MySqlDbType.VarChar);
            pms[0].Value = reason;
            try
            {
                string query = "spReason_Get_All";
                Utils.Save_DataStoredProcedure(db, query, pms);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
                //MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="_reason"></param>
        public static void ReasonGetReasonWithStoredProcedure(string _query, string _reason)
        {
            // TODO:  Add Get Reason Info for a single reason.
        }
    }
}
