using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Cloud.Firestore;

namespace Assignment.LinkData
{
    [FirestoreData]
    public class MemberLinkData
    {
        [FirestoreProperty]
        public string userID { get; set; }
        [FirestoreProperty]
        public string user_Name { get; set; }
        [FirestoreProperty]
        public string user_Password { get; set; }
        [FirestoreProperty]
        public string user_Email { get; set; }
        [FirestoreProperty]
        public DateTime registerDate { get; set; }
        [FirestoreProperty]
        public string UserRole { get; set; }


    }
}