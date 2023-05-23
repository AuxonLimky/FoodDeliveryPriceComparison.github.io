using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Google.Cloud.Firestore;
using Assignment.LinkData;
using Image = System.Drawing.Image;
using System.IO;

namespace Assignment
{
    public partial class RestaurantDetail : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;
        private object restaurantId;

        protected void Page_Load(object sender, EventArgs e)
        {
            restaurantId = Request.QueryString["restaurantId"];
            
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredatabase = FirestoreDb.Create("auxon-fyp");
            
            if (!IsPostBack)
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
            dt.Columns.Add("Details");
            

            foreach (DocumentSnapshot docsnap in snap)
            {
                RestaurantLinkData Restaurant = docsnap.ConvertTo<RestaurantLinkData>();

                if (docsnap.Exists)
                {
                    //img1.ImageUrl = "data:images/Png;base64," + Restaurant.resImg;
                    dt.Rows.Add(docsnap.Id, Restaurant.resAddress, Restaurant.resName, Restaurant.resOperationHour, Restaurant.resImg, Restaurant.resPhoneNo, Restaurant.resRating, Restaurant.resStatus, Restaurant.resFood,Restaurant.shopeeFoodPrice, Restaurant.grabFoodPrice, Restaurant.foodPandaPrice, Restaurant.food1, Restaurant.food1Price, Restaurant.food2, Restaurant.food2Price, "id=" + docsnap.Id);

                    lv.DataSource = dt;
                }
                lv.DataBind();
            }

        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        protected void ButtonDetail_Click(object sender, EventArgs e)
        {
            string arg = (sender as Button).CommandArgument;
            Response.Redirect("~/Member/FoodDetail.aspx?" + arg, false);
        }

        protected async void btnSearch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Query Qref = firestoredatabase.Collection("Restaurant");
                QuerySnapshot snap = await Qref.GetSnapshotAsync();

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
                dt.Columns.Add("Details");

                foreach (DocumentSnapshot docsnap in snap)
                {
                    RestaurantLinkData Restaurant = docsnap.ConvertTo<RestaurantLinkData>();

                    if (docsnap.Exists)
                    {
                        if (txtSearch.Text == Restaurant.resName)
                        {
                            dt.Rows.Add(docsnap.Id, Restaurant.resAddress, Restaurant.resName, Restaurant.resOperationHour, Restaurant.resImg, Restaurant.resPhoneNo, Restaurant.resRating, Restaurant.resStatus, Restaurant.resFood, Restaurant.shopeeFoodPrice, Restaurant.grabFoodPrice, Restaurant.foodPandaPrice, Restaurant.food1, Restaurant.food1Price, Restaurant.food2, Restaurant.food2Price, "id=" + docsnap.Id);
                            lv.DataSource = dt;
                        }
                        else if (txtSearch.Text == Restaurant.resFood)
                        {
                            dt.Rows.Add(docsnap.Id, Restaurant.resAddress, Restaurant.resName, Restaurant.resOperationHour, Restaurant.resImg, Restaurant.resPhoneNo, Restaurant.resRating, Restaurant.resStatus, Restaurant.resFood, Restaurant.shopeeFoodPrice, Restaurant.grabFoodPrice, Restaurant.foodPandaPrice, Restaurant.food1, Restaurant.food1Price, Restaurant.food2, Restaurant.food2Price, "id=" + docsnap.Id);
                            lv.DataSource = dt;
                        }
                    }
                    lv.DataBind();
                }
            }
        }

    }


}