using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class dateTime : Activity
    {
        Button nextButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Datetime);

            nextButton = FindViewById<Button>(Resource.Id.sign_in_button2);

            nextButton.Click += delegate
            {
                int imageUrl = Intent.GetIntExtra("imageUrl", 0); // 0 is default value
                string title = Intent.GetStringExtra("title");
                string duration = Intent.GetStringExtra("duration");
                string director = Intent.GetStringExtra("director");
                string genre = Intent.GetStringExtra("genre");

                // Navigate to layout3 and pass data
                var intent = new Intent(this, typeof(reviewSummary));
                intent.PutExtra("imageUrl", imageUrl);
                intent.PutExtra("title", title);
                intent.PutExtra("duration", duration);
                intent.PutExtra("director", director);
                intent.PutExtra("genre", genre);
                StartActivity(intent);
            };

        }

    }
}