using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Assignment.LinkData;
using Image = System.Drawing.Image;
using Google.Cloud.Firestore;
using System.IO;
using System.Windows.Forms;

namespace Assignment.Admin
{
    public partial class UpdateRestaurantDetail : System.Web.UI.Page
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
                displayRestaurantdata();
            }
        }

        async void displayRestaurantdata()
        {
            DocumentReference docref = firestoredatabase.Collection("Restaurant").Document(PageID);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                RestaurantLinkData restaurant = snap.ConvertTo<RestaurantLinkData>();
                resImg.ImageUrl = "data:image/Png;base64," + restaurant.resImg;
                updateResName.Text = restaurant.resName;
                updateResAddress.Text = restaurant.resAddress;
                updateResOperationHour.Text = restaurant.resOperationHour;
                updateResPhoneNo.Text = restaurant.resPhoneNo;
                updateRating.Text = restaurant.resRating;
                updateResStatus.Text = restaurant.resStatus;
                updateShopeeFoodPrice.Text = restaurant.shopeeFoodPrice;
                updateGrabFoodPrice.Text = restaurant.grabFoodPrice;
                updateFoodPandaPrice.Text = restaurant.foodPandaPrice;
                updateFood.Text = restaurant.food1;
                updateFoodPrice.Text = restaurant.food1Price;
                updateFood1.Text = restaurant.food2;
                updateFoodPrice1.Text = restaurant.food2Price;
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

        protected async void btnUpdate_Click(object sender, EventArgs e)
        {
            /* This is to Convert Image into Base 64 String */
            updateImg.SaveAs(MapPath("~/images/" + updateImg.FileName));
            Image newImage = Image.FromFile("C:/Users/kyee3/Downloads/" + updateImg.FileName);

            byte[] image = ImageToByteArray(newImage);
            string output = Convert.ToBase64String(image);
            /* Ends Here */
            string updatedImgSong = output;

            string updateResName1 = updateResName.Text;
            string updateResAddress1 = updateResAddress.Text;
            string updateResOperationHour1 = updateResOperationHour.Text;
            string updateResPhoneNo1 = updateResPhoneNo.Text;
            string updateRating1 = updateRating.Text;
            string updateResStatus1 = updateResStatus.Text;
            string updateShopeeFoodPrice1 = updateShopeeFoodPrice.Text;
            string updateGrabFoodPrice1 = updateGrabFoodPrice.Text;
            string updateFoodPandaPrice1 = updateFoodPandaPrice.Text;
            string updateFood11 = updateFood.Text;
            string updateFoodPrice11 = updateFoodPrice.Text;
            string updateFood22 = updateFood1.Text;
            string updateFoodPrice22 = updateFoodPrice1.Text;

            DocumentReference docref = firestoredatabase.Collection("Restaurant").Document(PageID);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "resName",updateResName1},
                { "resAddress",updateResAddress1},
                { "resOperationHour",updateResOperationHour1},
                { "resPhoneNo",updateResPhoneNo1},
                { "resRating",updateRating1},
                { "resStatus",updateResStatus1},
                { "shopeeFoodPrice",updateShopeeFoodPrice1},
                { "grabFoodPrice",updateGrabFoodPrice1},
                { "foodPandaPrice",updateFoodPandaPrice1},
                { "food1",updateFood11},
                { "food1Price",updateFoodPrice11},
                { "food2",updateFood22},
                { "food2Price",updateFoodPrice22},
                { "resImg",updatedImgSong},

            };
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
            MessageBox.Show("Update Successfully");
            Response.Redirect("~/Admin/ManageRestaurant.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DocumentReference docref = firestoredatabase.Collection("Restaurant").Document(PageID);
            docref.DeleteAsync();
            MessageBox.Show("Delete Successfully");
            Response.Redirect("~/Admin/ManageRestaurant.aspx");
        }

    }
}