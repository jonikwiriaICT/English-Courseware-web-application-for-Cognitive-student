<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">

    static void RegisterRoutes(RouteCollection routes)
    {
        //first param is unique, second param is the expected url, thrid param is the actual file/page
        //general root menu

        routes.MapPageRoute("rten", "en", "~/Default.aspx");
        routes.MapPageRoute("rtIndex", "index", "~/Default.aspx");
        routes.MapPageRoute("rtRegister", "Register", "~/Register.aspx");
         routes.MapPageRoute("rtStudentDashboard", "Student-dashboard", "~/StudentDashboard.aspx");
          routes.MapPageRoute("rtSignin", "Signin", "~/Signin.aspx");
         routes.MapPageRoute("rtTopic", "Topic", "~/Topic.aspx");
       

        //Administrator
         routes.MapPageRoute("rtAdminSignIn", "Admin", "~/AdminSignIn.aspx");
          routes.MapPageRoute("rtAdminDashboard", "Dashboard", "~/Dashboard.aspx");
         routes.MapPageRoute("rtCourse", "Course", "~/Course.aspx");
         routes.MapPageRoute("rtTopics", "Topic", "~/Topic.aspx");
         routes.MapPageRoute("rtSubTopic", "Sub-Topic", "~/SubTopic.aspx");
         routes.MapPageRoute("rtQuestion", "Question", "~/Question.aspx");
        
        
       
        
        
        

























    }
    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        RegisterRoutes(RouteTable.Routes);
        //SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~/bin"));
    }
</script>
