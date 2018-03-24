using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using TheWae.Models;
using MobilePediatricDoctor;
using MobilePediatricDoctor.Models;

namespace TheWae
{
    [Activity(Label = "Mobile Pediatric Doctor", Theme = "@style/Theme.AppCompat.Light.NoActionBar", ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Mmenu);

            var dia = FindViewById<Button>(Resource.Id.diagnose);
            var ill = FindViewById<Button>(Resource.Id.illness);
            var hosp = FindViewById<Button>(Resource.Id.hospital);
            var med = FindViewById<Button>(Resource.Id.medicine);
            var doct = FindViewById<Button>(Resource.Id.doctors);

            dia.Click += (s, e) =>
            {
                Intent myIntent;
                myIntent = new Intent(this, typeof(ChildInfo));
                StartActivity(myIntent);
            };
            ill.Click += (s, e) =>
            {
                Intent myIntent;
                myIntent = new Intent(this, typeof(IllMenu));
                StartActivity(myIntent);
            };
            hosp.Click += (s, e) =>
            {
                Intent myIntent;
                myIntent = new Intent(this, typeof(Hospital));
                StartActivity(myIntent);
            };
            med.Click += (s, e) =>
            {
                Intent myIntent;
                myIntent = new Intent(this, typeof(Medicine));
                StartActivity(myIntent);
            };
            doct.Click += (s, e) =>
            {
                Intent myIntent;
                myIntent = new Intent(this, typeof(Doctors));
                StartActivity(myIntent);
            };
        }
    }
}

