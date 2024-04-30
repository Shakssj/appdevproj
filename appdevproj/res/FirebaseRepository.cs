
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Firestore;

namespace DevConnect.Common
{
    public class FirebaseRepository
    {
        static FirebaseApp app;
        public static FirebaseAuth getFirebaseAuth()
        {
            //app instance
            app = FirebaseApp.InitializeApp(Application.Context);

            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                   .SetProjectId("nath-ddde7")
                   .SetApplicationId("1:217266368476:android:54d7dbb925ffd3d7b56919")
                   .SetApiKey("AIzaSyBOsYcm2nSQ3Y8ayqb9VWC3_1I6HMiwBEo")
                   .SetStorageBucket("nath-ddde7.appspot.com")
                   .Build();

                app = FirebaseApp.InitializeApp(Application.Context, options);

            }

            return FirebaseAuth.GetInstance(app);

        }
        public static FirebaseFirestore GetFirebaseFirestore()
        {
            //app instance
            app = FirebaseApp.InitializeApp(Application.Context);

            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                   .SetProjectId("nath-ddde7")
                   .SetApplicationId("1:217266368476:android:54d7dbb925ffd3d7b56919")
                   .SetApiKey("AIzaSyBOsYcm2nSQ3Y8ayqb9VWC3_1I6HMiwBEo")
                   .SetStorageBucket("nath-ddde7.appspot.com")
                   .Build();

                app = FirebaseApp.InitializeApp(Application.Context, options);

            }

            return FirebaseFirestore.GetInstance(app);
        }
    }
}
