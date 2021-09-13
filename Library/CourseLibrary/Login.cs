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
        public string Username = string.Empty;
        public string RecID = string.Empty;
        public string FirstName = string.Empty;
        public string MiddleName = string.Empty;
        public string LastName = string.Empty;
        public string UserPassword = string.Empty;
        public bool GetStudentProfile(string username, string sPassword)
        {
            try
            {
                string sPasswordDB = string.Empty;
                DataSet ds = new DataSet();
                string sSQL = "select * from qryStudent where UserName=@UserName ";
                SqlCommand objCmd = new SqlCommand();
                objCmd.Parameters.Clear();
                objCmd.Parameters.AddWithValue("@UserName", username);
                objCmd.CommandText = sSQL;
                ds = ExecuteDataSet(objCmd);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    ErrorMessage = "Invalid User. Contact Administrator.";
                    return false;
                }
                sPasswordDB = ds.Tables[0].Rows[0]["UserPassword"].ToString();
                if (sPasswordDB.Trim() == string.Empty)
                {
                    ErrorMessage = "Password Not found in the database.";
                }
                else
                {
                   
                    if (sPassword != sPasswordDB)
                    {
                        ErrorMessage = "Invalid password.";
                        return false;
                    }
                }
                UserPassword = sPasswordDB;
                RecID = ds.Tables[0].Rows[0]["RecID"].ToString();
                FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                MiddleName = ds.Tables[0].Rows[0]["MiddleName"].ToString();
                LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                username  = ds.Tables[0].Rows[0]["UserName"].ToString();

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = "No Login Connection.";
                return false;
            }
        }

        public bool GetAdministrator(string username, string sPassword)
        {
            try
            {
                string sPasswordDB = string.Empty;
                DataSet ds = new DataSet();
                string sSQL = "select * from tbl_administrator where username=@UserName ";
                SqlCommand objCmd = new SqlCommand();
                objCmd.Parameters.Clear();
                objCmd.Parameters.AddWithValue("@UserName", username);
                objCmd.CommandText = sSQL;
                ds = ExecuteDataSet(objCmd);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    ErrorMessage = "Invalid User. Contact Administrator.";
                    return false;
                }
                sPasswordDB = ds.Tables[0].Rows[0]["userpassword"].ToString();
                if (sPasswordDB.Trim() == string.Empty)
                {
                    ErrorMessage = "Password Not found in the database.";
                }
                else
                {

                    if (sPassword != sPasswordDB)
                    {
                        ErrorMessage = "Invalid password.";
                        return false;
                    }
                }
                UserPassword = sPasswordDB;
                RecID = ds.Tables[0].Rows[0]["rec_id"].ToString();
                FirstName = ds.Tables[0].Rows[0]["firstname"].ToString();
                MiddleName = ds.Tables[0].Rows[0]["middlename"].ToString();
                LastName = ds.Tables[0].Rows[0]["lastname"].ToString();
                username = ds.Tables[0].Rows[0]["username"].ToString();

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = "No Login Connection.";
                return false;
            }
        }

    }
}