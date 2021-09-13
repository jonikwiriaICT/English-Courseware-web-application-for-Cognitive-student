using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using System.Data.SqlClient;
using System.Data;

namespace CourseLibrary
{
    public partial class SysAdminModel: _Database
    {


        public bool CRUDTraquestion( string rec_id, string student_id, string question_id, string answer, string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDTran_question", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@question_id", question_id);
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
