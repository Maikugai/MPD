using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using TheWae.Models;
using System;
using Android.Views;
using MobilePediatricDoctor;
using MobilePediatricDoctor.Models;

namespace TheWae.Models
{
    [Activity(Label = "Doctors", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Doctors : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            string[] doctors = new string[]
            {
                "Dra. Bilynda Lim", "Dra. Marilu L. Gamboa", "Dra. Ma. Cecilia G. Ama", "Dra. Marie Claire V. Robles",  "Dra. Leilani Umali", "Dra. Christian Adrilliana"
            };
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Doctors);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.doctoolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Doctors List";

            var doclist = FindViewById<ListView>(Resource.Id.doclist);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, doctors);
            doclist.Adapter = adapter;

            doclist.ItemClick += (s, e) =>
            {
                var DoctorActivity = new Intent(this, typeof(DoctorsDesc));

                switch (e.Position)
                {
                    case 0:
                        DoctorActivity.PutExtra("docname", "Dra. Bilynda Lim");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 288 1926");
                        DoctorActivity.PutExtra("dochospital", "MBM Clinic");
                        DoctorActivity.PutExtra("docsched", "MWF - 10:00am to 1:00pm \n TTH-SAT - 3:00pm to 6:00pm");
                        StartActivity(DoctorActivity);
                        break;
                    case 1:
                        DoctorActivity.PutExtra("docname", "Dra. Marilu L. Gamboa");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 235 9160");
                        DoctorActivity.PutExtra("dochospital", "Infant Jesus Childrens Clinic Children's Diseases and Well-Baby Care");
                        DoctorActivity.PutExtra("docsched", "MWF - 10:00am to 1:00pm \n TTH-SAT - 3:00pm to 6:00pm");
                        StartActivity(DoctorActivity);
                        break;
                    case 2:
                        DoctorActivity.PutExtra("docname", "Dra. Ma. Cecilia G. Ama");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 926 6158");
                        DoctorActivity.PutExtra("dochospital", "Philippine Pediatric Society, Incorporated");
                        DoctorActivity.PutExtra("docsched", "MWF - 9:00am to 5:00pm \n TTH-SAT - 9:00am to 5:00pm");
                        StartActivity(DoctorActivity);
                        break;
                    case 3:
                        DoctorActivity.PutExtra("docname", "Dra. Marie Claire V. Robles");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 360 5852");
                        DoctorActivity.PutExtra("dochospital", "Health Alert Specialist Clinic");
                        DoctorActivity.PutExtra("docsched", " ");
                        StartActivity(DoctorActivity);
                        break;
                    case 4:
                        DoctorActivity.PutExtra("docname", "Dra. Leilani Umali");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 365 9565");
                        DoctorActivity.PutExtra("dochospital", "Clinica Caritas");
                        DoctorActivity.PutExtra("docsched", "Wed-Sat - 1:00pm to 5:00pm");
                        StartActivity(DoctorActivity);
                        break;
                    case 5:
                        DoctorActivity.PutExtra("docname", "Dra. Christian Adrilliana");
                        DoctorActivity.PutExtra("docfield", "Pediatrician");
                        DoctorActivity.PutExtra("doccontact", "(02) 365 9565");
                        DoctorActivity.PutExtra("dochospital", "Clinica Caritas");
                        DoctorActivity.PutExtra("docsched", "MW-Sat - 8:00am to 12:00nn");
                        StartActivity(DoctorActivity);
                        break;

                }
            };
        }
    }
}