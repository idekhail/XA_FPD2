using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using Java.Lang;

namespace XA_FPD2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);

            //Link mobile page with C# file
            SetContentView(Resource.Layout.activity_main);

            //Link tools in mobile page with C# file
            //EditText
            var username = FindViewById<EditText>(Resource.Id.username);
            var password = FindViewById<EditText>(Resource.Id.password);
            //Button
            var login = FindViewById<Button>(Resource.Id.login);
            var clear = FindViewById<Button>(Resource.Id.clear);
            var close = FindViewById<Button>(Resource.Id.close);

            login.Click += delegate
            {
                //if(username.Text != "" && password.Text != "")
                // Make sure your username and password are entered
                if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))               
                {
                    // Match your username and password with stored data
                    if (username.Text != "Ali" && password.Text != "123")
                    {
                        Intent intent = new Intent(this, typeof(SecondActivity));
                          intent.PutExtra("username", username.Text);
                        StartActivity(intent);
                    }
                    else
                    {
                        // Toast message to display the error!!! LONG (long time) - Last for about 4 seconds
                        Toast.MakeText(this, " UserName or Password is wrong!!!!", ToastLength.Long).Show();
                    }
                }
                else
                {
                    // Toast message to display the error!!! SHORT (short time) - Last forabout 2 seconds
                    Toast.MakeText(this, " Is Empty ", ToastLength.Short).Show();
                }
            };

            clear.Click += delegate
            {
                username.Text = string.Empty;
                password.Text = "";
            };
            close.Click += delegate
            {
                //JavaSystem.Exit(0);
                System.Environment.Exit(0);
            };
        }
    }
}