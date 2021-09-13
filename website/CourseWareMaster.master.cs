using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseLibrary;
using System.Data;

public partial class CourseWareMaster : System.Web.UI.MasterPage
{
    SysAdminModel objAdm = new SysAdminModel();
   

    public string RecID
    {
        get
        {
            try
            {
                string sValue = string.Empty;

                if (string.IsNullOrEmpty(sValue) == true)
                {
                    sValue = Session["RecID"].ToString();
                }
                return sValue;
            }
            catch (Exception ex)
            {
                try
                {
                    return Session["RecID"].ToString();
                }
                catch (Exception ex2) { }
                return string.Empty;
            }
        }
    }
    public string UserName
    {
        get
        {
            try
            {
                string sValue = string.Empty;

                if (string.IsNullOrEmpty(sValue) == true)
                {
                    sValue = Session["audit_username"].ToString();
                }
                return sValue;
            }
            catch (Exception ex)
            {
                try
                {
                    return Session["audit_username"].ToString();
                }
                catch (Exception ex2) { }
                return string.Empty;
            }
        }
    }


    public enum MsgType
    {
        Error = 0,
        Success = 1,
        Warning = 2
    }
    public void DisplayMessage(String sMessage, MsgType type)
    {
        try
        {
            if (sMessage.Trim() == "")
            {
                pnlAlert.Visible = false;
            }
            else
            {
                lblMsg.Text = sMessage;
                if (type == MsgType.Success)
                {
                    pnlAlert.CssClass = "alert alert-success alert-dismissible";
                    spIcon.InnerHtml = "<i class='fa fa-check-circle-o'></i>";
                }
                else if (type == MsgType.Warning)
                {
                    pnlAlert.CssClass = "alert alert-warning alert-dismissible";
                    spIcon.InnerHtml = "<i class='fa fa-exclamation-triangle'></i>";
                }
                else
                {
                    pnlAlert.CssClass = "alert alert-danger alert-dismissible";
                    spIcon.InnerHtml = "<i class='fa fa-exclamation-circle'></i>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "displayMsg", "alert('" + sMessage + "');", true);
                }
                pnlAlert.Visible = true;
                //ClientScript.RegisterStartupScript(this.GetType(), "displayMsg", "alert('" + sMessage + "');", true);
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
            pnlAlert.Visible = true;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if(!this.IsPostBack)
            {
                lblUsername.Text = UserName;
                LoadTopic();
            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void SignOut(object sender, EventArgs e)
    {
        try
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("index");
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
    private void LoadTopic()
    {
        try
        {
            DataSet ds = objAdm.GetTopic();
            ListCourse.DataSource = ds;
            ListCourse.DataBind();
        }
        catch(Exception ex)
        {

        }
    }
}
