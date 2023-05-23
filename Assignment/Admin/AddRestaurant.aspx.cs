using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Image = System.Drawing.Image;
using Google.Cloud.Firestore;
using System.IO;
using System.Windows.Forms;

namespace Assignment.Admin
{
    public partial class AddRestaurant : System.Web.UI.Page
    {
        FirestoreDb firestoredatabase;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"auxon-fyp.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestoredatabase = FirestoreDb.Create("auxon-fyp");

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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ///* This is to Convert Image into Base 64 String */
            imgUpload.SaveAs(MapPath("~/images/" + imgUpload.FileName));
            Image newImage = Image.FromFile("C:/Users/kyee3/Downloads/" + imgUpload.FileName);

            byte[] image = ImageToByteArray(newImage);
            string output = Convert.ToBase64String(image);

            /* Ends Here */

            string resName = storeRestaurantName.Text;
            string resAddress = storeRestaurantAddress.Text;
            string resOpertionalHour = storeResOperationHour.Text;
            string resPhoneNo = storeResPhoneNo.Text;
            string resRating = storeRating.Text;
            string resStatus = storeResStatus.Text;
            string shopeeFoodPrice = storeShopeeFoodPrice.Text;
            string grabFoodPrice = storeGrabFoodPrice.Text;
            string foodPandaPrice = storeFoodPandaPrice.Text;
            string food1 = storeFood.Text;
            string food1price = storeFoodPrice.Text;
            string food2 = storeFood1.Text;
            string food2price = storeFoodPrice1.Text;


            string imgResUpload = output;


            CollectionReference collection = firestoredatabase.Collection("Restaurant");
            Dictionary<string, object> storeuserdata = new Dictionary<string, object>()
                {
                    {"resName",resName},
                    {"resAddress",resAddress},
                    {"resOperationHour",resOpertionalHour},
                    {"resPhoneNo",resPhoneNo},
                    {"resRating",resRating},
                    {"resStatus",resStatus},
                    {"shopeeFoodPrice",shopeeFoodPrice},
                    {"grabFoodPrice",grabFoodPrice},
                    {"foodPandaPrice",foodPandaPrice},
                    {"food1",food1},
                    {"food1Price",food1price},
                    {"food2",food2},
                    {"food2Price",food2price},
                    {"resImg",imgResUpload},
                };

            collection.AddAsync(storeuserdata);
            MessageBox.Show("data added sucessfully");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageRestaurant.aspx");
        }

    }
}