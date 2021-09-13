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


        public DataSet GetSubTopicID()
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = "SELECT sub_topicID as Code, sub_topic_title as [Desc] from tbl_subtopic";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }

        public bool CRUDSub_question ( string rec_id ,  string sub_topicID , string question, string option1, string option2 , string option3, string option4, string answer, string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDSub_question", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@sub_topicID", sub_topicID);
            cmd.Parameters.AddWithValue("@question", question);
            cmd.Parameters.AddWithValue("@option1", option1);
            cmd.Parameters.AddWithValue("@option2", option2);
            cmd.Parameters.AddWithValue("@option3", option3);
            cmd.Parameters.AddWithValue("@option4", option4);
            cmd.Parameters.AddWithValue("@answer", answer);
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
