using System;
using System.Collections;
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
    [Activity(Label = "Child Info", Theme = "@style/MyTheme", ParentActivity = typeof(MainActivity), ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, NoHistory =true)]
    public class ChildInfo : Activity
    {
        Spinner spin_age, spin_gender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChildInfo);

            initialize();

            var proceed = FindViewById<Button>(Resource.Id.btn_ok);
            var name = FindViewById<TextView>(Resource.Id.txtnsame);
            var age = FindViewById<Spinner>(Resource.Id.sp_age);
            var gender = FindViewById<Spinner>(Resource.Id.sp_gender);

            proceed.Click += (s, e) =>
            {
                if(name.Text != "")
                {
                    Intent myIntent;
                    myIntent = new Intent(this, typeof(Diagnose));
                    myIntent.PutExtra("cName", name.Text);
                    if (age.SelectedItemPosition == 0)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "0-12months");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 1)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "1 year old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 2)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "2 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 3)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "3 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 4)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "4 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 5)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "5 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 6)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "6 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 7)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "7 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 8)
                {
                         
                        
                        myIntent.PutExtra("cAge", "8 years old");
                        StartActivity(myIntent);
                    }
                else if (age.SelectedItemPosition == 9)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "9 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 10)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "10 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 11)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "11 years old");
                        StartActivity(myIntent);
                    }
                    else if (age.SelectedItemPosition == 12)
                    {
                         
                        
                        myIntent.PutExtra("cAge", "12 years old");
                        StartActivity(myIntent);
                    }
                    if (gender.SelectedItemPosition == 0)
                    {


                        myIntent.PutExtra("cGender", "Male");
                        StartActivity(myIntent);
                    }
                    else if (gender.SelectedItemPosition == 1)
                    {

                        myIntent.PutExtra("cGender", "Female");
                        StartActivity(myIntent);
                    }
                }
                else
                {
                    Toast.MakeText(this, "Please Fill up the required fields", ToastLength.Short).Show();
                }
            };

            IList agelist = new ArrayList();
            IList genderlist = new ArrayList();

            agelist.Add("0-12months");
            agelist.Add("1 year old");
            agelist.Add("2 yrs. old");
            agelist.Add("3 yrs. old");
            agelist.Add("4 yrs. old");
            agelist.Add("5 yrs. old");
            agelist.Add("6 yrs. old");
            agelist.Add("7 yrs. old");
            agelist.Add("8 yrs. old");
            agelist.Add("9 yrs. old");
            agelist.Add("10 yrs. old");
            agelist.Add("11 yrs. old");
            agelist.Add("12 yrs. old");

            genderlist.Add("Male");
            genderlist.Add("Female");

            ArrayAdapter dynamicAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, agelist);
            dynamicAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleListItemChecked);
            spin_age.Adapter = dynamicAdapter;

            ArrayAdapter dynamicAdapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, genderlist);
            dynamicAdapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleListItemChecked);
            spin_gender.Adapter = dynamicAdapter2;

        }

        private void initialize()
        {
            spin_age = (Spinner)FindViewById(Resource.Id.sp_age);
            spin_gender = (Spinner)FindViewById(Resource.Id.sp_gender);
        }
    }
}
