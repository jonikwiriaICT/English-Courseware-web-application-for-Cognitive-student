using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.HtmlControls;

public partial class StudentDashboard : System.Web.UI.Page
{
    SysAdminModel objAdm = new SysAdminModel();
    public int mark = 0;

    SqlConnection con;
    int CurrentPage;
    string sqlconn;
    private void DisplaySuccess(String sMessage)
    {
        try
        {
            (this.Master as CourseWareMaster).DisplayMessage(sMessage, CourseWareMaster.MsgType.Success);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }
    private void DisplayError(String sMessage)
    {
        try
        {
            (this.Master as CourseWareMaster).DisplayMessage(sMessage, CourseWareMaster.MsgType.Error);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }

    private void DisplayWarning(String sMessage)
    {
        try
        {
            (this.Master as CourseWareMaster).DisplayMessage(sMessage, CourseWareMaster.MsgType.Warning);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           if (Request.QueryString ["ID"].ToString()!=null)
            {
                if (!this.IsPostBack)
                {
                    
                    BindDatList(int.Parse (Request.QueryString["ID"].ToString()));
                    ViewState["PageCount"] = 0;
                }
                CurrentPage = (int)ViewState["PageCount"];
            }
            else
            {
                Response.Redirect("Error");
            }
        }
        catch(Exception ex)
        {

        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        try
        {
            objAdm.CloseConnection();
        }
        catch(Exception ex)
        {

        }
    }
    
    protected void Page_Init(object sender, EventArgs e)
    {

    }
   
    private void LoadSubTopic(string topicID)
    {
        try
        {
            DataSet ds = objAdm.GetSubTopic(topicID);

        }
        catch(Exception ex)
        {

        }
    }

    private void connection()
    {
        sqlconn = ConfigurationManager.ConnectionStrings["mssqlConnectionString"].ConnectionString;
        con = new SqlConnection(sqlconn);

    }
    public string RecID()
    {
        try
        {
            string username = ((CourseWareMaster)this.Master).RecID;
            return username;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    private void BindDatList(int RecID)
    {
        connection();
        SqlCommand com = new SqlCommand("GetQuestion", con);
      
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@RecID", RecID);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        con.Open();
        da.Fill(dt);
        con.Close();
        DataListPaging(dt);


    }
    private void DataListPaging(DataTable dt)
    {
        //creating object of PagedDataSource;  


        PagedDataSource PD = new PagedDataSource();
        PD.DataSource = dt.DefaultView;
        PD.PageSize = 1;
        PD.AllowPaging = true;
        PD.CurrentPageIndex = CurrentPage;
        Button2.Enabled = !PD.IsFirstPage;
        Button3.Enabled = !PD.IsLastPage;
        ViewState["TotalCount"] = PD.PageCount;
        lstQuestion.DataSource = PD;
        lstQuestion.DataBind();
        ViewState["PagedDataSurce"] = dt;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CurrentPage = (int)ViewState["PageCount"];
        CurrentPage -= 1;
        ViewState["PageCount"] = CurrentPage;

        DataListPaging((DataTable)ViewState["PagedDataSurce"]);

    }
    private void MoveForward()
    {
        CurrentPage = (int)ViewState["PageCount"];
        CurrentPage += 1;
        ViewState["PageCount"] = CurrentPage;
        DataListPaging((DataTable)ViewState["PagedDataSurce"]);
    }
   

    protected void RadioCheckChanged(object sender, EventArgs e)
    {
        try
        {
            foreach (ListViewItem itemRow in this.lstQuestion.Items)
            {
                var radioBtn1 = (RadioButton)itemRow.FindControl("RadioButton1");
                var radioBtn2 = (RadioButton)itemRow.FindControl("RadioButton2");
                var radioBtn3 = (RadioButton)itemRow.FindControl("RadioButton3");
                var radioBtn4 = (RadioButton)itemRow.FindControl("RadioButton4");
                var Answer = (HiddenField)itemRow.FindControl("lblAnswer");
                var QuestionID = (HiddenField)itemRow.FindControl("HDQuestions");
               
                if (radioBtn1.Checked == true)
                    {

                    if (Answer.Value != radioBtn1.Text)
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "0", "INSERT") == true)
                        {
                            DisplayError("You selected the wrong answer.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }
                    }
                    else
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "1", "INSERT") == true)
                        {
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                            MoveForward();
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }

                    }
                }
                else if (radioBtn2.Checked == true)
                {
                    if (Answer.Value != radioBtn2.Text)
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "0", "INSERT") == true)
                        {
                            DisplayError("You selected the wrong answer.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }

                    }
                    else
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "1", "INSERT") == true)
                        {
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                            MoveForward();
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }
                    }

                }
                else if (radioBtn3.Checked == true)
                {
                    if (Answer.Value != radioBtn3.Text)
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "0", "INSERT") == true)
                        {
                            DisplayError("You selected the wrong answer.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }
                    }
                    else
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "1", "INSERT") == true)
                        {
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                            MoveForward();
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }
                    }
                }
                else if (radioBtn4.Checked == true)
                {
                    if (Answer.Value != radioBtn4.Text)
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "0", "INSERT") == true)
                        {
                            DisplayError("You selected the wrong answer.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }
                    }
                    else
                    {
                        if (objAdm.CRUDTraquestion("1", RecID(), QuestionID.Value, "1", "INSERT") == true)
                        {
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                            MoveForward();
                            DisplaySuccess("Congratulation! You have successfully passed the question.");
                        }
                        else
                        {
                            DisplayError("Your answer is correct but there was problem saving your record.");
                        }

                    }
                }
                else
                {
                    DisplaySuccess("Congratulation! You have successfully passed the question.");
                }
            }           
        }
        catch(Exception ex)
        {

        }
    }
}