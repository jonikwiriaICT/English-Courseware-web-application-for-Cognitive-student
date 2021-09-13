using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CourseLibrary
{
    public partial class SysAdminModel: _Database
    {
        public int pageSize = 10;
        public int _TotalRowCount = 0;
        public string connectionstring = ConfigurationManager.ConnectionStrings["mssqlConnectionString"].ToString();
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mssqlConnectionString"].ToString());
        public DataTable PopulateData(int currentPage, string sParameterProcedure)
        {
            DataTable ds = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand(sParameterProcedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            int startRowNumber = ((currentPage - 1) * pageSize) + 1;
            cmd.Parameters.AddWithValue("@StartIndex", startRowNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);
            SqlParameter parTotalCount = new SqlParameter("@TotalCount", SqlDbType.Int);
            parTotalCount.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parTotalCount);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _TotalRowCount = Convert.ToInt32(parTotalCount.Value);
            con.Close();
            return ds;
        }
        public bool DeleteRecord(string rec_id, string tbl_name)
        {
            try
            {
                string sSQL = "DELETE FROM  " + tbl_name + "  WHERE  rec_id=@rec_id";
                SqlCommand objCmd = new SqlCommand();
                objCmd.CommandText = sSQL;
                objCmd.Parameters.Clear();
                objCmd.Parameters.AddWithValue("@rec_id", rec_id);
                if (ExecuteNonQuery(objCmd) <= 0)
                {
                    ErrorMessage = "Unable to delete transaction";
                    return false;
                }
                ErrorMessage = "Record successfully deleted.";
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.ToString();
                return false;
            }
        }
    }
}
