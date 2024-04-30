using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Firebase.Auth;
using Firebase.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class signup : AppCompatActivity
    {
        EditText edittextFullname, edittextEmail, edittextPassword, edittextCPassword;
        Button sing_up;

        FirebaseAuth auth;
        FirebaseFirestore db;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Signup);
            // Create your application here
            edittextFullname = FindViewById<EditText>(Resource.Id.edittextFullname);
            edittextEmail = FindViewById<EditText>(Resource.Id.edittextEmail);
            edittextPassword = FindViewById<EditText>(Resource.Id.edittextPassword);
            edittextCPassword = FindViewById<EditText>(Resource.Id.edittextCPassword);

            TextView Clickview = FindViewById<TextView>(Resource.Id.Clickview);
            Clickview.Click += delegate
            {
                StartActivity(typeof(signup));

            };

            ImageButton back = FindViewById<ImageButton>(Resource.Id.back);
            back.Click += delegate
            {

                Finish();

            };
        }
        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }


    }
} 