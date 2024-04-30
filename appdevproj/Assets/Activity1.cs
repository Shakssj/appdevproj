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
    public class Activity1 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            // Create your application here

            Button sign_in = FindViewById<Button>(Resource.Id.sign_in);
            sign_in.Click += delegate
            {
                StartActivity(typeof(homepageact));

            };

            ImageButton back = FindViewById<ImageButton>(Resource.Id.back);
            back.Click += delegate
            {
                StartActivity(typeof(MainActivity));

            };

            TextView Clickview = FindViewById<TextView>(Resource.Id.Clickview);
            Clickview.Click += delegate
            {
                StartActivity(typeof(signup));

            };
        }
    }
}