using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Assignment
{
    public class Global : System.Web.HttpApplication
    {
        public const string connectingString = @"
            Data Source = (LocalDB)\mssqllocaldb;
            AttachDbFilename=|DataDirectory|\AssignmentDB.mdf;
            Integrated Security=True
        ";

        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
            Security.ProcessRoles();
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Visitors"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Visitors"] = (int)Application["Visitors"] + 1;
            Application["VisitDateTime"] = DateTime.Now;

            AssignmentDBDataContext db = new AssignmentDBDataContext();
            Visitor v = new Visitor
            {
                Visit = Convert.ToDateTime(DateTime.Now),
            };
            db.Visitors.InsertOnSubmit(v);
            db.SubmitChanges();
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            /*HttpContext.Current.Response.Headers.Remove("Server");
            HttpContext.Current.Response.Headers.Remove("X-AspNetWebPages-Version");
            HttpContext.Current.Response.Headers.Remove("X-AspNet-Version");
            HttpContext.Current.Response.Headers.Remove("X-Powered-By");
            HttpContext.Current.Response.Headers.Remove("X-AspNetMvc-Version");*/
        }

            protected void Application_AuthenticateRequest(object sender, EventArgs e)
            {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
           
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}