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
        public bool CRUDStudent( string rec_id, string firstname, string middlename,string lastname , string username, string  userpassword, string StatementType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CRUDStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rec_id", rec_id);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@middlename", middlename);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@userpassword", userpassword);
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
