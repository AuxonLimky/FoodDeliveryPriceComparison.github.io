using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Cloud.Firestore;

namespace Assignment.LinkData
{
    [FirestoreData]
    public class FoodLinkData
    {
        [FirestoreProperty]
        public string foodName { get; set; }
        [FirestoreProperty]
        public float price { get; set; }
        [FirestoreProperty]
        public string foodDescription { get; set; }
        [FirestoreProperty]
        public string foodCategory { get; set; }
        [FirestoreProperty]
        public string restaurantServing { get; set; }
        [FirestoreProperty]
        public string foodImg { get; set; }

    } 
}