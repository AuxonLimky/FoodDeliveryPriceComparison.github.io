using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Cloud.Firestore;

namespace Assignment.LinkData
{
    [FirestoreData]
    public class RestaurantLinkData
    {
        [FirestoreProperty]
        public string resName { get; set; }
        [FirestoreProperty]
        public string resPhoneNo { get; set; }
        [FirestoreProperty]
        public string resAddress { get; set; }
        [FirestoreProperty]
        public string resOperationHour { get; set; }
        [FirestoreProperty]
        public string resStatus { get; set; }
        [FirestoreProperty]
        public string resRating { get; set; }
        [FirestoreProperty]
        public string resImg { get; set; }
        [FirestoreProperty]
        public string resFood { get; set; }
        [FirestoreProperty]
        public string shopeeFoodPrice { get; set; }
        [FirestoreProperty]
        public string grabFoodPrice { get; set; }
        [FirestoreProperty]
        public string foodPandaPrice { get; set; }
        [FirestoreProperty]
        public string food1 { get; set; }
        [FirestoreProperty]
        public string food1Price { get; set; }
        [FirestoreProperty]
        public string food2 { get; set; }
        [FirestoreProperty]
        public string food2Price { get; set; }
    }
}