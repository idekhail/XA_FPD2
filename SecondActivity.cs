using Android.App;
using Android.OS;
using Android.Widget;

namespace XA_FPD2
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_second);

            EditText txt1 = FindViewById<EditText>(Resource.Id.txt1);
            var txt2 = FindViewById<EditText>(Resource.Id.txt2);

            Button call = FindViewById<Button>(Resource.Id.call);
            var web = FindViewById<Button>(Resource.Id.web);
            var clear = FindViewById<Button>(Resource.Id.clear);
            var map = FindViewById<Button>(Resource.Id.map);
            var next = FindViewById<Button>(Resource.Id.next);

            TextView screen = FindViewById<TextView>(Resource.Id.screen);



        }
    }
}