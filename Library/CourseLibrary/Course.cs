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
    public partial class SysAdminModel:_Database
    {
        public bool CRUDCourse (string rec_id, string course_title,string course_desc,string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDCourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@course_title", course_title);
            cmd.Parameters.AddWithValue("@course_desc", course_desc);
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
