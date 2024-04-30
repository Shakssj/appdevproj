using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class ticket : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tickets);

            Button sign_in_button = FindViewById<Button>(Resource.Id.sign_in_button);
            // Create your application here

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

            ImageButton srchBTN = FindViewById<ImageButton>(Resource.Id.srchBTN);
            srchBTN.Click += delegate
            {
                StartActivity(typeof(search));

            };

            ImageButton accBTN = FindViewById<ImageButton>(Resource.Id.accBTN);
            accBTN.Click += delegate
            {
                StartActivity(typeof(acc));

            };

        }
    }
}