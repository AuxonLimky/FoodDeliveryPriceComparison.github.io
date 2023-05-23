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
    public partial class LoginDesign : System.Web.UI.Page
    {
        AssignmentDBDataContext db = new AssignmentDBDataContext();
        FirestoreDb firestoredatabase;


        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");
        }

        //protected async void login1_Authenticate(object sender, AuthenticateEventArgs e)
        //{
        //    if (Page.IsValid)
        //    {
        //        Query Qref = firestoredatabase.Collection("Member");
        //        QuerySnapshot snap = await Qref.GetSnapshotAsync();

        //        foreach (DocumentSnapshot docsnap in snap)
        //        {
        //            MemberLinkData userdata = docsnap.ConvertTo<MemberLinkData>();

        //            if (docsnap.Exists)
        //            {
        //                if (login1.UserName == userdata.user_Name)
        //                {
        //                    if (Security.GetHash(login1.Password) == userdata.user_Password)
        //                    {
        //                        e.Authenticated = true;
        //                        Security.LoginUser(docsnap.Id, userdata.UserRole, login1.RememberMeSet);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Your User ID or Password Invalid");
        //                        return;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        protected async void btnlogin_Click(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    string username = txtname.Text;
            //    string password = txtpassword.Text;
            //    bool rememberMe = chkRememberMe.Checked;

            //    //Login the user
            //    //Calculate the has, and find entry from DB
            //    User u = db.Users.SingleOrDefault(
            //        x => x.user_Name == username &&
            //             x.user_Password == password
            //             );


            //    if (u != null)
            //    {
            //        Session["userID"] = u.userID;
            //        Security.LoginUser(u.user_Name, u.Role, rememberMe);
            //        cvNotMatched.IsValid = true;

            //    }
            //    else
            //    {
            //        cvNotMatched.IsValid = false;
            //    }

            //}

            if (Page.IsValid)
            {
                Query Qref = firestoredatabase.Collection("Member");
                QuerySnapshot snap = await Qref.GetSnapshotAsync();

                string username = txtname.Text;
                string password = txtpassword.Text;
                bool rememberme = chkRememberMe.Checked;

                foreach (DocumentSnapshot docsnap in snap)
                {
                    MemberLinkData userdata = docsnap.ConvertTo<MemberLinkData>();

                    if (docsnap.Exists)
                    {
                        if (username == userdata.user_Name)
                        {
                            if (Security.GetHash(password) == userdata.user_Password)
                            {

                                cvNotMatched.IsValid = true;
                                //e.Authenticated = true;
                                Security.LoginUser(docsnap.Id, userdata.UserRole, rememberme);
                                //Response.Redirect("ProductList Testing.aspx");
                            }
                            else
                            {
                                MessageBox.Show("Your User ID or Password Invalid");
                                return;
                            }
                        }
                    }
                }
            }
        }


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    GetAllData_Of_A_Document();
        //}

        //void Add_Document_with_AutoID()
        //{
        //    CollectionReference coll = database.Collection("Add_Document_with_AutoID");
        //    Dictionary<string, object> data1 = new Dictionary<string, object>()
        //    {
        //       { "FirstName", "tacv" },
        //       { "LastName", "amazing codeverse" },
        //       { "PhoneNumber", 123456789 },
        //    };
        //    coll.AddAsync(data1);
        //    MessageBox.Show("data added successfully");
        //}

        //void Add_Document_with_CustomID()
        //{
        //    DocumentReference DOC = database.Collection("Add_Document_with_CustomID").Document("myDoc");
        //    Dictionary<string, object> data1 = new Dictionary<string, object>()
        //    {
        //       { "FirstName", "tacv" },
        //       { "LastName", "amazing codeverse" },
        //       { "PhoneNumber", 123456789 },
        //    };
        //    DOC.SetAsync(data1);
        //    MessageBox.Show("data added successfully");
        //}

        //void Add_Array()
        //{
        //    DocumentReference DOC = database.Collection("Add_Array").Document("myDoc");
        //    Dictionary<string, object> data1 = new Dictionary<string, object>();

        //    ArrayList array = new ArrayList();
        //    array.Add(123);
        //    array.Add("name");
        //    array.Add(true);

        //    data1.Add("My Array",array);
        //    DOC.SetAsync(data1);
        //    MessageBox.Show("data added successfully");
        //}
        //void Add_ListOfObjects()
        //{
        //    DocumentReference DOC = database.Collection("Add_ListOfObjects").Document("myDoc");
        //    Dictionary<string, object> MainData = new Dictionary<string, object>();
        //    Dictionary<string, object> List1 = new Dictionary<string, object>()
        //    {
        //       { "FirstName", "tacv" },
        //       { "LastName", "amazing codeverse" },
        //       { "PhoneNumber", 123456789 },
        //    };

        //    MainData.Add("MyList", List1);
        //    DOC.SetAsync(MainData);
        //    MessageBox.Show("data added successfully");
        //}

        //void Add_Multiple_SetsofData()
        //{
        //    CollectionReference coll = database.Collection("Add_Multiple_SetsofData");
        //    Dictionary<string, object> data1 = new Dictionary<string, object>()
        //    {
        //       { "FirstName", "tacv" },
        //       { "LastName", "amazing codeverse" },
        //       { "PhoneNumber", 123456789 },
        //       //array added
        //       //list added
        //    };

        //    ArrayList array = new ArrayList();
        //    array.Add(123);
        //    array.Add("name");
        //    array.Add(true);

        //    data1.Add("MyArray", array);

        //    Dictionary<string, object> List1 = new Dictionary<string, object>()
        //    {
        //       { "FirstName", "tacv" },
        //       { "LastName", "amazing codeverse" },
        //       { "PhoneNumber", 123456789 },
        //    };

        //    data1.Add("MyList",List1);

        //    coll.AddAsync(data1);
        //    MessageBox.Show("data added successfully");
        //}

        ////GET

        //async void GetAllData_Of_A_Document()
        //{
        //    DocumentReference docref = database.Collection("MyCities").Document("Karachi");
        //    DocumentSnapshot snap = await docref.GetSnapshotAsync();

        //    if(snap.Exists)
        //    {
        //        Dictionary<string, object> city = snap.ToDictionary();
        //        foreach(var item in city)
        //        {
        //            Label1.Text += string.Format("{0} : {1}\n", item.Key, item.Value);
        //        }
        //    }
        //}

        //async void GetSpecificData_Of_A_Document()
        //{
        //    DocumentReference docref = database.Collection("MyCities").Document("Karachi");
        //    DocumentSnapshot snap = await docref.GetSnapshotAsync();

        //    if (snap.Exists)
        //    {

        //    }
        //}

    }
    }
