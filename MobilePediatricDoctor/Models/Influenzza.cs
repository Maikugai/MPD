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
    [Activity(Label = "Influenzza", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Influenzza : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Influenzza);
            // Create your application here

            TextView name = FindViewById<TextView>(Resource.Id.nName);
            TextView desc = FindViewById<TextView>(Resource.Id.dDesc);
            TextView symp = FindViewById<TextView>(Resource.Id.sSymp);
            TextView treat = FindViewById<TextView>(Resource.Id.tTreat);
            TextView prev = FindViewById<TextView>(Resource.Id.pPrev);
            TextView doc = FindViewById<TextView>(Resource.Id.dDoc);

            name.Text = "Abscess (Surrounding cellulitis)";
            desc.Text = "Infection can cause a collection of pus in almost any area of the body.";
            symp.Text = "These are frequent to children because they do not have enough immunologic knowledge with the influenza virus. The rate of infection to children is greater than to the adults.Influenza virus has three types A/ H1N1, A / H3N2, B.";
            treat.Text = "*Apply warm compress to the infected area for 30 minutes 4 times daily* Antibiotics: cloxacillin(25–50 mg / kg   four times a day) for 5 days or until surrounding cellulitis resolves.* You may also take Co - Amoarclaw 30mg / kg every 8 hours";
            prev.Text = "Abcess";
            doc.Text = "Infection can cause a collection of pus in almost any area of the body.";
        }
    }
}