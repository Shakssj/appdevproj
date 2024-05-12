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


            ImageView imgeb3 = FindViewById<ImageView>(Resource.Id.imgeb3);
            imgeb3.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie6);
                intent.PutExtra("Title", "The Flash");
                intent.PutExtra("Duration", "144 minutes");
                intent.PutExtra("Director", "Andy Muschietti");
                intent.PutExtra("Genre", "Action");
                intent.PutExtra("Sypnosis", "Worlds collide when the Flash uses his superpowers to travel back in time to change the events of the past. However, when his attempt to save his family inadvertently alters the future, he becomes trapped in a reality in which General Zod has returned, threatening annihilation. With no other superheroes to turn to, the Flash looks to coax a very different Batman out of retirement and rescue an imprisoned Kryptonian -- albeit not the one he's looking for.");

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

            ImageView imgeb5 = FindViewById<ImageView>(Resource.Id.imgeb5);
            imgeb5.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie5);
                intent.PutExtra("Title", "Five Nights at Freddy's");
                intent.PutExtra("Duration", "109 minutes");
                intent.PutExtra("Director", "Emma Tammi");
                intent.PutExtra("Genre", "Horror");
                intent.PutExtra("Sypnosis", "A troubled security guard begins working at Freddy Fazbear's Pizzeria. While spending his first night on the job, he realizes the late shift at Freddy's won't be so easy to make it through.");

                StartActivity(intent);
            };

            ImageView imgeb6 = FindViewById<ImageView>(Resource.Id.imgeb6);
            imgeb6.Click += delegate
            {

                Intent intent = new Intent(this, typeof(homedes));
                intent.PutExtra("ImageUrl", Resource.Drawable.movie7);
                intent.PutExtra("Title", "Blue Beetle");
                intent.PutExtra("Duration", "127 minutes");
                intent.PutExtra("Director", "Ángel Manuel Soto");
                intent.PutExtra("Genre", "Action");
                intent.PutExtra("Sypnosis", "Jaime Reyes suddenly finds himself in possession of an ancient relic of alien biotechnology called the Scarab. When the Scarab chooses Jaime to be its symbiotic host, he's bestowed with an incredible suit of armor that's capable of extraordinary and unpredictable powers, forever changing his destiny as he becomes the superhero Blue Beetle.");

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