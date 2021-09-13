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

        
        public DataSet GetTopicID()
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = "SELECT topic_id as [Code], topic_title as [Desc] FROM tbl_topic";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }

        public bool CRUDSubtopic (string topic_id , string rec_id , string sub_topic_title,string sub_topic_description, string profile_pic1, string profile_pic2, string profile_pic3, string profile_pic4 ,string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDSubtopic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@topic_id", topic_id);
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@sub_topic_title", sub_topic_title);
            cmd.Parameters.AddWithValue("@sub_topic_description", sub_topic_description);
            cmd.Parameters.AddWithValue("@profile_pic1", profile_pic1);
            cmd.Parameters.AddWithValue("@profile_pic2", profile_pic2);
            cmd.Parameters.AddWithValue("@profile_pic3", profile_pic3);
            cmd.Parameters.AddWithValue("@profile_pic4", profile_pic4);
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
