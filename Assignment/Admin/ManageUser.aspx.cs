using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.LinkData;
using Google.Cloud.Firestore;

namespace Assignment.Admin
{
    public partial class ManageUser : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");

            GetAllDocuments("Member");
        }

        async void GetAllDocuments(string nameOfCollection)
        {

            Query cityque = firestoredatabase.Collection(nameOfCollection);
            QuerySnapshot snap = await cityque.GetSnapshotAsync();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("user_Name");
            dt.Columns.Add("user_Email");
            dt.Columns.Add("user_Password");
            dt.Columns.Add("UserRole");
            dt.Columns.Add("Manage");

            foreach (DocumentSnapshot docsnap in snap)
            {
                MemberLinkData Username = docsnap.ConvertTo<MemberLinkData>();

                if (docsnap.Exists)
                {
                    dt.Rows.Add(docsnap.Id, Username.user_Name, Username.user_Email, Username.user_Password, Username.UserRole, "id=" + docsnap.Id);
                    gv.DataSource = dt;
                }
                gv.DataBind();
            }
        }
        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void userupdate_Click(object sender, EventArgs e)
        {
            string arg = (sender as Button).CommandArgument;
            Response.Redirect("UserManageDetails.aspx?" + arg, false);
        }

    }
}