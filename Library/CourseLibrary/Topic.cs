using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using System.Data;
using System.Data.SqlClient;

namespace CourseLibrary
{
    public partial class SysAdminModel : _Database
    {

        public DataSet GetTopic()
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = "select * from qryTopic";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }
        public DataSet GetCourseID()
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = "SELECT course_id as [Code], course_title as [Desc] from tbl_course";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }
        public DataSet GetSubTopic(string topicID)
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = "select * from qrySubtopic";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }

        public bool CRUDTopic ( string rec_id, string course_id, string topic_title ,string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDTopic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@course_id", course_id);
            cmd.Parameters.AddWithValue("@topic_title", topic_title);
            cmd.Parameters.AddWithValue("@StatementType", StatementType);
            if (ExecuteNonQuery(cmd) <= 0)
            {
                ErrorMessage = "Unable to process transaction";
                return false;
            }
            ErrorMessage = "Record executed successfully .";
            return true;
        }
    }
}
