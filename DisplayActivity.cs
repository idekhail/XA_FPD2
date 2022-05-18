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

namespace XA_FPD2
{
    [Activity(Label = "DisplayActivity")]
    public class DisplayActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_display);
            
            var screen = FindViewById<TextView>(Resource.Id.screen);
            var close = FindViewById<Button>(Resource.Id.close);

           


        }
    }
}