using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;
using Assignment.LinkData;

namespace Assignment.Admin
{
    public partial class AdminProfile : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;
        String PageID;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestoredatabase = FirestoreDb.Create("auxon-fyp");

            if (!this.Page.User.Identity.IsAuthenticated)
            {
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                PageID = this.Page.User.Identity.Name;
                displayuserdata();
            }
        }

        async void displayuserdata()
        {
            DocumentReference docref = firestoredatabase.Collection("Admin").Document(PageID);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                AdminLinkData adminname = snap.ConvertTo<AdminLinkData>();
                Image1.ImageUrl = "data:image/Png;base64," + adminname.userID;
                txtAdminName.Text = adminname.user_Name;
                txtAdminRole.Text = adminname.user_Role;
                txtAdminGender.Text = adminname.user_Email;
            }
        }
    }
}