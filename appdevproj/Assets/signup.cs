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
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevproj.Assets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class signup : AppCompatActivity, IOnCompleteListener
    {
        EditText edittextFullname, edittextEmail, edittextPassword, edittextCPassword;
        Button sign_up;

        FirebaseAuth auth;
        FirebaseFirestore db;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Signup);
            // Create your application here
            auth = FirebaseRepository.getFirebaseAuth();
            db = FirebaseRepository.GetFirebaseFirestore();

            edittextFullname = FindViewById<EditText>(Resource.Id.edittextFullname);
            edittextEmail = FindViewById<EditText>(Resource.Id.edittextEmail);
            edittextPassword = FindViewById<EditText>(Resource.Id.edittextPassword);
            edittextCPassword = FindViewById<EditText>(Resource.Id.edittextCPassword);
            sign_up = FindViewById<Button>(Resource.Id.sign_up);

            sign_up.Click += Sign_up_Click;

            edittextFullname.TextChanged += delegate { ValidateField(edittextFullname); };
            edittextEmail.TextChanged += delegate { ValidateField(edittextEmail); };
            edittextPassword.TextChanged += delegate { ValidateField(edittextPassword); };
            edittextCPassword.TextChanged += delegate { ValidateField(edittextCPassword); };

            TextView Clickview = FindViewById<TextView>(Resource.Id.Clickview);
            Clickview.Click += delegate
            {
                StartActivity(typeof(Activity1));

            };

            ImageButton back = FindViewById<ImageButton>(Resource.Id.back);
            back.Click += delegate
            {

                StartActivity(typeof(Activity1));

            };
        }
        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            string fullname = edittextFullname?.Text;
            string email = edittextEmail?.Text;
            string pass = edittextPassword?.Text;
            string confirmpass = edittextCPassword?.Text;

            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(pass) ||
                string.IsNullOrEmpty(fullname))
            {
                edittextFullname.Error = "Must not be empty.";
                edittextEmail.Error = "Must not be empty.";
                edittextPassword.Error = "Must not be empty.";
                edittextCPassword.Error = "Must not be empty.";
                return;
            }

            auth.CreateUserWithEmailAndPassword(email, pass)
                  .AddOnCompleteListener(this, this);

        }
        public void StartSignInActivity()
        {
            Intent login = new Intent(this, typeof(Activity1));
            StartActivity(login);
            Finish();
        }
        public void OnComplete(Task task)
        {
            if (task.IsSuccessful)
            {
                HashMap userMap = new HashMap();
                userMap.Put("fullname", edittextFullname.Text);

                DocumentReference userRef = db.Collection("users").Document(auth.CurrentUser.Uid);
                userRef.Set(userMap);

                Toast.MakeText(this, "Registration was successful!", ToastLength.Short).Show();
                StartSignInActivity();
            }

            else
            {
                Toast.MakeText(this, task.Exception.Message, ToastLength.Short).Show();
            }
        }
        private void ValidateField(EditText field)
        {


            if (string.IsNullOrEmpty(field.Text))
            {
                field.Error = "Must not be empty.";
                sign_up.Clickable = false;
                return;

            }
        }
    }
}
