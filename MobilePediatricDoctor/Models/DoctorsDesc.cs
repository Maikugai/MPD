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
using MobilePediatricDoctor;

namespace MobilePediatricDoctor.Models
{
    [Activity(Label = "Doctor's Description", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class DoctorsDesc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DoctorsDesc);

            TextView docname = FindViewById<TextView>(Resource.Id.docname);
            TextView docfield = FindViewById<TextView>(Resource.Id.docfield);
            TextView doccontact = FindViewById<TextView>(Resource.Id.doccontact);
            TextView dochospital = FindViewById<TextView>(Resource.Id.dochospital);
            TextView docsched = FindViewById<TextView>(Resource.Id.docsched);

            docname.Text = Intent.GetStringExtra("docname") ?? "Data not available";
            docfield.Text = Intent.GetStringExtra("docfield") ?? "Data not available";
            doccontact.Text = Intent.GetStringExtra("doccontact") ?? "Data not available";
            dochospital.Text = Intent.GetStringExtra("dochospital") ?? "Data not available";
            docsched.Text = Intent.GetStringExtra("docsched") ?? "Data not available";

        }
    }
}