using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Google.Cloud.Firestore;
using Assignment.LinkData;
using Image = System.Drawing.Image;
using System.IO;

namespace Assignment
{
    public partial class FoodDetail : System.Web.UI.Page
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
                displayFoodDetails();
            }

        }

        async void displayFoodDetails()
        {

            DocumentReference docref = firestoredatabase.Collection("Restaurant").Document(PageID);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

             

            RestaurantLinkData Restaurant= snap.ConvertTo<RestaurantLinkData>();
            lblshopeeFoodPrice.Text = Restaurant.shopeeFoodPrice;
            lblgrabFoodPrice.Text = Restaurant.grabFoodPrice;
            lblfoodPandaPrice.Text = Restaurant.foodPandaPrice;

            lblName.Text = Restaurant.resName;
            lblFood.Text = Restaurant.food1;
            lblFoodPrice.Text = Restaurant.food1Price;
            lblFood2.Text = Restaurant.food2;
            lblFoodPrice2.Text = " - RM " + Restaurant.food2Price;
            
            
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

    }
}