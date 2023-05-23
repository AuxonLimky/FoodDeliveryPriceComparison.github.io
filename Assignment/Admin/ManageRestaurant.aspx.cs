using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.LinkData;
using Button = System.Web.UI.WebControls.Button;
using Google.Cloud.Firestore;
using System.Data;

namespace Assignment.Admin
{
    public partial class ManageRestaurant : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");

            if (!Page.IsPostBack)
            {
                GetAllDocuments("Restaurant");
            }
        }

        async void GetAllDocuments(string nameOfCollection)
        {

            Query cityque = firestoredatabase.Collection(nameOfCollection);
            QuerySnapshot snap = await cityque.GetSnapshotAsync();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("resAddress");
            dt.Columns.Add("resName");
            dt.Columns.Add("resOperationHour");
            dt.Columns.Add("resImg");
            dt.Columns.Add("resPhoneNo");
            dt.Columns.Add("resRating");
            dt.Columns.Add("resStatus");
            dt.Columns.Add("resFood");
            dt.Columns.Add("shopeeFoodPrice");
            dt.Columns.Add("grabFoodPrice");
            dt.Columns.Add("foodPandaPrice");
            dt.Columns.Add("food1");
            dt.Columns.Add("food1Price");
            dt.Columns.Add("food2");
            dt.Columns.Add("food2Price");
            dt.Columns.Add("Update");

            foreach (DocumentSnapshot docsnap in snap)
            {
                RestaurantLinkData Restaurant = docsnap.ConvertTo<RestaurantLinkData>();

                if (docsnap.Exists)
                {
                    dt.Rows.Add(docsnap.Id, Restaurant.resAddress, Restaurant.resName, Restaurant.resOperationHour, Restaurant.resImg, Restaurant.resPhoneNo, Restaurant.resRating, Restaurant.resStatus, Restaurant.resFood, Restaurant.shopeeFoodPrice, Restaurant.grabFoodPrice, Restaurant.foodPandaPrice, Restaurant.food1, Restaurant.food1Price, Restaurant.food2, Restaurant.food2Price, "id=" + docsnap.Id);
                    gv.DataSource = dt;
                }
                gv.DataBind();
            }

        }

        protected void restaurantUpdate_Click(object sender, EventArgs e)
        {
            string arg = (sender as Button).CommandArgument;
            Response.Redirect("~/Admin/UpdateRestaurantDetail.aspx?" + arg, false);
        }

    }
}