using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DevConnect.Common;
using Firebase.Auth;
using Firebase.Firestore;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class reviewSummary : Activity
    {

        Button book;

        FirebaseAuth auth;
        FirebaseFirestore db;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.reviewsumarry);

            auth = FirebaseRepository.getFirebaseAuth();
            db = FirebaseRepository.GetFirebaseFirestore();

            int imageUrl = Intent.GetIntExtra("imageUrl", 0); // 0 is default value
            string title = Intent.GetStringExtra("title");
            string duration = Intent.GetStringExtra("duration");
            string director = Intent.GetStringExtra("director");
            string genre = Intent.GetStringExtra("genre");
            string selectedDate = Intent.GetStringExtra("selectedDate");
            string buttonText = Intent.GetStringExtra("ButtonText");

            ImageView imageView = FindViewById<ImageView>(Resource.Id.imgev1); // Assuming the ImageView's ID is "imageView"
            imageView.SetImageResource(imageUrl);

            TextView buttonTextView = FindViewById<TextView>(Resource.Id.textTime);
            buttonTextView.Text = buttonText;

            TextView durationTextView = FindViewById<TextView>(Resource.Id.durationText);
            durationTextView.Text = duration;

            TextView titleTextView = FindViewById<TextView>(Resource.Id.titleText);
            titleTextView.Text = title;

            TextView directorTextView = FindViewById<TextView>(Resource.Id.directorText);
            directorTextView.Text = director;

            TextView genreTextView = FindViewById<TextView>(Resource.Id.genreText);
            genreTextView.Text = genre;

            TextView textDate = FindViewById<TextView>(Resource.Id.textDate);
            textDate.Text = selectedDate;


            book = FindViewById<Button>(Resource.Id.sign_in_button2);
            book.Click += Book;

        }
        private void Book(object sender, EventArgs e)
        {
            int imageUrl = Intent.GetIntExtra("imageUrl", 0); // 0 is default value
            string title = Intent.GetStringExtra("title");
            string duration = Intent.GetStringExtra("duration");
            string director = Intent.GetStringExtra("director");
            string genre = Intent.GetStringExtra("genre");
            string selectedDate = Intent.GetStringExtra("selectedDate");
            string buttonText = Intent.GetStringExtra("ButtonText");

            HashMap movieData = new HashMap();
            movieData.Put("imageUrl", imageUrl);
            movieData.Put("title", title);
            movieData.Put("duration", duration);
            movieData.Put("director", director);
            movieData.Put("genre", genre);
            movieData.Put("selectedDate", selectedDate);
            movieData.Put("time", buttonText);

            CollectionReference moviesCollectionRef = db.Collection("tickets").Document(auth.CurrentUser.Uid).Collection("movies");

            DocumentReference movieDocRef = moviesCollectionRef.Document();
            movieDocRef.Set(movieData);

            Toast.MakeText(this, "Successful Book", ToastLength.Short).Show();
        }
    }
}