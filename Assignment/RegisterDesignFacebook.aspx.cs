using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;
using System.Buffers.Text;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Assignment.LinkData;

namespace Assignment
{
    public partial class RegisterDesignFacebook : System.Web.UI.Page
    {
        AssignmentDBDataContext db = new AssignmentDBDataContext();
        string randomCode;
        FirestoreDb firestoredatabase;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
        }

        //protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    string username = args.Value;

        //    if (db.Users.Any(s => s.user_Name == username))
        //    {
        //        args.IsValid = false;
        //    }
        //}

        protected async void btnregister_Click(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    String userName = txtUsername.Text;
            //    String password = txtpassword.Text;
            //    String email = txtemail.Text;

            //    Member m = new Member
            //    {
            //        user_Name = userName,
            //        user_Email = email,
            //        user_Password = password,
            //        registerDate = DateTime.Now

            //    };

            //    db.Members.InsertOnSubmit(m);
            //    db.SubmitChanges();

            //    Response.Redirect("LoginDesign.aspx");
            //}

            if (Page.IsValid)
            {
                string userName = txtUsername.Text;
                string password = txtpassword.Text;
                string email = txtemail.Text;

                Query Qref = firestoredatabase.Collection("Member");
                QuerySnapshot snap = await Qref.GetSnapshotAsync();

                foreach (DocumentSnapshot docsnap in snap)
                {
                    MemberLinkData userdata = docsnap.ConvertTo<MemberLinkData>();
                    if (docsnap.Exists)
                    {
                        if (userName == userdata.user_Name)
                        {
                            MessageBox.Show("Username Used, Please Try Other UserName");
                            return;
                        }

                        else if (email == userdata.user_Email)
                        {
                            MessageBox.Show("Email Used, Please Try Other Email Address");
                            return;
                        }
                    }
                }

                CollectionReference collection = firestoredatabase.Collection("Member");
                Dictionary<string, object> storeuserdata = new Dictionary<string, object>()
                {
                    {"user_ID", randomCode},
                    {"user_Name", userName },
                    {"user_Password",Security.GetHash(password) },
                    {"user_Email", email },
                    {"registerDate", DateTime.UtcNow},
                    {"UserRole","Member"},
                };

                await collection.AddAsync(storeuserdata);
                Response.Redirect("LoginDesign.aspx");

            }

        }

        //protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    string useremail = args.Value;

        //    if (db.Users.Any(s => s.user_Email == useremail))
        //    {
        //        args.IsValid = false;
        //    }
        //}
    }
}