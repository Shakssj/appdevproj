using Android.App;
using Android.Content;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using DevConnect.Common;
using Firebase.Auth;
using Firebase.Firestore;
using Google.Android.Material.TextField;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Activity1 : AppCompatActivity, IOnCompleteListener
    {
        EditText passt;
        EditText emailt;
        Button login;

        FirebaseAuth auth;

        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            // Create your application here

            emailt = FindViewById<EditText>(Resource.Id.edittextemailLog);
            passt = FindViewById<EditText>(Resource.Id.edittextpassLog);
            login = FindViewById<Button>(Resource.Id.sign_in);

            auth = FirebaseRepository.getFirebaseAuth();

            login.Click += Login_Click;


            emailt.TextChanged += delegate { ValidateField(emailt); };
            emailt.TextChanged += delegate { ValidateField(emailt); };


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

       
        private void ValidateField(EditText field)
        {


            if (string.IsNullOrEmpty(field.Text))
            {
                field.Error = "Must not be empty.";
                login.Clickable = false;
                return;

            }
        }


            private void Login_Click(object sender, System.EventArgs e)
        {
            string email = emailt.Text.Trim();
            string pass = passt.Text.Trim();

            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(pass))
            {
                //textFieldFullname.Error = "Must not be empty.";
                emailt.Error = "Must not be empty.";
                passt.Error = "Must not be empty.";

                return;
            }

            auth.SignInWithEmailAndPassword(email, pass)
                              .AddOnCompleteListener(this, this);

        }
        public void SignInSucces()
        {
            Intent Home = new Intent(this, typeof(homepageact));
            StartActivity(Home);
            Finish();
        }

        public void OnComplete(Android.Gms.Tasks.Task task)
        {
            if (task.IsSuccessful)
            {
                Toast.MakeText(this, "Login was successful!", ToastLength.Short).Show();
                SignInSucces();
                Finish();
            }
            else
            {
                try
                {
                    throw task.Exception;
                }
                catch (FirebaseAuthWeakPasswordException e)
                {
                    Toast.MakeText(this, e.Message, ToastLength.Short).Show();
                }
                catch (FirebaseAuthInvalidCredentialsException e)
                {
                    Toast.MakeText(this, e.Message, ToastLength.Short).Show();

                }
                catch (FirebaseAuthUserCollisionException e)
                {
                    Toast.MakeText(this, e.Message, ToastLength.Short).Show();

                }
                catch (Exception e)
                {
                    Toast.MakeText(this, e.Message, ToastLength.Short).Show();

                }
            }
        }
    }
}