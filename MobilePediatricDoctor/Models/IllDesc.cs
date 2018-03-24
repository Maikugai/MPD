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
    [Activity(Label = "Illness Description", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class IllDesc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.IllDesc);

           
            var listView = FindViewById<ListView>(Resource.Id.list);

            TextView txtname = FindViewById<TextView>(Resource.Id.illName);
            TextView txtdesc = FindViewById<TextView>(Resource.Id.illDesc);
            TextView txtsymp = FindViewById<TextView>(Resource.Id.illSymp);
            TextView txttreat = FindViewById<TextView>(Resource.Id.illTreat);
            TextView txtprev = FindViewById<TextView>(Resource.Id.illPrev);
            TextView txtdoc = FindViewById<TextView>(Resource.Id.illDoc);

            txtname.Text = Intent.GetStringExtra("iName") ?? "Data not available";
            txtdesc.Text = Intent.GetStringExtra("iDesc") ?? "Data not available";
            txtsymp.Text = Intent.GetStringExtra("iSymp") ?? "Data not available";
            txttreat.Text = Intent.GetStringExtra("iTreat") ?? "Data not available";
            txtprev.Text = Intent.GetStringExtra("iPrev") ?? "Data not available";
            txtdoc.Text = Intent.GetStringExtra("iDoc") ?? "Data not available";






        }
    }
}