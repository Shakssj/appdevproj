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
    public class homedes : AppCompatActivity
    {
        ImageView imageView;
        TextView titleTextView, directorTextView, genreTextView, durationText;
        Button nextButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Homedes);
            // Create your application here

            int imageUrl = Intent.GetIntExtra("ImageUrl", 0);
            string title = Intent.GetStringExtra("Title");
            string duration = Intent.GetStringExtra("Duration");
            string director = Intent.GetStringExtra("Director");
            string genre = Intent.GetStringExtra("Genre");
            string sypnosis = Intent.GetStringExtra("Sypnosis");

            ImageView imgev1 = FindViewById<ImageView>(Resource.Id.imgev1);
            TextView titleText = FindViewById<TextView>(Resource.Id.titleText);
            TextView durationText = FindViewById<TextView>(Resource.Id.durationText);
            TextView directorText = FindViewById<TextView>(Resource.Id.directorText);
            TextView genreText = FindViewById<TextView>(Resource.Id.genreText);
            TextView sypnosisText = FindViewById<TextView>(Resource.Id.sypnosisText);

            imgev1.SetImageResource(imageUrl);
            titleText.Text = title;
            durationText.Text = duration;
            directorText.Text = director;
            genreText.Text = genre;
            sypnosisText.Text = sypnosis;

            ImageButton back = FindViewById<ImageButton>(Resource.Id.back);
            back.Click += delegate
            {
                StartActivity(typeof(movie));

            };
            nextButton = FindViewById<Button>(Resource.Id.sign_in_button2);
            nextButton.Click += delegate
            {

                var intent = new Intent(this, typeof(dateTime));
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