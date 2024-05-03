using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using DevConnect.Common;
using Firebase.Auth;
using Firebase.Firestore;
using Firebase.Firestore.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class acc : AppCompatActivity
    {
        TextView name, email;

        FirebaseAuth auth;
        FirebaseFirestore db;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.account);
            // Create your application here
            auth = FirebaseRepository.getFirebaseAuth();
            db = FirebaseRepository.GetFirebaseFirestore();

            name = FindViewById<TextView>(Resource.Id.textName);
            email = FindViewById<TextView>(Resource.Id.textEmail);

            DocumentReference userRef = db.Collection("users").Document(auth.CurrentUser.Uid);


            var user = auth.CurrentUser;
            if (user != null)
            {
                name.Text = user.DisplayName;
                email.Text = user.Email;
            }




            ImageButton homeBTN = FindViewById<ImageButton>(Resource.Id.homeBTN);
            homeBTN.Click += delegate
            {
                StartActivity(typeof(homepageact));

            };
            ImageButton movieBTN = FindViewById<ImageButton>(Resource.Id.movieBTN);
            movieBTN.Click += delegate
            {
               
                StartActivity(typeof(movie));

            };

            ImageButton ticketBTN = FindViewById<ImageButton>(Resource.Id.ticketBTN);
            ticketBTN.Click += delegate
            {
                StartActivity(typeof(ticket));

            };

            ImageButton srchBTN = FindViewById<ImageButton>(Resource.Id.srchBTN);
            srchBTN.Click += delegate
            {
                StartActivity(typeof(search));

            };

           
        }
    }
}