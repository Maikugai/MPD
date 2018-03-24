using Android.App;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using Android.Content;
using TheWae.Models;
using System;
using Android.Views;
using System.Linq;
using System.Collections.Generic;
using MobilePediatricDoctor;

namespace TheWae.Models
{
    [Activity(Label = "Diagnose", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, NoHistory = true)]
    public class Diagnose : AppCompatActivity
    {
        
        string[] Abscess = { "Tenderness and fluctuant mass", "Swelling", "37.4-38.2 C" };

        string[] AcuteSinusitis = { "Facial Pain", "Difficulty of breathing", "Headache", "Coryza", "37.4-38.2 C" };

        string[] Asthma = { "Shortness of breath", "Wheezing", "Chest tightness", "Cough", "37.4-38.2 C" };

        string[] Chickenpox = { "37.4-38.2 C", "Blister Rash (body, face, limbs)" };

        string[] Croup = { "Barking cough like a raspy or hoarse voice", "Blister Rash (body, face, limbs)", "Noisy breathing", "37.4-38.2 C" };

        string[] ColdSores = { "37.4-38.2 C", "Sore throat", "Blister with Red Base", "Cough"};

string[] HandFootMouthDiseaseCoxsackievirus = { "37.4-38.2 C", "Greyish Blister (palms and finger)", "Sore throat" };

        string[] Impetigo = { "Cluster of Blister (face)", "Sores" };

        string[] Influenza = { "37.4-38.2 C", "Diarrhea", "Vomiting", "Abdominal pain" };

        string[] LaryngotrachealBronchitis = { "Barking cough like a raspy or hoarse voice", "37.4-38.2 C", "Abdominal pain" };

        string[] LiceHeadLicePediculosisinsect = { "Hair has small white egg", "Itchiness" };

        string[] Measles = { "37.4-38.2 C", "Inflamed eyes", "Dry cough", "Runny nose", "Dusky Red Rash (face and white spots in mouth like rough sandpaper)" };

        string[] MeningococcalMeningitisBacterial = { "37.4-38.2 C", "Headache", "Nausea", "Vomiting", "Stiff neck", "Irritability", "Poor appetite", "Pinpoint Rash" };

        string[] MononucleosisEpsteinBarrvirus = { "37.4-38.2 C", "Sore throat", "Swollen glands", "Tiredness" };

        string[] MumpsParotitis = { "37.4-38.2 C", "Headache", "Vomiting", "Abdominal pain" };

        string[] Pertussis = { "Runny nose", "Violent coughing", "Vomiting" };

        string[] PinkEye = { "Teary", "Itchiness of eyelid", "Headache" };

        string[] Respiratory = { "Listlessness", "Chills", "Earache", "Inactivity", "Cough", "Itchiness" };

        string[] Ringworm = { "Ring Shaped Rash", "Itchiness" };

        string[] Roseola = { "Rosy Pink Rash (neck, chest and spread to the rest of the bosy)", "39.4-40.6 C" };

        string[] Salmonellosis = { "Diarrhea", "Nausea", "Vomiting", "37.4-38.2 C", "Headache" };

        string[] Scabies = { "Pimple like Rash (all over the body)", "Itchiness" }; 

        string[] Shingles = { "Painful Blister", "Diarrhea", "Vomiting", "Abdominal pain" };

        string[] Streptococcal = { "Red Swollen lips", "Nausea", "Vomiting", "Dusky Red Rash (face and white spots in mouth like rough sandpaper)", "37.4-38.2 C", "Sore throat" };

        string[] SwimmersItch = { "Pimple like Rash (all over the body)", "Tingling", "Itching of the skin" };

        string[] Tonsillitis = { "Vomiting", "Headache", "Difficult and painful of swallowing", "Swollen red tonsils with white spots", "Sore Throat" };

        Button btnMatch;

        CheckBox cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10;
        CheckBox cb11, cb12, cb13, cb14, cb15, cb16, cb17, cb18, cb19, cb20;
        CheckBox cb21, cb22, cb23, cb24, cb25, cb26, cb27, cb28, cb29, cb30;
        CheckBox cb31, cb32, cb33, cb34, cb35, cb36, cb37, cb38, cb39, cb40;
        CheckBox cb41, cb42, cb43, cb44, cb45, cb46, cb47, cb48, cb49, cb50;
        CheckBox cb51, cb52, cb53, cb54, cb55, cb56, cb57, cb58, cb59, cb60;
        int xx = 0;
        List<string> arrchoices = new List<string>();
        List<string> arrayr1 = new List<string>();
        List<string> arrayr2 = new List<string>();
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;
        int c11 = 0, c12 = 0, c13 = 0, c14 = 0, c15 = 0, c16 = 0, c17 = 0, c18 = 0, c19 = 0, c20 = 0;
        int c21 = 0, c22 = 0, c23 = 0, c24 = 0, c25 = 0, c26 = 0;
        string name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            string[] arr2 = new string[] { };
            SetContentView(Resource.Layout.Diagnose);
            Toast.MakeText(this, "Please select (2) or more symptoms!", ToastLength.Short).Show();
            name = Intent.GetStringExtra("cName") ?? "Data not available";
            string age = Intent.GetStringExtra("cAge") ?? "Data not available";
            string gender = Intent.GetStringExtra("cGender") ?? "Data not available";
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.diagtoolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Symptoms List";
            LinearLayout diagpar = FindViewById<LinearLayout>(Resource.Id.diagcont);
            cb1 = FindViewById<CheckBox>(Resource.Id.checkBox1); cb2 = FindViewById<CheckBox>(Resource.Id.checkBox2); cb3 = FindViewById<CheckBox>(Resource.Id.checkBox3);
            cb4 = FindViewById<CheckBox>(Resource.Id.checkBox4); cb5 = FindViewById<CheckBox>(Resource.Id.checkBox5); cb6 = FindViewById<CheckBox>(Resource.Id.checkBox6);
            cb7 = FindViewById<CheckBox>(Resource.Id.checkBox7); cb8 = FindViewById<CheckBox>(Resource.Id.checkBox8); cb9 = FindViewById<CheckBox>(Resource.Id.checkBox9);
            cb10 = FindViewById<CheckBox>(Resource.Id.checkBox10); cb11 = FindViewById<CheckBox>(Resource.Id.checkBox11); cb12 = FindViewById<CheckBox>(Resource.Id.checkBox12);
            cb13 = FindViewById<CheckBox>(Resource.Id.checkBox13); cb14 = FindViewById<CheckBox>(Resource.Id.checkBox14); cb15 = FindViewById<CheckBox>(Resource.Id.checkBox15);
            cb16 = FindViewById<CheckBox>(Resource.Id.checkBox16); cb17 = FindViewById<CheckBox>(Resource.Id.checkBox17); cb18 = FindViewById<CheckBox>(Resource.Id.checkBox18);
            cb19 = FindViewById<CheckBox>(Resource.Id.checkBox19); cb20 = FindViewById<CheckBox>(Resource.Id.checkBox20); cb21 = FindViewById<CheckBox>(Resource.Id.checkBox21);
            cb22 = FindViewById<CheckBox>(Resource.Id.checkBox22); cb23 = FindViewById<CheckBox>(Resource.Id.checkBox23); cb24 = FindViewById<CheckBox>(Resource.Id.checkBox24);
            cb25 = FindViewById<CheckBox>(Resource.Id.checkBox25); cb26 = FindViewById<CheckBox>(Resource.Id.checkBox26); cb27 = FindViewById<CheckBox>(Resource.Id.checkBox27);
            cb28 = FindViewById<CheckBox>(Resource.Id.checkBox28); cb29 = FindViewById<CheckBox>(Resource.Id.checkBox29); cb30 = FindViewById<CheckBox>(Resource.Id.checkBox30);
            cb31 = FindViewById<CheckBox>(Resource.Id.checkBox31); cb32 = FindViewById<CheckBox>(Resource.Id.checkBox32); cb33 = FindViewById<CheckBox>(Resource.Id.checkBox33);
            cb34 = FindViewById<CheckBox>(Resource.Id.checkBox34); cb35 = FindViewById<CheckBox>(Resource.Id.checkBox35); cb36 = FindViewById<CheckBox>(Resource.Id.checkBox36);
            cb37 = FindViewById<CheckBox>(Resource.Id.checkBox37); cb38 = FindViewById<CheckBox>(Resource.Id.checkBox38); cb39 = FindViewById<CheckBox>(Resource.Id.checkBox39);

            cb40 = FindViewById<CheckBox>(Resource.Id.checkBox40); cb41 = FindViewById<CheckBox>(Resource.Id.checkBox41); cb42 = FindViewById<CheckBox>(Resource.Id.checkBox42);
            cb43 = FindViewById<CheckBox>(Resource.Id.checkBox43); cb44 = FindViewById<CheckBox>(Resource.Id.checkBox44); cb45 = FindViewById<CheckBox>(Resource.Id.checkBox45);
            cb46 = FindViewById<CheckBox>(Resource.Id.checkBox46); cb47 = FindViewById<CheckBox>(Resource.Id.checkBox47); cb48 = FindViewById<CheckBox>(Resource.Id.checkBox48);
            cb49 = FindViewById<CheckBox>(Resource.Id.checkBox49); cb50 = FindViewById<CheckBox>(Resource.Id.checkBox50); cb51 = FindViewById<CheckBox>(Resource.Id.checkBox51);
            cb52 = FindViewById<CheckBox>(Resource.Id.checkBox52); cb53 = FindViewById<CheckBox>(Resource.Id.checkBox53); cb54 = FindViewById<CheckBox>(Resource.Id.checkBox54);
            cb55 = FindViewById<CheckBox>(Resource.Id.checkBox55); cb56 = FindViewById<CheckBox>(Resource.Id.checkBox56); cb57 = FindViewById<CheckBox>(Resource.Id.checkBox57);
            cb58 = FindViewById<CheckBox>(Resource.Id.checkBox58); cb59 = FindViewById<CheckBox>(Resource.Id.checkBox59); cb60 = FindViewById<CheckBox>(Resource.Id.checkBox60);
            

            cb1.CheckedChange += Cb1_CheckedChange; cb2.CheckedChange += Cb2_CheckedChange; cb3.CheckedChange += Cb3_CheckedChange; cb4.CheckedChange += Cb4_CheckedChange;
            cb5.CheckedChange += Cb5_CheckedChange; cb6.CheckedChange += Cb6_CheckedChange; cb7.CheckedChange += Cb7_CheckedChange; cb8.CheckedChange += Cb8_CheckedChange;
            cb9.CheckedChange += Cb9_CheckedChange; cb10.CheckedChange += Cb10_CheckedChange; cb11.CheckedChange += Cb11_CheckedChange; cb12.CheckedChange += Cb12_CheckedChange;
            cb13.CheckedChange += Cb13_CheckedChange; cb14.CheckedChange += Cb14_CheckedChange; cb15.CheckedChange += Cb15_CheckedChange; cb16.CheckedChange += Cb16_CheckedChange;
            cb17.CheckedChange += Cb17_CheckedChange; cb18.CheckedChange += Cb18_CheckedChange; cb19.CheckedChange += Cb19_CheckedChange; cb20.CheckedChange += Cb20_CheckedChange;
            cb21.CheckedChange += Cb21_CheckedChange; cb22.CheckedChange += Cb22_CheckedChange; cb23.CheckedChange += Cb23_CheckedChange; cb24.CheckedChange += Cb24_CheckedChange;
            cb25.CheckedChange += Cb25_CheckedChange; cb26.CheckedChange += Cb26_CheckedChange; cb27.CheckedChange += Cb27_CheckedChange; cb28.CheckedChange += Cb28_CheckedChange;
            cb29.CheckedChange += Cb29_CheckedChange; cb30.CheckedChange += Cb30_CheckedChange; cb31.CheckedChange += Cb31_CheckedChange; cb32.CheckedChange += Cb32_CheckedChange;
            cb33.CheckedChange += Cb33_CheckedChange; cb34.CheckedChange += Cb34_CheckedChange; cb35.CheckedChange += Cb35_CheckedChange; cb36.CheckedChange += Cb36_CheckedChange;
            cb37.CheckedChange += Cb37_CheckedChange; cb38.CheckedChange += Cb38_CheckedChange; cb39.CheckedChange += Cb39_CheckedChange; cb40.CheckedChange += Cb40_CheckedChange;
            cb41.CheckedChange += Cb41_CheckedChange; cb42.CheckedChange += Cb42_CheckedChange; cb43.CheckedChange += Cb43_CheckedChange; cb44.CheckedChange += Cb44_CheckedChange;
            cb45.CheckedChange += Cb45_CheckedChange; cb46.CheckedChange += Cb46_CheckedChange; cb47.CheckedChange += Cb47_CheckedChange; cb48.CheckedChange += Cb48_CheckedChange;
            cb49.CheckedChange += Cb49_CheckedChange; cb50.CheckedChange += Cb50_CheckedChange; cb51.CheckedChange += Cb51_CheckedChange; cb52.CheckedChange += Cb52_CheckedChange;
            cb53.CheckedChange += Cb53_CheckedChange; cb54.CheckedChange += Cb54_CheckedChange; cb55.CheckedChange += Cb55_CheckedChange; cb56.CheckedChange += Cb56_CheckedChange;
            cb57.CheckedChange += Cb57_CheckedChange; cb58.CheckedChange += Cb58_CheckedChange; cb59.CheckedChange += Cb59_CheckedChange; cb60.CheckedChange += Cb60_CheckedChange;

            int ans = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + c11 + c12 + c13 + c14 + c15 + c16 + c17 + c18 + c19 + c20 + c21 + c22 + c23 + c24 + c25 + c26;
            btnMatch = FindViewById<Button>(Resource.Id.match);
            //if (ans == 1)
            //{
            //    btnMatch.Enabled = false;
            //    Toast.MakeText(this, "MPD can't diagnose your symptom. Please select more than 2 symptoms!", ToastLength.Short).Show();
            //}
            //else if (ans > 9)
            //{
            //    btnMatch.Enabled = false;
            //    Toast.MakeText(this, "If you're experiencing this kind of symptoms, Please Seek to your doctor immediately!", ToastLength.Short).Show();
            //}
            //else if (ans > 1 && ans <= 9)
            //{
            //    btnMatch.Enabled = true;
            //}
            //btnMatch.Enabled = false;
                btnMatch.Click += (s, e) =>
                {
                    xx = arrchoices.Count;
                int xy = arrchoices.Count;
                double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0, p10 = 0;
                double p11 = 0, p12 = 0, p13 = 0, p14 = 0, p15 = 0, p16 = 0, p17 = 0, p18 = 0, p19 = 0, p20 = 0;
                double p21 = 0, p22 = 0, p23 = 0, p24 = 0, p25 = 0, p26 = 0;

                if(arrchoices.Count == 1 || arrchoices.Count == 0)
                    {
                        Toast.MakeText(this, "SELECT 2 or MORE SYMPTOMS!", ToastLength.Short).Show();
                    }
                else if(arrchoices.Count >= 9)
                    {
                        Toast.MakeText(this, "Please consult your doctor immediately!", ToastLength.Short).Show();
                    }
                else if(arrchoices.Count >= 2 && arrchoices.Count <=9)
                    {
                        //Abscess 3
                        if (c1 == 0)
                        {
                            p1 = 0;
                        }
                        else if (c1 == 1)
                        {
                            p1 = 33.33;
                        }
                        else if (c1 == 2)
                        {
                            p1 = 66.67;
                        }
                        else if (c1 == 3)
                        {
                            p1 = 100;
                        }

                        //Acutesinusitis 5
                        if (c2 == 0)
                        {
                            p2 = 0;
                        }
                        else if (c2 == 1)
                        {
                            p2 = 20;
                        }
                        else if (c2 == 2)
                        {
                            p2 = 40;
                        }
                        else if (c2 == 3)
                        {
                            p2 = 60;
                        }
                        else if (c2 == 4)
                        {
                            p2 = 80;
                        }
                        else if (c2 == 5)
                        {
                            p2 = 100;
                        }

                        //Asthma 5
                        if (c3 == 0)
                        {
                            p3 = 0;
                        }
                        else if (c3 == 1)
                        {
                            p3 = 20;
                        }
                        else if (c3 == 2)
                        {
                            p3 = 40;
                        }
                        else if (c3 == 3)
                        {
                            p3 = 60;
                        }
                        else if (c3 == 4)
                        {
                            p3 = 80;
                        }
                        else if (c3 == 5)
                        {
                            p3 = 100;
                        }

                        //Chickenpox 2
                        if (c4 == 0)
                        {
                            p4 = 0;
                        }
                        else if (c4 == 1)
                        {
                            p4 = 50;
                        }
                        else if (c4 == 2)
                        {
                            p4 = 100;
                        }
                        //Croup 5
                        if (c5 == 0)
                        {
                            p5 = 0;
                        }
                        else if (c5 == 1)
                        {
                            p5 = 20;
                        }
                        else if (c5 == 2)
                        {
                            p5 = 40;
                        }
                        else if (c5 == 3)
                        {
                            p5 = 60;
                        }
                        else if (c5 == 4)
                        {
                            p5 = 80;
                        }
                        else if (c5 == 5)
                        {
                            p5 = 100;
                        }
                        //Cold Sores 4
                        if (c6 == 0)
                        {
                            p6 = 0;
                        }
                        else if (c6 == 1)
                        {
                            p6 = 25;
                        }
                        else if (c6 == 2)
                        {
                            p6 = 50;
                        }
                        else if (c6 == 3)
                        {
                            p6 = 75;
                        }
                        else if (c6 == 4)
                        {
                            p6 = 100;
                        }
                        //HandFootMouthDiseaseCoxsackievirus 3
                        if (c7 == 0)
                        {
                            p7 = 0;
                        }
                        else if (c7 == 1)
                        {
                            p7 = 33.33;
                        }
                        else if (c7 == 2)
                        {
                            p7 = 66.67;
                        }
                        else if (c7 == 3)
                        {
                            p7 = 100;
                        }
                        //Impetigo 2
                        if (c8 == 0)
                        {
                            p8 = 0;
                        }
                        else if (c8 == 1)
                        {
                            p8 = 50;
                        }
                        else if (c8 == 2)
                        {
                            p8 = 100;
                        }
                        //Influenza 4
                        if (c9 == 0)
                        {
                            p9 = 0;
                        }
                        else if (c9 == 1)
                        {
                            p9 = 25;
                        }
                        else if (c9 == 2)
                        {
                            p9 = 50;
                        }
                        else if (c9 == 3)
                        {
                            p9 = 75;
                        }
                        else if (c9 == 4)
                        {
                            p9 = 100;
                        }
                        //LaryngotrachealBronchitis 3
                        if (c10 == 0)
                        {
                            p10 = 0;
                        }
                        else if (c10 == 1)
                        {
                            p10 = 33.33;
                        }
                        else if (c10 == 2)
                        {
                            p10 = 66.67;
                        }
                        else if (c10 == 3)
                        {
                            p10 = 100;
                        }
                        //LiceHeadLicePediculosisinsect 2
                        if (c11 == 0)
                        {
                            p11 = 0;
                        }
                        else if (c11 == 1)
                        {
                            p11 = 50;
                        }
                        else if (c11 == 2)
                        {
                            p11 = 100;
                        }
                        //Measles 5
                        if (c12 == 0)
                        {
                            p12 = 0;
                        }
                        else if (c12 == 1)
                        {
                            p12 = 20;
                        }
                        else if (c12 == 2)
                        {
                            p12 = 40;
                        }
                        else if (c12 == 3)
                        {
                            p12 = 60;
                        }
                        else if (c12 == 4)
                        {
                            p12 = 80;
                        }
                        else if (c12 == 5)
                        {
                            p12 = 100;
                        }
                        //MeningococcalMeningitisBacterial 8
                        if (c13 == 0)
                        {
                            p13 = 0;
                        }
                        else if (c13 == 1)
                        {
                            p13 = 12.5;
                        }
                        else if (c13 == 2)
                        {
                            p13 = 25;
                        }
                        else if (c13 == 3)
                        {
                            p13 = 37.5;
                        }
                        else if (c13 == 4)
                        {
                            p13 = 50;
                        }
                        else if (c13 == 5)
                        {
                            p13 = 62.5;
                        }
                        else if (c13 == 6)
                        {
                            p13 = 75;
                        }
                        else if (c13 == 7)
                        {
                            p13 = 87.5;
                        }
                        else if (c13 == 8)
                        {
                            p13 = 100;
                        }
                        //MononucleosisEpsteinBarrvirus 4
                        if (c14 == 0)
                        {
                            p14 = 0;
                        }
                        else if (c14 == 1)
                        {
                            p14 = 25;
                        }
                        else if (c14 == 2)
                        {
                            p14 = 50;
                        }
                        else if (c14 == 3)
                        {
                            p14 = 75;
                        }
                        else if (c14 == 4)
                        {
                            p14 = 100;
                        }
                        //MumpsParotitis 4
                        if (c15 == 0)
                        {
                            p15 = 0;
                        }
                        else if (c15 == 1)
                        {
                            p15 = 25;
                        }
                        else if (c15 == 2)
                        {
                            p15 = 50;
                        }
                        else if (c15 == 3)
                        {
                            p15 = 75;
                        }
                        else if (c15 == 4)
                        {
                            p15 = 100;
                        }
                        //Pertussis 3
                        if (c16 == 0)
                        {
                            p16 = 0;
                        }
                        else if (c16 == 1)
                        {
                            p16 = 33.33;
                        }
                        else if (c16 == 2)
                        {
                            p16 = 66.67;
                        }
                        else if (c16 == 3)
                        {
                            p16 = 100;
                        }
                        //PinkEye 3
                        if (c17 == 0)
                        {
                            p17 = 0;
                        }
                        else if (c17 == 1)
                        {
                            p17 = 33.33;
                        }
                        else if (c17 == 2)
                        {
                            p17 = 66.67;
                        }
                        else if (c17 == 3)
                        {
                            p17 = 100;
                        }
                        //Respiratory 6
                        if (c18 == 0)
                        {
                            p18 = 0;
                        }
                        else if (c18 == 1)
                        {
                            p18 = 16.67;
                        }
                        else if (c18 == 2)
                        {
                            p18 = 33.33;
                        }
                        else if (c18 == 3)
                        {
                            p18 = 50;
                        }
                        else if (c18 == 4)
                        {
                            p18 = 66.67;
                        }
                        else if (c18 == 5)
                        {
                            p18 = 83.33;
                        }
                        else if (c18 == 6)
                        {
                            p18 = 100;
                        }
                        //Ringworm 2
                        if (c19 == 0)
                        {
                            p19 = 0;
                        }
                        else if (c19 == 1)
                        {
                            p19 = 50;
                        }
                        else if (c19 == 2)
                        {
                            p19 = 100;
                        }
                        //Roseola 2
                        if (c20 == 0)
                        {
                            p20 = 0;
                        }
                        else if (c20 == 1)
                        {
                            p20 = 50;
                        }
                        else if (c20 == 2)
                        {
                            p20 = 100;
                        }
                        //Salmonellosis 5
                        if (c21 == 0)
                        {
                            p21 = 0;
                        }
                        else if (c21 == 1)
                        {
                            p21 = 16.67;
                        }
                        else if (c21 == 2)
                        {
                            p21 = 33.33;
                        }
                        else if (c21 == 3)
                        {
                            p21 = 50;
                        }
                        else if (c21 == 4)
                        {
                            p21 = 66.67;
                        }
                        else if (c21 == 5)
                        {
                            p21 = 83.33;
                        }
                        else if (c21 == 6)
                        {
                            p21 = 100;
                        }
                        //Scabies 2
                        if (c22 == 0)
                        {
                            p22 = 0;
                        }
                        else if (c22 == 1)
                        {
                            p22 = 50;
                        }
                        else if (c22 == 2)
                        {
                            p22 = 100;
                        }
                        //Shingles 4
                        if (c23 == 0)
                        {
                            p23 = 0;
                        }
                        else if (c23 == 1)
                        {
                            p23 = 25;
                        }
                        else if (c23 == 2)
                        {
                            p23 = 50;
                        }
                        else if (c23 == 3)
                        {
                            p23 = 75;
                        }
                        else if (c23 == 4)
                        {
                            p23 = 100;
                        }
                        //Streptococcal 6
                        if (c24 == 0)
                        {
                            p24 = 0;
                        }
                        else if (c24 == 1)
                        {
                            p24 = 16.67;
                        }
                        else if (c24 == 2)
                        {
                            p24 = 33.33;
                        }
                        else if (c24 == 3)
                        {
                            p24 = 50;
                        }
                        else if (c24 == 4)
                        {
                            p24 = 66.67;
                        }
                        else if (c24 == 5)
                        {
                            p24 = 83.33;
                        }
                        else if (c24 == 6)
                        {
                            p24 = 100;
                        }
                        //SwimmersItch 3
                        if (c25 == 0)
                        {
                            p25 = 0;
                        }
                        else if (c25 == 1)
                        {
                            p25 = 33.33;
                        }
                        else if (c25 == 2)
                        {
                            p25 = 66.67;
                        }
                        else if (c25 == 3)
                        {
                            p25 = 100;
                        }
                        //Tonsillitis 5
                        if (c26 == 0)
                        {
                            p26 = 0;
                        }
                        else if (c26 == 1)
                        {
                            p26 = 20;
                        }
                        else if (c26 == 2)
                        {
                            p26 = 40;
                        }
                        else if (c26 == 3)
                        {
                            p26 = 60;
                        }
                        else if (c26 == 4)
                        {
                            p26 = 80;
                        }
                        else if (c26 == 5)
                        {
                            p26 = 100;
                        }

                        var ValueActivity = new Intent(this, typeof(IllDesc));
                        //if (arrchoices.Count <= 1)
                        //{
                        //    Toast.MakeText (this,)
                        //}
                        if (p1 > p2 && p1 > p3 && p1 > p4 && p1 > p5 && p1 > p6 && p1 > p7 && p1 > p8 && p1 > p9 && p1 > p10 && p1 > p11 && p1 > p12 && p1 > p13 && p1 > p14 && p1 > p15 && p1 > p16 && p1 > p17 && p1 > p18 && p1 > p19 && p1 > p20 && p1 > p21 && p1 > p22 && p1 > p23 && p1 > p24 && p1 > p25 && p1 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Abscess. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Abscess (Surrounding cellulitis)");
                                ValueActivity.PutExtra("iDesc", "Infection can cause a collection of pus in almost any area of the body.");
                                ValueActivity.PutExtra("iSymp", "• Tenderness and fluctuant mass \n• Swelling \n• Fever:37.4°C - 38.2°C ");
                                ValueActivity.PutExtra("iTreat", "• Apply warm compress to the infected area for 30 minutes 4 times daily \n• Antibiotics: cloxacillin(25–50 mg / kg   four times a day) for 5 days or until surrounding cellulitis resolves.\n• You may also take Co - Amoarclaw 30mg / kg every 8 hours");
                                ValueActivity.PutExtra("iPrev", "• Make sure to have a good personal hygiene by washing your skin with soap and water regularly. /n• Avoiding sweat moisture by changing to dry clothes");
                                ValueActivity.PutExtra("iDoc", "• Seek a doctor if the sore getting big and painful. \n• Possible incision and drinage");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p2 > p1 && p2 > p3 && p2 > p4 && p2 > p5 && p2 > p6 && p2 > p7 && p2 > p8 && p2 > p9 && p2 > p10 && p2 > p11 && p2 > p12 && p2 > p13 && p2 > p14 && p2 > p15 && p2 > p16 && p2 > p17 && p2 > p18 && p2 > p19 && p2 > p20 && p2 > p21 && p2 > p22 && p2 > p23 && p2 > p24 && p2 > p25 && p2 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Acute Sinusitis. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Acute Sinusitis");
                                ValueActivity.PutExtra("iDesc", "Acute sinusitis usually starts as a  allergic viral respiratory infection. With acute sinusitis occurring from 1 week to less than 4 weeks after onset of symptoms");
                                ValueActivity.PutExtra("iSymp", "• Facial pain \n• Nasal obstruction the of difficulty breathing \n• Headache \n• Coryza \n• Fever(sometimes)");
                                ValueActivity.PutExtra("iTreat", "• Have a good rest \n• Drink lots of  fluids \n• Have a nasal irrigation \n• Paracetamol 10mg / kg / dose of 4H in fever ≥38⁰c");
                                ValueActivity.PutExtra("iPrev", "• Make sure to follow hand washing guidelines \n• Avoid person who has common cold or influenza \n• Avoid contact with smoke, powder and perfume");
                                ValueActivity.PutExtra("iDoc", "Seek a doctor if the child condition getting worse.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p3 > p1 && p3 > p2 && p3 > p4 && p3 > p5 && p3 > p6 && p3 > p7 && p3 > p8 && p3 > p9 && p3 > p10 && p3 > p11 && p3 > p12 && p3 > p13 && p3 > p14 && p3 > p15 && p3 > p16 && p3 > p17 && p3 > p18 && p3 > p19 && p3 > p20 && p3 > p21 && p3 > p22 && p3 > p23 && p3 > p24 && p3 > p25 && p3 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Asthma. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Asthma");
                                ValueActivity.PutExtra("iDesc", "It is a particular disease to children. This can make the child having the difficulty in breathing and some coughing.");
                                ValueActivity.PutExtra("iSymp", "• Shortness of Breath \n• Wheezing \n• Chest Tightness \n• Cough \n• Fever(sometimes)");
                                ValueActivity.PutExtra("iTreat", "• Have a 6 to 8 inch blocks to elevate the head of your bed. \n• Avoid contact with the smoke of the tabacco.\n• Paracetamol 10mg / kg / dose every 4 hours temperature ≥ 38⁰c");
                                ValueActivity.PutExtra("iPrev", "• Once a week wash the bed sheets and blankets once a week. \n• Avoid contact with furred animals or feathers for a long time, tobacco smoke, powder and perfume.");
                                ValueActivity.PutExtra("iDoc", "When the symptoms are getting worsening and the shortness of the breath with a minimal activity only seek a doctor right away.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p4 > p1 && p4 > p3 && p4 > p2 && p4 > p5 && p4 > p6 && p4 > p7 && p4 > p8 && p4 > p9 && p4 > p10 && p4 > p11 && p4 > p12 && p4 > p13 && p4 > p14 && p4 > p15 && p4 > p16 && p4 > p17 && p4 > p18 && p4 > p19 && p4 > p20 && p4 > p21 && p4 > p22 && p4 > p23 && p4 > p24 && p4 > p25 && p4 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Chickenpox. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Chickenpox");
                                ValueActivity.PutExtra("iDesc", "This illness is caused by varicella-zoster virus.");
                                ValueActivity.PutExtra("iSymp", "• Light Fever \n• Blister rashes, it usually come out on the body, face and then to the limbs.");
                                ValueActivity.PutExtra("iTreat", "• Cut finger nails to prevent scratching \n• Take antihistamines in order to reduce the itch of the rash \n• Baking soda paste may also help you to ease the itch. \n• Paracetamol 10mg / kg / dose every 4 hours temperature ≥ 38⁰c");
                                ValueActivity.PutExtra("iPrev", "• Vaccination starts at 1 year old for  2 doses \n• Prevent near contact to persons who are pregnant");
                                ValueActivity.PutExtra("iDoc", "If the immune response of the person is reducing due to the illness should seek a doctor right away.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        //QUESTION MARK!
                        //QUESTION MARK!
                        //QUESTION MARK!
                        //QUESTION MARK!
                        //QUESTION MARK!
                        //QUESTION MARK!
                        else if (p6 > p1 && p6 > p3 && p6 > p4 && p6 > p5 && p6 > p2 && p6 > p7 && p6 > p8 && p6 > p9 && p6 > p10 && p6 > p11 && p6 > p12 && p6 > p13 && p6 > p14 && p6 > p15 && p6 > p16 && p6 > p17 && p6 > p18 && p6 > p19 && p6 > p20 && p6 > p21 && p6 > p22 && p6 > p23 && p6 > p24 && p6 > p25 && p6 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Cold Sores. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Cold Sores");
                                ValueActivity.PutExtra("iDesc", "Cold sore is on the mouth and it caused by herpes simple type virus.");
                                ValueActivity.PutExtra("iSymp", "• Fever \n• Sore Throat \n• Blister with a Red Base");
                                ValueActivity.PutExtra("iTreat", "• Avoid eating some spicy foods and acidic.");
                                ValueActivity.PutExtra("iPrev", "• Ensure the child have indirect contact to the child having a cold sores. \n Make sure the child do not share infectious material to prevent the transmission of the virus.");
                                ValueActivity.PutExtra("iDoc", "If the cold sores last for a week seek a doctor.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p5 > p1 && p5 > p3 && p5 > p4 && p5 > p2 && p5 > p6 && p5 > p7 && p5 > p8 && p5 > p9 && p5 > p10 && p5 > p11 && p5 > p12 && p5 > p13 && p5 > p14 && p5 > p15 && p5 > p16 && p5 > p17 && p5 > p18 && p5 > p19 && p5 > p20 && p5 > p21 && p5 > p22 && p5 > p23 && p5 > p24 && p5 > p25 && p5 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Croup. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Croup");
                                ValueActivity.PutExtra("iDesc", "It is an infection of the throat. Caused by a virus that the throat becomes red and swollen. Ages 5 years it is called croup but for adults it called as laryngitis.");
                                ValueActivity.PutExtra("iSymp", "\nRaspy voice \n Cough that sounds like a bark \n Noisy breathing");
                                ValueActivity.PutExtra("iTreat", "\nKeep your child calm when it cries to have a good breathing \n Warm mist - Have warm water and the door close in the bathroom then sit the child so it can breathe the mist of the warm water");
                                ValueActivity.PutExtra("iPrev", "Avoid your child touching the hand of the other child who have croup and object that has been contaminated with the virus.");
                                ValueActivity.PutExtra("iDoc", "If the condition get worse the breathing of the child is hard and last for a 3 to 5 days seek doctor assistance right away.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p7 > p1 && p7 > p3 && p7 > p4 && p7 > p5 && p7 > p6 && p7 > p2 && p7 > p8 && p7 > p9 && p7 > p10 && p7 > p11 && p7 > p12 && p7 > p13 && p7 > p14 && p7 > p15 && p7 > p16 && p7 > p17 && p7 > p18 && p7 > p19 && p7 > p20 && p7 > p21 && p7 > p22 && p7 > p23 && p7 > p24 && p7 > p25 && p7 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Hand/Foot/Mouth Disease(Coxsackie virus). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Hand/Foot/Mouth Disease(Coxsackie virus)");
                                ValueActivity.PutExtra("iDesc", "It is caused by coxsackie virus in it common in summer and children ages 10 years of age");
                                ValueActivity.PutExtra("iSymp", "\nSudden onset Fever \n Greyish blister on palms and finger \n Sore throat");
                                ValueActivity.PutExtra("iTreat", "Control fever with acetaminophen");
                                ValueActivity.PutExtra("iPrev", "\nMake sure the child hands are clean and have a proper hygiene measures in home.");
                                ValueActivity.PutExtra("iDoc", "Call the doctor if the child condition getting worse and last for a week.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p8 > p1 && p8 > p3 && p8 > p4 && p8 > p5 && p8 > p6 && p8 > p7 && p8 > p2 && p8 > p9 && p8 > p10 && p8 > p11 && p8 > p12 && p8 > p13 && p8 > p14 && p8 > p15 && p8 > p16 && p8 > p17 && p8 > p18 && p8 > p19 && p8 > p20 && p8 > p21 && p8 > p22 && p8 > p23 && p8 > p24 && p8 > p25 && p8 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Impetigo. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Impetigo");
                                ValueActivity.PutExtra("iDesc", "Common skin infection come from group A streptococcal  (strep) bacteria. Infection starts from a insect bite of scratch.  This kind of bacteria is common during summer.");
                                ValueActivity.PutExtra("iSymp", "\nClusters of blisters \n Sores \n Ooze fluid from the blisters and becomes yellow crusted sores \n Appear first in the face.");
                                ValueActivity.PutExtra("iTreat", "\nPut some antibiotic ointment or cream on the sores \n Co - Amoxiclar 30mg / kg / dose");
                                ValueActivity.PutExtra("iPrev", "\nEnsure the child do not touch the infection \n Keep the child nails short and clean. \n Proper hygiene and keep skin clean and dry(no sweat) or change frequently when wet.");
                                ValueActivity.PutExtra("iDoc", "If the rash did not drain after 24 hours of antibiotic treatment the child should seek a doctor.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p9 > p1 && p9 > p3 && p9 > p4 && p9 > p5 && p9 > p6 && p9 > p7 && p9 > p8 && p9 > p2 && p9 > p10 && p9 > p11 && p9 > p12 && p9 > p13 && p9 > p14 && p9 > p15 && p9 > p16 && p9 > p17 && p9 > p18 && p9 > p19 && p9 > p20 && p9 > p21 && p9 > p22 && p9 > p23 && p9 > p24 && p9 > p25 && p9 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Influenza. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Influenza");
                                ValueActivity.PutExtra("iDesc", "These are frequent to children because they do not have enough immunologic knowledge with the influenza virus. The rate of infection to children is greater than to the adults.Influenza virus has three types A / H1N1, A / H3N2, B.");
                                ValueActivity.PutExtra("iSymp", "\nFever  \nDiarrhea \n Vomiting \n Abdominal pain");
                                ValueActivity.PutExtra("iTreat", "\nMore time of bed rest \n Drink plenty of fluids to prevent dehydration \n Consider pain relievers to lessen the achiness of the influenza.");
                                ValueActivity.PutExtra("iPrev", "Have a personal hygiene, drink lots of fluids and have a enough bed rest.");
                                ValueActivity.PutExtra("iDoc", "If the symptoms keep returning and the fever getting worse than before, you will need to seek the doctor for a medical assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p10 > p1 && p10 > p3 && p10 > p4 && p10 > p5 && p10 > p6 && p10 > p7 && p10 > p8 && p10 > p9 && p10 > p2 && p10 > p11 && p10 > p12 && p10 > p13 && p10 > p14 && p10 > p15 && p10 > p16 && p10 > p17 && p10 > p18 && p10 > p19 && p10 > p20 && p10 > p21 && p10 > p22 && p10 > p23 && p10 > p24 && p10 > p25 && p10 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Laryngotracheal Bronchitis. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Laryngotracheal Bronchitis");
                                ValueActivity.PutExtra("iDesc", "Laryngotracheal Bronchitis, or croup is a slowly progressive 'mild' self limited viral inflammation of subglottic larynx usually occurring in infants and young children.");
                                ValueActivity.PutExtra("iSymp", "\n Hoarse Voice \n Swallowing \n BarkingCough \n Fever(38.3celcius) \n Drooling");
                                ValueActivity.PutExtra("iTreat", "\n Racemic Epinephrine - For mild cases, the patient should be well hydrated.In more severe cases  nebulized epinephrine  used as a musocal vasoconstrictor may provide relief.Patients being treated in this manner usually are observed in the hospital for 2 - 6 hours after treatment.");
                                ValueActivity.PutExtra("iPrev", "Typically worsens when the patient is active or upset, and also improves with warm humidified air.");
                                ValueActivity.PutExtra("iDoc", "Visit the doctor when experiencing severe cases.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p11 > p1 && p11 > p3 && p11 > p4 && p11 > p5 && p11 > p6 && p11 > p7 && p11 > p8 && p11 > p9 && p11 > p10 && p11 > p12 && p11 > p2 && p11 > p13 && p11 > p14 && p11 > p15 && p11 > p16 && p11 > p17 && p11 > p18 && p11 > p19 && p11 > p20 && p11 > p21 && p11 > p22 && p11 > p23 && p11 > p24 && p11 > p25 && p11 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Lice Head Lice Pediculosis (insect). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Lice Head Lice Pediculosis (insect)");
                                ValueActivity.PutExtra("iDesc", "Lice are ectoparasitic insects, the head louse, the most common causes of forming of louse infestation. Girls are more susceptible than boys. The condition is transmitted via combs, brushes, shared of hats, towels or beddings.");
                                ValueActivity.PutExtra("iSymp", "\nThe hair has small white eggs (nits) firmly attached to the hair shaft especially around ears and nape of neck \n Itchiness \n Grey - white sometimes brown adult lice whose 1 - 2 mm long");
                                ValueActivity.PutExtra("iTreat", "\n Treat the case with special shampoo/rinse available at drugstore Permethrin shampoo or Pyrethrin combined with piperonyl butoxide products. Follow package directions carefully \n Remove nits \n Wash clothes and linens in hot water, or dry clean.Retreat in 7 - 10 days.");
                                ValueActivity.PutExtra("iPrev", "To Prevent this Check young children routine\nDo not borrow or share combs, hair accessories or other head gear.");
                                ValueActivity.PutExtra("iDoc", "If over the counter shampoos doesn't give an effect, seek doctor assistance ");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p12 > p1 && p12 > p3 && p12 > p4 && p12 > p5 && p12 > p6 && p12 > p7 && p12 > p8 && p12 > p9 && p12 > p10 && p12 > p11 && p12 > p2 && p12 > p13 && p12 > p14 && p12 > p15 && p12 > p16 && p12 > p17 && p12 > p18 && p12 > p19 && p12 > p20 && p12 > p21 && p12 > p22 && p12 > p23 && p12 > p24 && p12 > p25 && p12 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Measles. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Measles");
                                ValueActivity.PutExtra("iDesc", "Caused by measles virus");
                                ValueActivity.PutExtra("iSymp", "\nFever \n inflamed eyes \n dry cough \n runny nose \n dusky red rash 3 - 7 days later will spread downwards starting from the face and white spots in mouth.");
                                ValueActivity.PutExtra("iTreat", "\nControl fever \n Treat with fluids \n If eyes are sensitive wear sunglass.");
                                ValueActivity.PutExtra("iPrev", "Immunization against measles starting at 9 months old may be given as early as 6 months during measles epidemic 2nd doseMMN at 1 3 / 12 years 3rd dose MMN at 4years old maybe given 3 months after 2nd dose");
                                ValueActivity.PutExtra("iDoc", "Seek medicine consult if symptoms gets worse like if there is seizure , fast breathing or weakness");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p13 > p1 && p13 > p3 && p13 > p4 && p13 > p5 && p13 > p6 && p13 > p7 && p13 > p8 && p13 > p9 && p13 > p10 && p13 > p11 && p13 > p12 && p13 > p2 && p13 > p14 && p13 > p15 && p13 > p16 && p13 > p17 && p13 > p18 && p13 > p19 && p13 > p20 && p13 > p21 && p13 > p22 && p13 > p23 && p13 > p24 && p13 > p25 && p13 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Meningococcal Meningitis (Bacterial). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Meningococcal Meningitis (Bacterial)");
                                ValueActivity.PutExtra("iDesc", "One of the causes of bacterial meningitis is meningococur (Nessecia meningitilz) bacteria");
                                ValueActivity.PutExtra("iSymp", "\nFever \n Intense \n headache \n Nausea \n Vomiting \n Stiff neck \n Irritability \n Poor appetite \n And often a pinpoint rash.");
                                ValueActivity.PutExtra("iTreat", "\nHospitalization \n Appropriate antibiotic therapy \n Notify health unit isolation");
                                ValueActivity.PutExtra("iPrev", "Immunization during outbreaks, where appropriate.");
                                ValueActivity.PutExtra("iDoc", "See a doctor to Confirm with test of blood and cerebral spinal fluid");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p14 > p1 && p14 > p3 && p14 > p4 && p14 > p5 && p14 > p6 && p14 > p7 && p14 > p8 && p14 > p9 && p14 > p10 && p14 > p11 && p14 > p12 && p14 > p13 && p14 > p2 && p14 > p15 && p14 > p16 && p14 > p17 && p14 > p18 && p14 > p19 && p14 > p20 && p14 > p21 && p14 > p22 && p14 > p23 && p14 > p24 && p14 > p25 && p14 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Mononucleosis (Epstein-Barr virus). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Mononucleosis (Epstein-Barr virus)");
                                ValueActivity.PutExtra("iDesc", "Mononucleosis is a systematic, febrile, self-limited lymphoproliferative disorder that is usually associated with hepatosplenomegaly and generalized lymphadenopathy.");
                                ValueActivity.PutExtra("iSymp", "\nAcute fever \nSore throat \nSwollen glands \nTiredness.");
                                ValueActivity.PutExtra("iTreat", "\n Promote rest \n Increase fluids \n Have good nutrition \n Control fever.");
                                ValueActivity.PutExtra("iPrev", "To prevent this have good hygiene, careful hand-washing.");
                                ValueActivity.PutExtra("iDoc", "See a physician if the condition getting worse.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p15 > p1 && p15 > p3 && p15 > p4 && p15 > p5 && p15 > p6 && p15 > p7 && p15 > p8 && p15 > p9 && p15 > p10 && p15 > p11 && p15 > p12 && p15 > p13 && p15 > p14 && p15 > p2 && p15 > p16 && p15 > p17 && p15 > p18 && p15 > p19 && p15 > p20 && p15 > p21 && p15 > p22 && p15 > p23 && p15 > p24 && p15 > p25 && p15 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Mumps (Parotitis). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Mumps (Parotitis)");
                                ValueActivity.PutExtra("iDesc", "Mumps the inflammation of the salivary glands causing the cheeks to swell painfully");
                                ValueActivity.PutExtra("iSymp", "\nFever \nHeadache");
                                ValueActivity.PutExtra("iTreat", "Paracetamol for fever");
                                ValueActivity.PutExtra("iPrev", "To prevent this must have measles, mumps, rubella vaccine (given at age 12 months and 18 months). \n immunomodulators");
                                ValueActivity.PutExtra("iDoc", "See a physician whenever feeling some of the symptoms");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p16 > p1 && p16 > p3 && p16 > p4 && p16 > p5 && p16 > p6 && p16 > p7 && p16 > p8 && p16 > p9 && p16 > p10 && p16 > p11 && p16 > p12 && p16 > p13 && p16 > p14 && p16 > p15 && p16 > p2 && p16 > p17 && p16 > p18 && p16 > p19 && p16 > p20 && p16 > p21 && p16 > p22 && p16 > p23 && p16 > p24 && p16 > p25 && p16 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Pertussis “Whooping cough” (bacteria). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Pertussis “Whooping cough” (bacteria)");
                                ValueActivity.PutExtra("iDesc", "Pertussis is a relatively common cause of lower respiratory tract infection in infants, children, adolescents, and adults, especially in those who are under immunized or noimmunized.");
                                ValueActivity.PutExtra("iSymp", "\nRunny nose \n Violent coughing with characteristic Whoop \n Sometimes will followed by a vomiting");
                                ValueActivity.PutExtra("iTreat", "\nAntibiotic treatment \n See physician");
                                ValueActivity.PutExtra("iPrev", "To prevent this you need to get Age-appropriate immunization.");
                                ValueActivity.PutExtra("iDoc", "See a doctor to confirm with lab test");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p17 > p1 && p17 > p3 && p17 > p4 && p17 > p5 && p17 > p6 && p17 > p7 && p17 > p8 && p17 > p9 && p17 > p10 && p17 > p11 && p17 > p12 && p17 > p13 && p17 > p14 && p17 > p15 && p17 > p16 && p17 > p2 && p17 > p18 && p17 > p19 && p17 > p20 && p17 > p21 && p17 > p22 && p17 > p23 && p17 > p24 && p17 > p25 && p17 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Pertussis “Whooping cough” (bacteria). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Pink Eye (conjuintivitis)");
                                ValueActivity.PutExtra("iDesc", "The presence of blurring of vision, pain or itching, and the characteristics of any discharge (watery,mucoid, purulent) Swelling of eyelids after block of follicle");
                                ValueActivity.PutExtra("iSymp", "\nTeary \n Irritated itchy eyes with swollen lids and thick yellow discharge \n If sensitive to sunlight. \n itchiness of eyelid");
                                ValueActivity.PutExtra("iTreat", "\nAvoid touching eyes \n Wash hands often \n Co Amoxiclar 30mg / kg / day");
                                ValueActivity.PutExtra("iPrev", "\nTo prevent this should have good personal hygiene, and careful hand washing. \n Keep the hands away from the eyes. \n Do not share towels, or bed linen.avoid toys getting close to the face. \n proper hygiene, avoid touching and proper hand washing frequently");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance. See ophthalmologist");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p18 > p1 && p18 > p3 && p18 > p4 && p18 > p5 && p18 > p6 && p18 > p7 && p18 > p8 && p18 > p9 && p18 > p10 && p18 > p11 && p18 > p12 && p18 > p13 && p18 > p14 && p18 > p15 && p18 > p16 && p18 > p17 && p18 > p2 && p18 > p19 && p18 > p20 && p18 > p21 && p18 > p22 && p18 > p23 && p18 > p24 && p18 > p25 && p18 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Respiratory Syncytial Virus(RSV). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Respiratory Syncytial Virus(RSV)");
                                ValueActivity.PutExtra("iDesc", "RSV is a common virus that infects the child’s lungs and respiratory tract by the age of 2.");
                                ValueActivity.PutExtra("iSymp", "\nInactivity \n listlessness \n low grade fever or chills \n Cough \n earache \n rapid breathing or wheezing \n poor feeding \n decreased interest in surroundings, stuffy or runny nose");
                                ValueActivity.PutExtra("iTreat", "\nDo not use, cold medicines, antihistamines or decongestants, antibiotics. \n Drink plenty of water.");
                                ValueActivity.PutExtra("iPrev", "Good personal hygiene and always wash your hands");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p19 > p1 && p19 > p3 && p19 > p4 && p19 > p5 && p19 > p6 && p19 > p7 && p19 > p8 && p19 > p9 && p19 > p10 && p19 > p11 && p19 > p12 && p19 > p13 && p19 > p14 && p19 > p15 && p19 > p16 && p19 > p17 && p19 > p18 && p19 > p2 && p19 > p20 && p19 > p21 && p19 > p22 && p19 > p23 && p19 > p24 && p19 > p25 && p19 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Ringworm. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Ringworm");
                                ValueActivity.PutExtra("iDesc", "Ringworm is a fungal skin infection that can be found on the scalp, body, groin, or feet.");
                                ValueActivity.PutExtra("iSymp", "\nIf ringworm infection is on the scalp, there may be patches of hairloss or hair thinning , rash may be dry and scaly or wet and crusty, \n ring shaped rash that is reddish and may be itchy");
                                ValueActivity.PutExtra("iTreat", "\nSee physician for appropriate treatment.");
                                ValueActivity.PutExtra("iPrev", "Keep the affected areas clean and dry and wash it every day.");
                                ValueActivity.PutExtra("iDoc", "See physician for proper treatment");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p20 > p1 && p20 > p3 && p20 > p4 && p20 > p5 && p20 > p6 && p20 > p7 && p20 > p8 && p20 > p9 && p20 > p10 && p20 > p11 && p20 > p12 && p20 > p13 && p20 > p14 && p20 > p15 && p20 > p16 && p20 > p17 && p20 > p18 && p20 > p19 && p20 > p2 && p20 > p21 && p20 > p22 && p20 > p23 && p20 > p24 && p20 > p25 && p20 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Roseola Infantum (Sixth Disease). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Roseola Infantum (Sixth Disease)");
                                ValueActivity.PutExtra("iDesc", "Roseola Infantum is a rash disease caused by a virus. It’s commonly affecting the children between the ages of 6 months to 2 years old.");
                                ValueActivity.PutExtra("iSymp", "\nRash usually develops as fever is resolving \n rosy – pink rash develops first on neck and chest and then spreads to rest of the body \n the spots(rash) turn white if you gently press on them and they may have a lighter color ring around them \nswelling of eyelids may occur \nfever(usually = 39.5°C) appears suddenly and lasts 3 – 5 days \n Rash usually lasts 1 – 2 days Febrile seizures may occur.");
                                ValueActivity.PutExtra("iTreat", "Drink  acetaminophen  to control the fever.");
                                ValueActivity.PutExtra("iPrev", "Always wash your hand.");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p21 > p1 && p21 > p3 && p21 > p4 && p21 > p5 && p21 > p6 && p21 > p7 && p21 > p8 && p21 > p9 && p21 > p10 && p21 > p11 && p21 > p12 && p21 > p13 && p21 > p14 && p21 > p15 && p21 > p16 && p21 > p17 && p21 > p18 && p21 > p19 && p21 > p20 && p21 > p2 && p21 > p22 && p21 > p23 && p21 > p24 && p21 > p25 && p21 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Salmonellosis (bacteria). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Salmonellosis (bacteria)");
                                ValueActivity.PutExtra("iDesc", "Salmonellosis is an infection with bacteria called Salmonella. Salmonella is a kind of bacteriathat has a many different types. The type that is responsible to the infections of the human is carried by cow, pigs, reptiles and chickens.");
                                ValueActivity.PutExtra("iSymp", "\nDiarrhea \n nausea \n vomiting \nfever \n headache \nabdominal cramps");
                                ValueActivity.PutExtra("iTreat", "\nDrink plenty of fluids. \n Treat fever \n antibiotics");
                                ValueActivity.PutExtra("iPrev", "\nCook your food from animal sources throughly . \n Always clean the areas of your food preparation. \n Wash your hands properly");
                                ValueActivity.PutExtra("iDoc", "See the physician.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p22 > p1 && p22 > p3 && p22 > p4 && p22 > p5 && p22 > p6 && p22 > p7 && p22 > p8 && p22 > p9 && p22 > p10 && p22 > p11 && p22 > p12 && p22 > p13 && p22 > p14 && p22 > p15 && p22 > p16 && p22 > p17 && p22 > p18 && p22 > p19 && p22 > p20 && p22 > p21 && p22 > p2 && p22 > p23 && p22 > p24 && p22 > p25 && p22 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Scabies. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Scabies");
                                ValueActivity.PutExtra("iDesc", "Scabies is a contagious skin disease that is caused by the mite known as the Sarcoptes scabiei");
                                ValueActivity.PutExtra("iSymp", "\nItching and rash may be all over the body between the fingers, wrists, elbows, armpits, groin area, nipples, waist, buttocks, and shoulder blades, tiny burrows \n look like grayish - white or skin - colored lines on the skin may be seen \n a pimple – like rash may be present, intense itching, especially at night");
                                ValueActivity.PutExtra("iTreat", "\nWash your clothes and linen in hot water. \n Buy a special lotion like Permethoin for treatment from drug store and follow the directions carefully. \n Itching may prevent 1 - 2 weeks after the treatment. \n Washing your hands and cutting your  fingernails carefully can prevent secondary infections.  \n Antihistamines may help to reduce or relieve the itching.");
                                ValueActivity.PutExtra("iPrev", "Good personal hygiene, Always keep yourself and your clothes clean, Knowledge about scabies.");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p23 > p1 && p23 > p3 && p23 > p4 && p23 > p5 && p23 > p6 && p23 > p7 && p23 > p8 && p23 > p9 && p23 > p10 && p23 > p11 && p23 > p12 && p23 > p13 && p23 > p14 && p23 > p15 && p23 > p16 && p23 > p17 && p23 > p18 && p23 > p19 && p23 > p20 && p23 > p21 && p23 > p22 && p23 > p2 && p23 > p24 && p23 > p25 && p23 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Shingles. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Shingles");
                                ValueActivity.PutExtra("iDesc", "Shingles is also called herpes zoster. It is an infection that causes a painful rash. A reactivates of provinely affected varicella zoster called chicken pox");
                                ValueActivity.PutExtra("iSymp", "\npainful blisters usually scab over in about 3 – 5 days and disappear after 2to 4 weeks, blister-type rash that develops in the same area as pain and tingling, pain itching, or tingling along the affected nerve pathway due to nerve involment");
                                ValueActivity.PutExtra("iTreat", "Acyclovir");
                                ValueActivity.PutExtra("iPrev", "\nAvoid contact or communicate with people whose immunity may be reduced due to drug/ radiation  or disease therapy like pregnant women");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p24 > p1 && p24 > p3 && p24 > p4 && p24 > p5 && p24 > p6 && p24 > p7 && p24 > p8 && p24 > p9 && p24 > p10 && p24 > p11 && p24 > p12 && p24 > p13 && p24 > p14 && p24 > p15 && p24 > p16 && p24 > p17 && p24 > p18 && p24 > p19 && p24 > p20 && p24 > p21 && p24 > p22 && p24 > p23 && p24 > p2 && p24 > p25 && p24 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Streptococcal Infections: Scarlet Fever and Strep Throat. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Streptococcal Infections: Scarlet Fever and Strep Throat");
                                ValueActivity.PutExtra("iDesc", "Strep throat and scarlet fever are both caused by streptococcal bacteria. Untreated streptococcal infection may result of Rheumatic fever");
                                ValueActivity.PutExtra("iSymp", "\nRed, swollen lips, strawberry – like tongue, \n nausea \n vomiting \n red rash that looks like sunburn and feels like rough sandpaper, flushed cheeks and pale area around mouth \n fever, rash most often begins on chest and stomach and then spreads to, rest of body \n rash usually lasts 2 – 7 days, when rash fades, skin on hands and feet may start to peel, \nsore throat");
                                ValueActivity.PutExtra("iTreat", "\nfor antibiotic treatment therapy, see the physician. \n To prevent the result of rheumatic heart disease, ensure full course of antibiotics. \n Drink acetaminophen to control the fever");
                                ValueActivity.PutExtra("iPrev", "Proper food-handling and hand-washing.");
                                ValueActivity.PutExtra("iDoc", "See the physician for more treatment.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p25 > p1 && p25 > p3 && p25 > p4 && p25 > p5 && p25 > p6 && p25 > p7 && p25 > p8 && p25 > p9 && p25 > p10 && p25 > p11 && p25 > p12 && p25 > p13 && p25 > p14 && p25 > p15 && p25 > p16 && p25 > p17 && p25 > p18 && p25 > p19 && p25 > p20 && p25 > p21 && p25 > p22 && p25 > p23 && p25 > p2 && p25 > p24 && p25 > p26)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Swimmer’s Itch. Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Swimmer’s Itch");
                                ValueActivity.PutExtra("iDesc", "Swimmer’s itch is a itchy skin rash caused by very tiny parasites");
                                ValueActivity.PutExtra("iSymp", "\nSmall blisters \n small reddish pimples \n tingling \n burning, or itching of the skin(itching can be severe)");
                                ValueActivity.PutExtra("iTreat", "\nAvoid scratching the affected areas. \nYou can use use antihistamines, calamine, warm water with baking soda, apply cool compresses for the treatment");
                                ValueActivity.PutExtra("iPrev", "\nApplying waterproof sunscreen when you go swimming. \n Use dry towel right after leaving the water. \n Ideally, take a bath immediately after swimming, then use dry towel");
                                ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (p26 > p1 && p26 > p3 && p26 > p4 && p26 > p5 && p26 > p6 && p26 > p7 && p26 > p8 && p26 > p9 && p26 > p10 && p26 > p11 && p26 > p12 && p26 > p13 && p26 > p14 && p26 > p15 && p26 > p16 && p26 > p17 && p26 > p18 && p26 > p19 && p26 > p20 && p26 > p21 && p26 > p22 && p26 > p23 && p26 > p2 && p26 > p25 && p26 > p24)
                        {
                            Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                            alert.SetTitle("Diagnose");
                            alert.SetMessage("Hi there " + name + "! Age: " + age + ", Gender: " + gender + ". Based on your selected inputs, You might have a(n) Tonsillitis(ATP). Kindly visit your Doctor for clarification");
                            alert.SetPositiveButton("View", (senderAlert, args) => {
                                ValueActivity.PutExtra("iName", "Tonsillitis(ATP)");
                                ValueActivity.PutExtra("iDesc", "It is an inflammation of the tonsils");
                                ValueActivity.PutExtra("iSymp", "\nVomiting \n Headache \n Difficult and painful of swallowing \n Swollen red tonsils with white spots \n Sore throat - last longer than 48hours");
                                ValueActivity.PutExtra("iTreat", "\nMake sure to drink lots of fluids \n Amoxicillin 15 - 30 mg / kg / dose Q8h for 10 days \n co amoxiclar 30mg / kg / day \n gargle bactidol 3x a day");
                                ValueActivity.PutExtra("iPrev", "Avoidance of sugary foods  “sweets” increase oval fluids intake");
                                ValueActivity.PutExtra("iDoc", "Seek doctor if the condition getting worse.");
                                StartActivity(ValueActivity);
                            });

                            alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else
                        {
                            Toast.MakeText(this, "MPD can't diagnose your symptoms. Please Consult a Doctor Immediately!", ToastLength.Short).Show();
                        }
                    }
                
            };
        }

        private void Cb1_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb1.Checked == true)
            {
                arrchoices.Add("Abdominal Cramps");
            }
            else if (cb1.Checked == false)
            {
                arrchoices.Remove("Abdominal Cramps");
            }
        }
        private void Cb2_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb2.Checked == true)
            {
                arrchoices.Add("Difficulty of breathing");
                c2 += 1;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
            }
            else if (cb2.Checked == false)
            {
                c2 -= 1;
                arrchoices.Remove("Difficulty of breathing");
                cb3.Enabled = true;
                cb4.Enabled = true;
                cb5.Enabled = true;
            }
        }
        private void Cb3_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb3.Checked == true)
            {
                arrchoices.Add("Noisy breathing");
                cb2.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
            }
            else if (cb3.Checked == false)
            {
                arrchoices.Remove("Noisy breathing");
                cb2.Enabled = true;
                cb4.Enabled = true;
                cb5.Enabled = true;
            }
        }
        private void Cb4_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb4.Checked == true)
            {
                arrchoices.Add("Rapid breathing");
                cb3.Enabled = false;
                cb2.Enabled = false;
                cb5.Enabled = false;
            }
            else if (cb4.Checked == false)
            {
                arrchoices.Remove("Rapid breathing");
                cb3.Enabled = true;
                cb2.Enabled = true;
                cb5.Enabled = true;
            }
        }
        private void Cb5_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb5.Checked == true)
            {
                arrchoices.Add("Shortness of breath");
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb2.Enabled = false;
                c3 += 1;
            }
            else if (cb5.Checked == false)
            {
                arrchoices.Remove("Shortness of breath");
                cb3.Enabled = true;
                cb4.Enabled = true;
                cb2.Enabled = true;
                c3 -= 1;
            }
        }
        private void Cb6_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb6.Checked == true)
            {
                c3 += 1;
                arrchoices.Add("Chest tightness");
            }
            else if (cb6.Checked == false)
            {
                c3 -= 1;
                arrchoices.Remove("Chest tightness");
            }
        }
        private void Cb7_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb7.Checked == true)
            {
                arrchoices.Add("Chills");
                c18 += 1;
            }
            else if (cb7.Checked == false)
            {
                arrchoices.Remove("Chills");
                c18 -= 1;
            }
        }
        private void Cb8_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb8.Checked == true)
            {
                arrchoices.Add("Coryza");
                c2 += 1;
            }
            else if (cb8.Checked == false)
            {
                arrchoices.Remove("Coryza");
                c2 -= 1;
            }
        }
        private void Cb9_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb9.Checked == true)
            {
                arrchoices.Add("Cough");
                c18 += 1;
                c3 += 1;
                c5 += 1;
                c6 += 1;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
            }
            else if (cb9.Checked == false)
            {
                arrchoices.Remove("Cough");
                c18 -= 1;
                c3 -= 1;
                c5 -= 1;
                c6 -= 1;
                cb10.Enabled = true;
                cb11.Enabled = true;
                cb12.Enabled = true;
                cb13.Enabled = true;
            }
        }
        private void Cb10_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb10.Checked == true)
            {
                arrchoices.Add("Barking cough like a raspy or hoarse voice");
                c5 += 1;
                c10 += 1;
                cb9.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
            }
            else if (cb10.Checked == false)
            {
                arrchoices.Remove("Barking cough like a raspy or hoarse voice");
                c5 -= 1;
                c10 -= 1;
                cb9.Enabled = true;
                cb11.Enabled = true;
                cb12.Enabled = true;
                cb13.Enabled = true;
            }
        }
        private void Cb11_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb11.Checked == true)
            {
                arrchoices.Add("Dry cough");
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                c12 += 1;
            }
            else if (cb11.Checked == false)
            {
                arrchoices.Remove("Dry cough");
                cb9.Enabled = true;
                cb10.Enabled = true;
                cb12.Enabled = true;
                cb13.Enabled = true;
                c12 -= 1;
            }
        }
        private void Cb12_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb12.Checked == true)
            {
                arrchoices.Add("Normal cough");
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb13.Enabled = false;
            }
            else if (cb12.Checked == false)
            {
                arrchoices.Remove("Normal cough");
                cb9.Enabled = true;
                cb10.Enabled = true;
                cb11.Enabled = true;
                cb13.Enabled = true;
            }
        }
        private void Cb13_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb13.Checked == true)
            {
                arrchoices.Add("Violent coughing");
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb12.Enabled = false;
                cb11.Enabled = false;
                c16 += 1;
            }
            else if (cb13.Checked == false)
            {
                arrchoices.Remove("Violent coughing");
                cb9.Enabled = true;
                cb10.Enabled = true;
                cb12.Enabled = true;
                cb11.Enabled = true;
                c16 += 1;
            }
        }
        private void Cb14_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb14.Checked == true)
            {
                arrchoices.Add("Difficult and painful of swallowing");
                c26 += 1;
            }
            else if (cb14.Checked == false)
            {
                arrchoices.Remove("Difficult and painful of swallowing");
                c26 -= 1;
            }
        }
        private void Cb15_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb15.Checked == true)
            {
                arrchoices.Add("Earache");
                c18 += 1;
            }
            else if (cb15.Checked == false)
            {
                arrchoices.Remove("Earache");
                c18 -= 1;
            }
        }
        private void Cb16_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb16.Checked == true)
            {
                arrchoices.Add("37.4-38.2 C");
                c2 += 1;
                c1 += 1;
                c3 += 1;
                c4 += 1;
                c5 += 1;
                c6 += 1;
                c7 += 1;
                c9 += 1;
                c10 += 1;
                c12 += 1;
                c13 += 1;
                c14 += 1;
                c15 += 1;
                c21 += 1;
                c24 += 1;
                cb17.Enabled = false;
                cb18.Enabled = false;
                cb19.Enabled = false;
            }
            else if (cb16.Checked == false)
            {
                arrchoices.Remove("37.4-38.2 C");
                c2 -= 1;
                c1 -= 1;
                c3 -= 1;
                c4 -= 1;
                c5 -= 1;
                c6 -= 1;
                c7 -= 1;
                c9 -= 1;
                c10 -= 1;
                c12 -= 1;
                c13 -= 1;
                c14 -= 1;
                c15 -= 1;
                c21 -= 1;
                c24 -= 1;
                cb17.Enabled = true;
                cb18.Enabled = true;
                cb19.Enabled = true;
            }
        }
        private void Cb17_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb17.Checked == true)
            {
                arrchoices.Add("38.4-39.2 C");
                cb16.Enabled = false;
                cb18.Enabled = false;
                cb19.Enabled = false;
            }
            else if (cb17.Checked == false)
            {
                arrchoices.Remove("38.4-39.2 C");
                cb16.Enabled = true;
                cb18.Enabled = true;
                cb19.Enabled = true;
            }
        }
        private void Cb18_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb18.Checked == true)
            {
                arrchoices.Add("39.4-40.6 C");
                cb16.Enabled = false;
                cb17.Enabled = false;
                cb19.Enabled = false;
                c20 += 1;
            }
            else if (cb18.Checked == false)
            {
                arrchoices.Remove("39.4-40.6 C");
                cb17.Enabled = true;
                cb16.Enabled = true;
                cb19.Enabled = true;
                c20 -= 1;
            }
        }
        private void Cb19_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb19.Checked == true)
            {
                arrchoices.Add("40.6 C and up");
                cb17.Enabled = false;
                cb18.Enabled = false;
                cb16.Enabled = false;
            }
            else if (cb19.Checked == false)
            {
                arrchoices.Remove("40.6 C and up");
                cb17.Enabled = true;
                cb18.Enabled = true;
                cb16.Enabled = true;
            }
        }
        private void Cb20_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb20.Checked == true)
            {
                arrchoices.Add("Hair has small white egg");
                c11 += 1;
            }
            else if (cb20.Checked == false)
            {
                arrchoices.Remove("Hair has small white egg");
                c11 -= 1;
            }
        }
        private void Cb21_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb21.Checked == true)
            {
                arrchoices.Add("Headache");
                c2 += 1;
                c13 += 1;
                c15 += 1;
                c17 += 1;
                c21 += 1;
                c26 += 1;
            }
            else if (cb21.Checked == false)
            {
                arrchoices.Remove("Headache");
                c2 -= 1;
                c13 -= 1;
                c15 -= 1;
                c17 -= 1;
                c21 -= 1;
                c26 -= 1;
            }
        }
        private void Cb22_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb22.Checked == true)
            {
                arrchoices.Add("Inactivity");
                c18 += 1;
            }
            else if (cb22.Checked == false)
            {
                arrchoices.Remove("Inactivity");
                c18 -= 1;
            }
        }
        private void Cb23_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb23.Checked == true)
            {
                arrchoices.Add("Inflamed eyes");
                c12 += 1;
            }
            else if (cb23.Checked == false)
            {
                arrchoices.Remove("Inflamed eyes");
                c12 -= 1;
            }
        }
        private void Cb24_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb24.Checked == true)
            {
                arrchoices.Add("Intense");
            }
            else if (cb24.Checked == false)
            {
                arrchoices.Remove("Intense");
            }
        }
        private void Cb25_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb25.Checked == true)
            {
                arrchoices.Add("Irritability");
                c13 += 1;
            }
            else if (cb25.Checked == false)
            {
                arrchoices.Remove("Irritability");
                c13 -= 1;
            }
        }
        private void Cb26_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb26.Checked == true)
            {
                arrchoices.Add("Itchiness");
                c18 += 1;
                c11 += 1;
                c19 += 1;
                c22 += 1;
            }
            else if (cb26.Checked == false)
            {
                arrchoices.Remove("Itchiness");
                c18 -= 1;
                c11 -= 1;
                c19 -= 1;
                c22 -= 1;
            }
        }
        private void Cb27_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb27.Checked == true)
            {
                arrchoices.Add("Itchiness of eyelid");
                c17 += 1;
            }
            else if (cb27.Checked == false)
            {
                arrchoices.Remove("Itchiness of eyelid");
                c17 -= 1;
            }
        }
        private void Cb28_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb28.Checked == true)
            {
                arrchoices.Add("Itching of the skin");
                c25 += 1;
            }
            else if (cb28.Checked == false)
            {
                arrchoices.Remove("Itching of the skin");
                c25 -= 1;
            }
        }
        private void Cb29_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb29.Checked == true)
            {
                arrchoices.Add("Listlessness");
                c18 += 1;
            }
            else if (cb29.Checked == false)
            {
                arrchoices.Remove("Listlessness");
                c18 -= 1;
            }
        }
        private void Cb30_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb30.Checked == true)
            {
                arrchoices.Add("Nausea");
                c13 += 1;
                c21 += 1;
                c24 += 1;
            }
            else if (cb30.Checked == false)
            {
                arrchoices.Remove("Nausea");
                c13 -= 1;
                c21 -= 1;
                c24 -= 1;
            }
        }
        private void Cb31_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb31.Checked == true)
            {
                arrchoices.Add("Abdominal pain");
                cb32.Enabled = false;
                cb33.Enabled = false;
                c9 += 1;
                c10 += 1;
                c15 += 1;
                c23 += 1;
            }
            else if (cb31.Checked == false)
            {
                arrchoices.Remove("Abdominal pain");
                cb32.Enabled = true;
                cb33.Enabled = true;
                c9 -= 1;
                c10 -= 1;
                c15 -= 1;
                c23 -= 1;
            }
        }
        private void Cb32_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb32.Checked == true)
            {
                arrchoices.Add("Back Pain");
                cb31.Enabled = false;
                cb33.Enabled = false;
            }
            else if (cb32.Checked == false)
            {
                arrchoices.Remove("Back Pain");
                cb31.Enabled = true;
                cb33.Enabled = true;
            }
        }
        private void Cb33_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb33.Checked == true)
            {
                arrchoices.Add("Facial Pain");
                cb32.Enabled = false;
                cb31.Enabled = false;
                c2 += 1;
            }
            else if (cb33.Checked == false)
            {
                arrchoices.Remove("Facial Pain");
                cb32.Enabled = true;
                cb31.Enabled = true;
                c2 -= 1;
            }
        }
        private void Cb34_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb34.Checked == true)
            {
                arrchoices.Add("Poor appetite");
                c13 += 1;
            }
            else if (cb34.Checked == false)
            {
                arrchoices.Remove("Poor appetite");
                c13 -= 1;
            }
        }
        private void Cb35_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb35.Checked == true)
            {
                arrchoices.Add("Poor feeding");
            }
            else if (cb35.Checked == false)
            {
                arrchoices.Remove("Poor feeding");
            }
        }
        private void Cb36_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb36.Checked == true)
            {
                c4 += 1;
                c5 += 1;
                arrchoices.Add("Blister Rash (body, face, limbs)");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb41.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
            }
            else if (cb36.Checked == false)
            {
                c4 -= 1;
                c5 -= 1;
                arrchoices.Remove("Blister Rash (body, face, limbs)");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb41.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
            }
        }
        private void Cb37_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb37.Checked == true)
            {
                arrchoices.Add("Blister with Red Base");
                cb36.Enabled = false;
                cb38.Enabled = false;
                cb41.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c6 += 1;
            }
            else if (cb37.Checked == false)
            {
                arrchoices.Remove("Blister with Red Base ");
                cb36.Enabled = true;
                cb38.Enabled = true;
                cb41.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c6 -= 1;
            }
        }
        private void Cb38_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb38.Checked == true)
            {
                arrchoices.Add("Cluster of Blister (face)");
                cb37.Enabled = false;
                cb41.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c8 += 1;
            }
            else if (cb38.Checked == false)
            {
                arrchoices.Remove("Cluster of Blister (face)");
                cb37.Enabled = true;
                cb41.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c8 -= 1;
            }
        }
        private void Cb39_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb39.Checked == true)
            {
                arrchoices.Add("Dusky Red Rash (face and white spots in mouth like rough sandpaper)");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb41.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c24 += 1;
            }
            else if (cb39.Checked == false)
            {
                arrchoices.Remove("Dusky Red Rash (face and white spots in mouth like rough sandpaper)");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb41.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c24 -= 1;
            }
        }
        private void Cb40_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb40.Checked == true)
            {
                arrchoices.Add("Greyish Blister (palms and finger)");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb41.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c7 += 1;
            }
            else if (cb40.Checked == false)
            {
                arrchoices.Remove("Greyish Blister (palms and finger)");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb41.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c7 -= 1;
            }
        }
        private void Cb41_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb41.Checked == true)
            {
                arrchoices.Add("Painful Blister");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c23 += 1;
            }
            else if (cb41.Checked == false)
            {
                arrchoices.Remove("Painful Blister");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c23 -= 1;
            }
        }
        private void Cb42_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb42.Checked == true)
            {
                arrchoices.Add("Pimple like Rash (all over the body)");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb41.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c22 += 1;
                c25 += 1;
            }
            else if (cb42.Checked == false)
            {
                arrchoices.Remove("Pimple like Rash (all over the body)");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb41.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c22 -= 1;
                c25 -= 1;
            }
        }
        private void Cb43_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb43.Checked == true)
            {
                arrchoices.Add("Pinpoint Rash");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb41.Enabled = false;
                cb44.Enabled = false;
                cb45.Enabled = false;
                c13 += 1;
            }
            else if (cb43.Checked == false)
            {
                arrchoices.Remove("Pinpoint Rash");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb41.Enabled = true;
                cb44.Enabled = true;
                cb45.Enabled = true;
                c13 -= 1;
            }
        }
        private void Cb44_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb44.Checked == true)
            {
                arrchoices.Add("Ring Shaped Rash");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb41.Enabled = false;
                cb45.Enabled = false;
                c19 += 1;
            }
            else if (cb44.Checked == false)
            {
                arrchoices.Remove("Ring Shaped Rash");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb41.Enabled = true;
                cb45.Enabled = true;
                c19 -= 1;
            }
        }
        private void Cb45_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb45.Checked == true)
            {
                arrchoices.Add("Rosy Pink Rash (neck, chest and spread to the rest of the bosy)");
                cb37.Enabled = false;
                cb38.Enabled = false;
                cb36.Enabled = false;
                cb40.Enabled = false;
                cb39.Enabled = false;
                cb42.Enabled = false;
                cb43.Enabled = false;
                cb44.Enabled = false;
                cb41.Enabled = false;
                c20 += 1;
            }
            else if (cb45.Checked == false)
            {
                arrchoices.Remove("Rosy Pink Rash (neck, chest and spread to the rest of the bosy)");
                cb37.Enabled = true;
                cb38.Enabled = true;
                cb36.Enabled = true;
                cb40.Enabled = true;
                cb39.Enabled = true;
                cb42.Enabled = true;
                cb43.Enabled = true;
                cb44.Enabled = true;
                cb41.Enabled = true;
                c20 -= 1;
            }
        }
        private void Cb46_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb46.Checked == true)
            {
                arrchoices.Add("Red Swollen lips");
                c24 += 1;
            }
            else if (cb46.Checked == false)
            {
                arrchoices.Remove("Red Swollen lips");
                c24 -= 1;
            }
        }
        private void Cb47_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb47.Checked == true)
            {
                arrchoices.Add("Runny nose");
                c16 += 1;
            }
            else if (cb47.Checked == false)
            {
                arrchoices.Remove("Runny nose");
                c16 -= 1;
            }
        }
        private void Cb48_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb48.Checked == true)
            {
                arrchoices.Add("Sores");
            }
            else if (cb48.Checked == false)
            {
                arrchoices.Remove("Sores");
            }
        }
        private void Cb49_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb49.Checked == true)
            {
                arrchoices.Add("Sore throat");
                c6 += 1;
                c7 += 1;
                c14 += 1;
                c24 += 1;
                c26 += 1;
            }
            else if (cb49.Checked == false)
            {
                arrchoices.Remove("Sore throat");
                c6 -= 1;
                c7 -= 1;
                c14 -= 1;
                c24 -= 1;
                c26 -= 1;
            }
        }
        private void Cb50_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb50.Checked == true)
            {
                arrchoices.Add("Stiff neck");
                c13 += 1;
            }
            else if (cb50.Checked == false)
            {
                arrchoices.Remove("Stiff neck");
                c13 -= 1;
            }
        }
        private void Cb51_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb51.Checked == true)
            {
                arrchoices.Add("Swelling");
                c1 += 1;
            }
            else if (cb51.Checked == false)
            {
                arrchoices.Remove("Swelling");
                c1 -= 1;
            }
        }
        private void Cb52_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb52.Checked == true)
            {
                arrchoices.Add("Swollen red tonsils with white spots");
                c26 += 1;
            }
            else if (cb52.Checked == false)
            {
                arrchoices.Remove("Swollen red tonsils with white spots");
                c26 -= 1;
            }
        }
        private void Cb53_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb53.Checked == true)
            {
                arrchoices.Add("Swollen glands");
                c14 += 1;
            }
            else if (cb53.Checked == false)
            {
                arrchoices.Remove("Swollen glands");
                c14 -= 1;
            }
        }
        private void Cb54_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb54.Checked == true)
            {
                arrchoices.Add("Teary");
                c17 += 1;
            }
            else if (cb54.Checked == false)
            {
                arrchoices.Remove("Teary");
                c17 -= 1;
            }
        }
        private void Cb55_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb55.Checked == true)
            {
                arrchoices.Add("Tenderness and fluctuant mass");
                c1 += 1;
            }
            else if (cb55.Checked == false)
            {
                arrchoices.Remove("Tenderness and fluctuant mass");
                c1 -= 1;
            }
        }
        private void Cb56_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb56.Checked == true)
            {
                arrchoices.Add("Tingling");
                c25 += 1;
            }
            else if (cb56.Checked == false)
            {
                arrchoices.Remove("Tingling");
                c25 -= 1;
            }
        }
        private void Cb57_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb57.Checked == true)
            {
                arrchoices.Add("Tiredness");
                c14 += 1;
            }
            else if (cb57.Checked == false)
            {
                arrchoices.Remove("Tiredness");
                c14 -= 1;
            }
        }
        private void Cb58_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb58.Checked == true)
            {
                arrchoices.Add("Vomiting");
                c9 += 1;
                c13 += 1;
                c15 += 1;
                c16 += 1;
                c21 += 1;
                c23 += 1;
                c24 += 1;
                c26 += 1;
            }
            else if (cb58.Checked == false)
            {
                arrchoices.Remove("Vomiting");
                c9 -= 1;
                c13 -= 1;
                c15 -= 1;
                c16 -= 1;
                c21 -= 1;
                c23 -= 1;
                c24 -= 1;
                c26 += 1;
            }
        }
        private void Cb59_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb59.Checked == true)
            {
                c3 += 1;
                arrchoices.Add("Wheezing");
            }
            else if (cb59.Checked == false)
            {
                c3 -= 1;
                arrchoices.Remove("Wheezing");
            }
        }

        private void Cb60_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cb60.Checked == true)
            {
                arrchoices.Add("Diarrhea");
                c9 += 1;
                c21 += 1;
                c23 += 1;
            }
            else if (cb60.Checked == false)
            {
                arrchoices.Remove("Diarrhea");
                c9 -= 1;
                c21 -= 1;
                c23 -= 1;
            }
        }
    }
}
