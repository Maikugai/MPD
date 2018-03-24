using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MobilePediatricDoctor.Models
{
    [Activity(Label = "MedicineDesc", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MedicineDesc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MedicineDesc);

            TextView mName = FindViewById<TextView>(Resource.Id.mName);
            TextView mIndication = FindViewById<TextView>(Resource.Id.mIndication);
            TextView mWarning = FindViewById<TextView>(Resource.Id.mWarning);

            mName.Text = Intent.GetStringExtra("mName") ?? "Data not available";
            mIndication.Text = Intent.GetStringExtra("mIndication") ?? "Data not available";
            mWarning.Text = Intent.GetStringExtra("mWarning") ?? "Data not available";
        }
    }
}