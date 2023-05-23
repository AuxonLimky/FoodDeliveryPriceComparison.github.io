using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using Assignment.LinkData;
using Google.Cloud.Firestore;

namespace Assignment.Admin
{
    public partial class UserManageDetails : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;
        String PageID;
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");
            PageID = Request.Params["id"];

            if (!IsPostBack)
            {
                displayuserdata();
            }
        }

        async void displayuserdata()
        {

            DocumentReference docref = firestoredatabase.Collection("Member").Document(PageID);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                MemberLinkData Username = snap.ConvertTo<MemberLinkData>();
                memberusername.Text = Username.user_Name;
                memberemail.Text = Username.user_Email;
            }
        }

        protected void memberupdate_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        async void UpdateUserData()
        {
            string updatusername = memberusername.Text;
            string updateuseremail = memberemail.Text;

            DocumentReference docref = firestoredatabase.Collection("Member").Document(PageID);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "user_Name",updatusername},
                { "user_Email",updateuseremail},
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
            Response.Redirect("ManageUser.aspx");
        }

        protected void memberdel_Click(object sender, EventArgs e)
        {
            DocumentReference docref = firestoredatabase.Collection("Member").Document(PageID);
            docref.DeleteAsync();
            MessageBox.Show("Done");
            Response.Redirect("ManageUser.aspx");
        }

        protected void memberback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageUser.aspx");
        }

    }
}