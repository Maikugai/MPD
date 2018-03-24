using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace MobilePediatricDoctor.Models
{
    [Activity(Label = "Medicine", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Medicine : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Medicine);

            string[] medicineslist = new string[]
              {
                  "Acetaminophen", "Acetylcysteine", "Ambroxol", "Amoxicillin Trihydrate", "Bromhexine", "Cloxacillin sodium", "Dried ivy leaf extract", "Guaifenesin", "Lagundi (Vitex negundo)", "Salbutamol", "Terbutaline"
              };
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.medtoolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Medicines List";

            var medlist = FindViewById<ListView>(Resource.Id.medlist);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, medicineslist);
            medlist.Adapter = adapter;

            TextView mName = FindViewById<TextView>(Resource.Id.mName);
            TextView mIndication = FindViewById<TextView>(Resource.Id.mIndication);
            TextView mWarning = FindViewById<TextView>(Resource.Id.mWarning);

            medlist.ItemClick += (s, e) =>
            {
                var mIntent = new Intent(this, typeof(MedicineDesc));
                switch (e.Position)
                {
                    case 0:
                        mIntent.PutExtra("mName", "Acetaminophen");
                        mIntent.PutExtra("mIndication", "To relieve mild to moderate pain from headache, muscle ache, backache, minor arthritis, common cold, toothache, or menstrual crampslto reduce fever");
                        mIntent.PutExtra("mWarning", " ");
                        StartActivity(mIntent);
                        break;
                    case 1:
                        mIntent.PutExtra("mName", "Acetylcysteine");
                        mIntent.PutExtra("mIndication", "To liquefy abnormal, viscid or thickend mucus secretions in chronic pulmonary disorders (including emphysema, bronchitis, tuberculosis, bronchiectasis, and cystic fibrosis) and in pneumonia, pulmonary complications of thoracic or cardiovascular surgery, and tracheostomy care");
                        mIntent.PutExtra("mWarning", " ");
                        StartActivity(mIntent);
                        break;
                    case 2:
                        mIntent.PutExtra("mName", "Ambroxol");
                        mIntent.PutExtra("mIndication", "Ambroxol is a drug that breaks up phlegm, used in the treatment of respiratory diseases associated with viscid or excessive mucus.");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• GI effecct (N/V, diarrhea); Other effects (headache, polyuria, fatigue)\n\n Special Instruction\n\n• Should not be taken in an empty stomach\n• Use with caution in patients with gastric ulcer");
                        StartActivity(mIntent);
                        break;
                    case 3:
                        mIntent.PutExtra("mName", "Amoxicillin Trihydrate");
                        mIntent.PutExtra("mIndication", "To treat ear, nose, throat, GU tract skin, and soft-tissue infections caused by susceptible gram-positive and gram-negative organisms");
                        mIntent.PutExtra("mWarning", "");
                        StartActivity(mIntent);
                        break;
                    case 4:
                        mIntent.PutExtra("mName", "Bromhexine");
                        mIntent.PutExtra("mIndication", "Bromhexine is a mucolytic agent used in the treatment of respiratory disorders associated with viscid or excessive mucus. In addition, bromhexine has antioxidant properties.");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• GI effect(GI irritation); Metabolic effect (transient increase of serum transaminases)\n\n Special Instruction\n\n• Use with caution in patients with gastric ulcer");
                        StartActivity(mIntent);
                        break;
                    case 5:
                        mIntent.PutExtra("mName", "Cloxacillin sodium");
                        mIntent.PutExtra("mIndication", "To treat mild to moderate upper respiratory tract infections or localized skin and soft-tissue infections caused by penicillinase-producing staphylococci\nTo treat severe lower respiratory tract infections or disseminated infections caused by penicillinase-producing staphylococci");
                        mIntent.PutExtra("mWarning", " ");
                        StartActivity(mIntent);
                        break;
                    case 6:
                        mIntent.PutExtra("mName", "Dried ivy leaf extract");
                        mIntent.PutExtra("mIndication", " ");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• Rarely, laxative effect due to sorbitol content\n Special Instructions\n• Use with caution in patients with fructose/sorbitol intolerance");
                        StartActivity(mIntent);
                        break;
                    case 7:
                        mIntent.PutExtra("mName", "Guaifenesin");
                        mIntent.PutExtra("mIndication", "Guaifenesin, also known as guaiphenesin or glyceryl guaiacolate, is an expectorant medication sold over the counter and usually taken by mouth to assist the bringing up of phlegm from the airways in acute respiratory tract infections.");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• GI effects(GI discomfort: N/V); CNS effects(drowsiness; headache)\n\n Special Instruction\n\n• Use with caution in children <2 years old & in patients with persistent or chronic cough");
                        StartActivity(mIntent);
                        break;
                    case 8:
                        mIntent.PutExtra("mName", "Lagundi (Vitex negundo)");
                        mIntent.PutExtra("mIndication", "Vitex negundo, commonly known as the Chinese chaste tree, five-leaved chaste tree, or horseshoe vitex, is a large aromatic shrub with quadrangular, densely whitish, tomentose branchlets");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• GI effects (N/V, diarrhea); Dermatologic effect (rash)\n\n Special Instruction\n\n• Use with caution in patients with hypersensitivity to Lagundi");
                        StartActivity(mIntent);
                        break;
                    case 9:
                        mIntent.PutExtra("mName", "Salbutamol");
                        mIntent.PutExtra("mIndication", " ");
                        mIntent.PutExtra("mWarning", "Adverse Reactions\n• CNS effects(headache, sleep disturbances, agitation, hyperactivity & restlessness);CV effects (palpitations, cadiac arrhythmias especially in susceptible patients); Other effect (fine skeletal muscle tremor)\n\n• Potentially severe hypokalemia may result especially in acute severe asthma\n Special Instructions\n\n• Use with caution in patients with hyperthyroidism, DM, ,myocardial insufficiency or arrhythmias-Monitor K levels in acute severe asthma");
                        StartActivity(mIntent);
                        break;
                    case 10:
                        mIntent.PutExtra("mName", "Terbutaline");
                        mIntent.PutExtra("mIndication", " ");
                        mIntent.PutExtra("mWarning", "Adverse Reaction\n• CNS effects(headache, sleep disturbances, agitation, hyperactivity & restlessness);CV effects (palpitations, cadiac arrhythmias especially in susceptible patients); Other effect (fine skeletal muscle tremor)\n• Potentially severe hypokalemia may result especially in acute severe asthma\n\n Special Instructions\n\n• Use with caution in patients with hyperthyroidism, DM, ,myocardial insufficiency or arrhythmias-Monitor K levels in acute severe asthma");
                        StartActivity(mIntent);
                        break;
                }
            };
        }
    }
}