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
    public class homepageact : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Homepage);
            // Create
            // your application here

            ImageView imgeb1 = FindViewById<ImageView>(Resource.Id.imgeb1);
            imgeb1.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie1);
                intent.PutExtra("Title", "Immaculate");
                intent.PutExtra("Duration", "89 minutes");
                intent.PutExtra("Director", "Michael Mohan");
                intent.PutExtra("Genre", "Horror");
                intent.PutExtra("Sypnosis", "An American nun embarks on a new journey when she joins a remote convent in the Italian countryside. However, her warm welcome quickly turns into a living nightmare when she discovers her new home harbours a sinister secret and unspeakable horrors.");

                StartActivity(intent);
            };


            ImageView imgeb2 = FindViewById<ImageView>(Resource.Id.imgeb2);
            imgeb2.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie4);
                intent.PutExtra("Title", "Madame Web");
                intent.PutExtra("Duration", "116 minutes");
                intent.PutExtra("Director", "S. J. Clarkson");
                intent.PutExtra("Genre", "Action");
                intent.PutExtra("Sypnosis", "Cassandra Webb is a New York City paramedic who starts to show signs of clairvoyance. Forced to confront revelations about her past, she must protect three young women from a mysterious adversary who wants them dead.");

                StartActivity(intent);
            };

            ImageView imgeb4 = FindViewById<ImageView>(Resource.Id.imgeb4);
            imgeb4.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie3);
                intent.PutExtra("Title", "Imaginary");
                intent.PutExtra("Duration", "104 minutes");
                intent.PutExtra("Director", "Jeff Wadlow");
                intent.PutExtra("Genre", "Horror");
                intent.PutExtra("Sypnosis", "When Jessica moves back into her childhood home with her family, her youngest stepdaughter, Alice, finds a stuffed bear named Chauncey. As Alice's behavior becomes more and more concerning, Jessica intervenes only to realize that Chauncey is much more than the stuffed toy bear she believed him to be.");

                StartActivity(intent);
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

            ImageButton accBTN = FindViewById<ImageButton>(Resource.Id.accBTN);
            accBTN.Click += delegate
            {
                StartActivity(typeof(acc));

            };

            
        }
    }
}