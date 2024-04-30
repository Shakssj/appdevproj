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
    public class movie : AppCompatActivity
    {



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.movies);

            ImageButton imgeb = FindViewById<ImageButton>(Resource.Id.imgeb);
            imgeb.Click += delegate
                {
                    
                    Intent intent = new Intent(this, typeof(homedes));
                    intent.PutExtra("ImageUrl",Resource.Drawable.movie1);
                    intent.PutExtra("Title", "Madame");
                    intent.PutExtra("Duration", "160 min");
                    intent.PutExtra("Director", "nath");
                    intent.PutExtra("Genre", "Action");
                    intent.PutExtra("Sypnosis", "asdasdasdasdasdasdasdasdasdas");

                    StartActivity(intent);
            };

            ImageButton imge2 = FindViewById<ImageButton>(Resource.Id.imge2);
            imge2.Click += delegate
            {
                
                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie2);
                intent.PutExtra("Title", "Venom");
                intent.PutExtra("Duration", "120 min");
                intent.PutExtra("Director", "nsath");
                intent.PutExtra("Genre", "Action");
                intent.PutExtra("Sypnosis", "Description");

                StartActivity(intent);
            };

            ImageButton homeBTN = FindViewById<ImageButton>(Resource.Id.homeBTN);
            homeBTN.Click += delegate
            {
                StartActivity(typeof(homepageact));

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

            ImageButton accBTN = FindViewById<ImageButton>(Resource.Id.accBTN);
            accBTN.Click += delegate
            {
                StartActivity(typeof(acc));

            };

        }
    }
}