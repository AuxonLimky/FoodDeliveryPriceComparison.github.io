using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Google.Cloud.Firestore;
using System.Windows.Forms;
using System.Collections;
using Assignment.LinkData;


namespace Assignment
{
    public partial class AdminLoginDesign : System.Web.UI.Page
    {
        AssignmentDBDataContext db = new AssignmentDBDataContext();
        FirestoreDb firestoredatabase;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");
        }


        protected async void btnlogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Query Qref = firestoredatabase.Collection("Admin");
                QuerySnapshot snap = await Qref.GetSnapshotAsync();

                foreach (DocumentSnapshot docsnap in snap)
                {
                    string username = txtname.Text;
                    string password = txtpassword.Text;
                    bool rememberme = chkRememberMe.Checked;

                    AdminLinkData admindata = docsnap.ConvertTo<AdminLinkData>();

                    if (docsnap.Exists)
                    {


                        if (username == admindata.user_Name)
                        {
                            if (password == admindata.user_Password)
                            {
                                //Session["userID"] = admindata.userID;
                                cvNotMatched.IsValid = true;
                                Security.LoginUser(docsnap.Id, admindata.user_Role, rememberme);
                                Response.Redirect("Admin/AdminHome.aspx");                       
                            }
                            else
                            {
                                MessageBox.Show("Your ADMIN ID or Password Invalid");
                                return;
                            }
                        }
                    }

                }

            }


            }
        }
    }
