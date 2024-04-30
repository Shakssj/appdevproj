using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using appdevproj.Assets;

namespace appdevproj
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button sign_in_button = FindViewById<Button>(Resource.Id.sign_in_button);
            sign_in_button.Click += delegate
            {
                StartActivity(typeof(Activity1));

            };

            TextView Clickview = FindViewById<TextView>(Resource.Id.Clickview);
            Clickview.Click += delegate
            {
                StartActivity(typeof(signup));

            };
        }
        
    }
}

    
