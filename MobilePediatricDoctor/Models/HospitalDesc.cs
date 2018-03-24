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

namespace TheWae.Models
{
    [Activity(Label = "Hospital Description", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class HospitalDesc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.HospitalDesc);
            

            TextView hospName = FindViewById<TextView>(Resource.Id.hospName);
            TextView hospCity = FindViewById<TextView>(Resource.Id.hospCity);
            TextView hospAddress = FindViewById<TextView>(Resource.Id.hospAddress);
            TextView hospContact = FindViewById<TextView>(Resource.Id.hospContact);

            hospName.Text = Intent.GetStringExtra("Name") ?? "Data not available";
            hospCity.Text = Intent.GetStringExtra("City") ?? "Data not available";
            hospAddress.Text = Intent.GetStringExtra("Add") ?? "Data not available";
            hospContact.Text = Intent.GetStringExtra("Contact") ?? "Data not available";
        }
    }
}