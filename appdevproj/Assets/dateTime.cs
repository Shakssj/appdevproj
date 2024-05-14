using Android.App;
using Android.Content;
using Android.Graphics;
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
        DatePicker datePicker;
        Button btn10, btn12, btn15, btn17, btn20,btn22,button10,button12, button15, button17, button20, button22, nextButton;
        string lastClickedButtonText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Datetime);

            datePicker = FindViewById<DatePicker>(Resource.Id.datePicker);
            nextButton = FindViewById<Button>(Resource.Id.sign_in_button2);
            button10 = FindViewById<Button>(Resource.Id.button10);
            button12 = FindViewById<Button>(Resource.Id.button12);
            button15 = FindViewById<Button>(Resource.Id.button15);
            button17 = FindViewById<Button>(Resource.Id.button17);
            button20 = FindViewById<Button>(Resource.Id.button20);
            button22 = FindViewById<Button>(Resource.Id.button22);
            btn10 = FindViewById<Button>(Resource.Id.btn10);
            btn12 = FindViewById<Button>(Resource.Id.btn12);
            btn15 = FindViewById<Button>(Resource.Id.btn15);
            btn17 = FindViewById<Button>(Resource.Id.btn17);
            btn20 = FindViewById<Button>(Resource.Id.btn20);
            btn22 = FindViewById<Button>(Resource.Id.btn22);


            button10.Click += OnButtonClick;
            button12.Click += OnButtonClick;
            button15.Click += OnButtonClick;
            button17.Click += OnButtonClick;
            button20.Click += OnButtonClick;
            button22.Click += OnButtonClick;
            btn10.Click += OnButtonClick;
            btn12.Click += OnButtonClick;
            btn15.Click += OnButtonClick;
            btn17.Click += OnButtonClick;
            btn20.Click += OnButtonClick;
            btn22.Click += OnButtonClick;

            nextButton.Click += (sender, e) =>
            {
                int day = datePicker.DayOfMonth;
                int month = datePicker.Month + 1; // Month starts from 0
                int year = datePicker.Year;

                string monthString = new DateTime(year, month, 1).ToString("MMMM");


                int imageUrl = Intent.GetIntExtra("imageUrl", 0); // 0 is default value
                string title = Intent.GetStringExtra("title");
                string duration = Intent.GetStringExtra("duration");
                string director = Intent.GetStringExtra("director");
                string genre = Intent.GetStringExtra("genre");

                // Navigate to layout3 and pass data


                // Start second activity and pass selected button text
              
                if (lastClickedButtonText != null)
                {
                    // Start second activity and pass the text of the last clicked button
                    var intent = new Intent(this, typeof(reviewSummary));
                    intent.PutExtra("imageUrl", imageUrl);
                    intent.PutExtra("title", title);
                    intent.PutExtra("duration", duration);
                    intent.PutExtra("director", director);
                    intent.PutExtra("genre", genre);
                    intent.PutExtra("selectedDate", $"{monthString}-{day}-{year}");
                    intent.PutExtra("ButtonText", lastClickedButtonText);
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Please Sekect a time before submitting.", ToastLength.Short).Show();
                }

            };

        }
        void OnButtonClick(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Reset all buttons to default color
            ResetButton(button10);
            ResetButton(button12);
            ResetButton(button15);
            ResetButton(button17);
            ResetButton(button20);
            ResetButton(button22);
            ResetButton(btn10);
            ResetButton(btn12);
            ResetButton(btn15);
            ResetButton(btn17);
            ResetButton(btn20);
            ResetButton(btn22);

            // Change background and text color of clicked button
            clickedButton.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Color.ParseColor("#6d706e"));
            clickedButton.SetTextColor(Color.White);

            lastClickedButtonText = clickedButton.Text;
        }
        void ResetButton(Button button)
        {
            button.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Color.ParseColor("#1a1f29")); // Default background color
            button.SetTextColor(Color.White); // Default text color
        }


    }
}