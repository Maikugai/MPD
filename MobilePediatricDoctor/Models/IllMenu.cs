using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using TheWae.Models;
using MobilePediatricDoctor;

namespace TheWae.Models
{
    [Activity(Label = "Illness Menu", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class IllMenu : AppCompatActivity
    {
        string[] sympitems = new string[]
        {
            "Abscess(Surrounding cellulitis)", "Acute Sinusitis", "Asthma", "Chickenpox", "Croup", "Cold Sores", "Hand/Foot/Mouth Disease(Coxsackie virus)", "Impetigo", "Influenza", "Laryngotracheal Bronchitis", "Lice Head Lice Pediculosis (insect)", "Measles", "Meningococcal Meningitis (Bacterial)", "Mononucleosis (Epstein-Barr virus)", "Mumps (Parotitis)", "Pertussis Whooping cough (bacteria)", "Pink Eye (conjuintivitis)", "Respiratory Syncytial Virus(RSV)", "Ringworm", "Roseola Infantum (Sixth Disease)", "Salmonellosis (bacteria)", "Scabies", "Shingles", "Streptococcal Infections: Scarlet Fever and Strep Throat", "Swimmer’s Itch", "Tonsillitis (ATP)"
        };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.IllMenu);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Illness List";

            var listView = FindViewById<ListView>(Resource.Id.list);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, sympitems);
            listView.Adapter = adapter;

            TextView txtname = FindViewById<TextView>(Resource.Id.illName);
            TextView txtdesc = FindViewById<TextView>(Resource.Id.illDesc);
            TextView txtsymp = FindViewById<TextView>(Resource.Id.illSymp);
            TextView txttreat = FindViewById<TextView>(Resource.Id.illTreat);
            TextView txtprev = FindViewById<TextView>(Resource.Id.illPrev);
            TextView txtdoc = FindViewById<TextView>(Resource.Id.illDoc);

            listView.ItemClick += (s, e) =>
            {
                var ValueActivity = new Intent(this, typeof(IllDesc));
                switch (e.Position)
                {
                    case 0:
                        ValueActivity.PutExtra("iName", "Abscess (Surrounding cellulitis)");
                        ValueActivity.PutExtra("iDesc", "Infection can cause a collection of pus in almost any area of the body.");
                        ValueActivity.PutExtra("iSymp", "• Tenderness and fluctuant mass\n• Swelling\n• Fever(37.4-38.2°c)");
                        ValueActivity.PutExtra("iTreat", "1. Apply warm compress to the infected area for 30 minutes 4 times daily\n2. Antibiotics: cloxacillin(25–50 mg / kg   four times a day) for 5 days or until surrounding cellulitis resolves.\n3. You may also take Co - Amoarclaw 30mg / kg every 8 hours");
                        ValueActivity.PutExtra("iPrev", "1. Make sure to have a good personal hygiene by washing your skin with soap and water regularly.\n2. Avoiding sweat moisture by changing to dry clothes");
                        ValueActivity.PutExtra("iDoc", "• Seek a doctor if the sore getting big and painful.\n• Possible incision and drinage");
                        StartActivity(ValueActivity);
                        break;
                    case 1:
                        ValueActivity.PutExtra("iName", "Acute Sinusitis");
                        ValueActivity.PutExtra("iDesc", "Acute sinusitis usually starts as a  allergic viral respiratory infection. With acute sinusitis occurring from 1 week to less than 4 weeks after onset of symptoms");
                        ValueActivity.PutExtra("iSymp", "• Facial pain\n• Nasal obstruction the of difficulty breathing\n• Headache\n• Coryza\n• Fever(sometimes)(37.4-38.2°c)");
                        ValueActivity.PutExtra("iTreat", "1. Have a good rest\n2. Drink lots of fluids\n3. Have a nasal irrigation\n4. Paracetamol 10mg / kg / dose of 4H in fever =38°c");
                        ValueActivity.PutExtra("iPrev", "1. Make sure to follow hand washing guidelines\n2. Avoid person who has common cold or influenza\n3. Avoid contact with smoke, powder and perfume");
                        ValueActivity.PutExtra("iDoc", "Seek a doctor if the child condition getting worse.");
                        StartActivity(ValueActivity);
                        break;
                    case 2:
                        ValueActivity.PutExtra("iName", "Asthma");
                        ValueActivity.PutExtra("iDesc", "It is a particular disease to children. This can make the child having the difficulty in breathing and some coughing.");
                        ValueActivity.PutExtra("iSymp", "• Shortness of breath\n• Wheezing\n• Chest tightness\n• Cough\n• Fever(sometimes)(37.4-38.2°c)");
                        ValueActivity.PutExtra("iTreat", "1. Have a 6 to 8 inch blocks to elevate the head of your bed.\n2. Avoid contact with the smoke of the tabacco.\n3. Paracetamol 10mg / kg / dose every 4 hours temperature = 38°c");
                        ValueActivity.PutExtra("iPrev", "1. Once a week wash the bed sheets and blankets once a week.\n2. Avoid contact with furred animals or feathers for a long time, tobacco smoke, powder and perfume.");
                        ValueActivity.PutExtra("iDoc", "When the symptoms are getting worsening and the shortness of the breath with a minimal activity only seek a doctor right away.");
                        StartActivity(ValueActivity);
                        break;
                    case 3:
                        ValueActivity.PutExtra("iName", "Chickenpox");
                        ValueActivity.PutExtra("iDesc", "This illness is caused by varicella-zoster virus.");
                        ValueActivity.PutExtra("iSymp", "• Slight fever\n• Blister rashes, it usually come out on the body, face and then to the limbs.");
                        ValueActivity.PutExtra("iTreat", "1. Cut finger nails to prevent scratching\n2. Take antihistamines in order to reduce the itch of the rash\n3. Baking soda paste may also help you to ease the itch.\n4. Paracetamol 10mg / kg / dose every 4 hours temperature = 38°c");
                        ValueActivity.PutExtra("iPrev", "1. Vaccination starts at 1 year old for  2 doses\n2. Prevent near contact to persons who are pregnant");
                        ValueActivity.PutExtra("iDoc", "If the immune response of the person is reducing due to the illness should seek a doctor right away.");
                        StartActivity(ValueActivity);
                        break;
                    case 5:
                        ValueActivity.PutExtra("iName", "Cold Sores");
                        ValueActivity.PutExtra("iDesc", "Cold sore is on the mouth and it caused by herpes simple type virus.");
                        ValueActivity.PutExtra("iSymp", "• Fever(37.4-38.2°c)\n• Sore throat\n• Blister with a red base");
                        ValueActivity.PutExtra("iTreat", "Avoid eating some spicy foods and acidic.");
                        ValueActivity.PutExtra("iPrev", "1. Ensure the child have indirect contact to the child having a cold sores.\n2. Make sure the child do not share infectious material to prevent the transmission of the virus.");
                        ValueActivity.PutExtra("iDoc", "If the cold sores last for a week seek a doctor.");
                        StartActivity(ValueActivity);
                        break;
                    case 4:
                        ValueActivity.PutExtra("iName", "Croup");
                        ValueActivity.PutExtra("iDesc", "It is an infection of the throat. Caused by a virus that the throat becomes red and swollen. Ages 5 years it is called croup but for adults it called as laryngitis.");
                        ValueActivity.PutExtra("iSymp", "• Raspy voice\n• Cough that sounds like a bark\n• Noisy breathing");
                        ValueActivity.PutExtra("iTreat", "1. Keep your child calm when it cries to have a good breathing\n2. Warm mist - Have warm water and the door close in the bathroom then sit the child so it can breathe the mist of the warm water");
                        ValueActivity.PutExtra("iPrev", "Avoid your child touching the hand of the other child who have croup and object that has been contaminated with the virus.");
                        ValueActivity.PutExtra("iDoc", "If the condition get worse the breathing of the child is hard and last for a 3 to 5 days seek doctor assistance right away.");
                        StartActivity(ValueActivity);
                        break;
                    case 6:
                        ValueActivity.PutExtra("iName", "Hand/Foot/Mouth Disease(Coxsackie virus)");
                        ValueActivity.PutExtra("iDesc", "It is caused by coxsackie virus in it common in summer and children ages 10 years of age");
                        ValueActivity.PutExtra("iSymp", "• Sudden onset Fever\n• Greyish blister on palms and finger\n• Sore throat");
                        ValueActivity.PutExtra("iTreat", "Control fever with acetaminophen");
                        ValueActivity.PutExtra("iPrev", "Make sure the child hands are clean and have a proper hygiene measures in home.");
                        ValueActivity.PutExtra("iDoc", "Call the doctor if the child condition getting worse and last for a week.");
                        StartActivity(ValueActivity);
                        break;
                    case 7:
                        ValueActivity.PutExtra("iName", "Impetigo");
                        ValueActivity.PutExtra("iDesc", "Common skin infection come from group A streptococcal  (strep) bacteria. Infection starts from a insect bite of scratch.  This kind of bacteria is common during summer.");
                        ValueActivity.PutExtra("iSymp", "• Clusters of blisters\n• Sores\n• Ooze fluid from the blisters and becomes yellow crusted sores\n• Appear first in the face.");
                        ValueActivity.PutExtra("iTreat", "1. Put some antibiotic ointment or cream on the sores\n2. Co - Amoxiclav 30mg / kg / dose");
                        ValueActivity.PutExtra("iPrev", "1. Ensure the child do not touch the infection\n2. Keep the child nails short and clean.\n3. Proper hygiene and keep skin clean and dry(no sweat) or change frequently when wet.");
                        ValueActivity.PutExtra("iDoc", "If the rash did not drain after 24 hours of antibiotic treatment the child should seek a doctor.");
                        StartActivity(ValueActivity);
                        break;
                    case 8:
                        ValueActivity.PutExtra("iName", "Influenza");
                        ValueActivity.PutExtra("iDesc", "These are frequent to children because they do not have enough immunologic knowledge with the influenza virus. The rate of infection to children is greater than to the adults.Influenza virus has three types A / H1N1, A / H3N2, B.");
                        ValueActivity.PutExtra("iSymp", "• Fever(37.4-38.2°c)\n• Diarrhea\n• Vomiting\n• Abdominal pain");
                        ValueActivity.PutExtra("iTreat", "1. More time of bed rest\n2. Drink plenty of fluids to prevent dehydration\n3. Consider pain relievers to lessen the achiness of the influenza.");
                        ValueActivity.PutExtra("iPrev", "Have a personal hygiene, drink lots of fluids and have a enough bed rest.");
                        ValueActivity.PutExtra("iDoc", "If the symptoms keep returning and the fever getting worse than before, you will need to seek the doctor for a medical assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 9:
                        ValueActivity.PutExtra("iName", "Laryngotracheal Bronchitis");
                        ValueActivity.PutExtra("iDesc", "Laryngotracheal Bronchitis, or croup is a slowly progressive 'mild' self limited viral inflammation of subglottic larynx usually occurring in infants and young children.");
                        ValueActivity.PutExtra("iSymp", "• Hoarse Voice\n• Swallowing\n• BarkingCough\n• Fever(38.3celcius)\n• Drooling");
                        ValueActivity.PutExtra("iTreat", "Racemic Epinephrine - For mild cases, the patient should be well hydrated.In more severe cases  nebulized epinephrine  used as a musocal vasoconstrictor may provide relief.Patients being treated in this manner usually are observed in the hospital for 2 - 6 hours after treatment.");
                        ValueActivity.PutExtra("iPrev", "Typically worsens when the patient is active or upset, and also improves with warm humidified air.");
                        ValueActivity.PutExtra("iDoc", "Visit the doctor when experiencing severe cases.");
                        StartActivity(ValueActivity);
                        break;
                    case 10:
                        ValueActivity.PutExtra("iName", "Lice Head Lice Pediculosis (insect)");
                        ValueActivity.PutExtra("iDesc", "Lice are ectoparasitic insects, the head louse, the most common causes of forming of louse infestation. Girls are more susceptible than boys. The condition is transmitted via combs, brushes, shared of hats, towels or beddings.");
                        ValueActivity.PutExtra("iSymp", "• The hair has small white eggs (nits) firmly attached to the hair shaft especially around ears and nape of neck\n• Itchiness\n• Grey - white sometimes brown adult lice whose 1 - 2 mm long");
                        ValueActivity.PutExtra("iTreat", "1. Treat the case with special shampoo/rinse available at drugstore Permethrin shampoo or Pyrethrin combined with piperonyl butoxide products. Follow package directions carefully\n2. Remove nits\n3. Wash clothes and linens in hot water, or dry clean. Retreat in 7 - 10 days.");
                        ValueActivity.PutExtra("iPrev", "1. To Prevent this Check young children routine\n2. Do not borrow or share combs, hair accessories or other head gear.");
                        ValueActivity.PutExtra("iDoc", "If over the counter shampoos doesn't give an effect, seek doctor assistance ");
                        StartActivity(ValueActivity);
                        break;
                    case 11:
                        ValueActivity.PutExtra("iName", "Measles");
                        ValueActivity.PutExtra("iDesc", "Caused by measles virus");
                        ValueActivity.PutExtra("iSymp", "• Fever(37.4-38.2°c)\n• Inflamed eyes\n• Dry Cough\n• Runny Nose\n• Dusky Red Rash 3 - 7 days later will spread downwards starting from the face and white spots in mouth.");
                        ValueActivity.PutExtra("iTreat", "1. Control fever\n2. Treat with fluids\n3. If eyes are sensitive wear sunglass.");
                        ValueActivity.PutExtra("iPrev", "Immunization against measles starting at 9 months old may be given as early as 6 months during measles epidemic 2nd doseMMN at 1 3 / 12 years 3rd dose MMN at 4years old maybe given 3 months after 2nd dose");
                        ValueActivity.PutExtra("iDoc", "Seek medicine consult if symptoms gets worse like if there is seizure , fast breathing or weakness");
                        StartActivity(ValueActivity);
                        break;
                    case 12:
                        ValueActivity.PutExtra("iName", "Meningococcal Meningitis (Bacterial)");
                        ValueActivity.PutExtra("iDesc", "One of the causes of bacterial meningitis is meningococur (Nessecia meningitilz) bacteria");
                        ValueActivity.PutExtra("iSymp", "• Fever(37.4-38.2°c)\n• Intense\n• Headache\n• Nausea\n• Vomiting\n• Stiff neck\n• Irritability\n• Poor appetite\n• And often a pinpoint rash.");
                        ValueActivity.PutExtra("iTreat", "1. Hospitalization\n2. Appropriate antibiotic therapy\n3. Notify health unit isolation");
                        ValueActivity.PutExtra("iPrev", "Immunization during outbreaks, where appropriate.");
                        ValueActivity.PutExtra("iDoc", "See a doctor to Confirm with test of blood and cerebral spinal fluid");
                        StartActivity(ValueActivity);
                        break;
                    case 13:
                        ValueActivity.PutExtra("iName", "Mononucleosis (Epstein-Barr virus)");
                        ValueActivity.PutExtra("iDesc", "Mononucleosis is a systematic, febrile, self-limited lymphoproliferative disorder that is usually associated with hepatosplenomegaly and generalized lymphadenopathy.");
                        ValueActivity.PutExtra("iSymp", "• Acute fever\n• Sore throat\n• Swollen glands\n• Tiredness.");
                        ValueActivity.PutExtra("iTreat", "1. Promote rest\n2. Increase fluids\n3. Have good nutrition\n4. Control fever.");
                        ValueActivity.PutExtra("iPrev", "To prevent this have good hygiene, careful hand-washing.");
                        ValueActivity.PutExtra("iDoc", "See a physician if the condition getting worse.");
                        StartActivity(ValueActivity);
                        break;
                    case 14:
                        ValueActivity.PutExtra("iName", "Mumps (Parotitis)");
                        ValueActivity.PutExtra("iDesc", "Mumps the inflammation of the salivary glands causing the cheeks to swell painfully");
                        ValueActivity.PutExtra("iSymp", "• Fever(37.4-38.2°c)\n• Headache");
                        ValueActivity.PutExtra("iTreat", "Paracetamol for fever");
                        ValueActivity.PutExtra("iPrev", "1. To prevent this must have measles, mumps, rubella vaccine (given at age 12 months and 18 months).\n2. Immunomodulators");
                        ValueActivity.PutExtra("iDoc", "See a physician whenever feeling some of the symptoms");
                        StartActivity(ValueActivity);
                        break;
                    case 15:
                        ValueActivity.PutExtra("iName", "Pertussis “Whooping cough” (bacteria)");
                        ValueActivity.PutExtra("iDesc", "Pertussis is a relatively common cause of lower respiratory tract infection in infants, children, adolescents, and adults, especially in those who are under immunized or noimmunized.");
                        ValueActivity.PutExtra("iSymp", "• Runny nose\n• Violent coughing with characteristic Whoop\n• Sometimes will followed by a vomiting");
                        ValueActivity.PutExtra("iTreat", "1. Antibiotic treatment\n2. See physician");
                        ValueActivity.PutExtra("iPrev", "To prevent this you need to get Age-appropriate immunization.");
                        ValueActivity.PutExtra("iDoc", "See a doctor to confirm with lab test");
                        StartActivity(ValueActivity);
                        break;
                    case 16:
                        ValueActivity.PutExtra("iName", "Pink Eye (conjuintivitis)");
                        ValueActivity.PutExtra("iDesc", "The presence of blurring of vision, pain or itching, and the characteristics of any discharge (watery,mucoid, purulent) Swelling of eyelids after block of follicle");
                        ValueActivity.PutExtra("iSymp", "• Teary\n• Irritated itchy eyes with swollen lids and thick yellow discharge\n• If sensitive to sunlight.\n• Itchiness of eyelid");
                        ValueActivity.PutExtra("iTreat", "1. Avoid touching eyes\n2. Wash hands often\n3. Co Amoxiclar 30mg / kg / day");
                        ValueActivity.PutExtra("iPrev", "1. To prevent this should have good personal hygiene, and careful hand washing.\n2. Keep the hands away from the eyes.\n3. Do not share towels, or bed linen.avoid toys getting close to the face.\n4. Proper hygiene, avoid touching and proper hand washing frequently");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance. See ophthalmologist");
                        StartActivity(ValueActivity);
                        break;
                    case 17:
                        ValueActivity.PutExtra("iName", "Respiratory Syncytial Virus(RSV)");
                        ValueActivity.PutExtra("iDesc", "RSV is a common virus that infects the child’s lungs and respiratory tract by the age of 2.");
                        ValueActivity.PutExtra("iSymp", "• Inactivity\n• Listlessness\n• Low grade fever or chills\n• Cough\n• Earache\n• Rapid breathing or wheezing\n• Poor feeding\n• Decreased interest in surroundings, stuffy or runny nose");
                        ValueActivity.PutExtra("iTreat", "1. Do not use, cold medicines, antihistamines or decongestants, antibiotics.\n2. Drink plenty of water.");
                        ValueActivity.PutExtra("iPrev", "Good personal hygiene and always wash your hands");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 18:
                        ValueActivity.PutExtra("iName", "Ringworm");
                        ValueActivity.PutExtra("iDesc", "Ringworm is a fungal skin infection that can be found on the scalp, body, groin, or feet.");
                        ValueActivity.PutExtra("iSymp", "• If ringworm infection is on the scalp, there may be patches of hairloss or hair thinning , rash may be dry and scaly or wet and crusty,\n• Ring shaped rash that is reddish and may be itchy");
                        ValueActivity.PutExtra("iTreat", "See physician for appropriate treatment.");
                        ValueActivity.PutExtra("iPrev", "Keep the affected areas clean and dry and wash it every day.");
                        ValueActivity.PutExtra("iDoc", "See physician for proper treatment");
                        StartActivity(ValueActivity);
                        break;
                    case 19:
                        ValueActivity.PutExtra("iName", "Roseola Infantum (Sixth Disease)");
                        ValueActivity.PutExtra("iDesc", "Roseola Infantum is a rash disease caused by a virus. It’s commonly affecting the children between the ages of 6 months to 2 years old.");
                        ValueActivity.PutExtra("iSymp", "• Rash usually develops as fever is resolving\n• Rosy – Pink Rash develops first on neck and chest and then spreads to rest of the body\n• The spots(rash) turn white if you gently press on them and they may have a lighter color ring around them\n• Swelling of eyelids may occur\n• Fever(usually = 39.5°C) appears suddenly and lasts 3 – 5 days\n• Rash usually lasts 1 – 2 days Febrile seizures may occur.");
                        ValueActivity.PutExtra("iTreat", "Drink  acetaminophen  to control the fever.");
                        ValueActivity.PutExtra("iPrev", "Always wash your hand.");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 20:
                        ValueActivity.PutExtra("iName", "Salmonellosis (bacteria)");
                        ValueActivity.PutExtra("iDesc", "Salmonellosis is an infection with bacteria called Salmonella. Salmonella is a kind of bacteriathat has a many different types. The type that is responsible to the infections of the human is carried by cow, pigs, reptiles and chickens.");
                        ValueActivity.PutExtra("iSymp", "• Diarrhea\n• Nausea\n• Vomiting\n• Fever(37.4-38.2°c)\n• Headache\n• Abdominal Cramps");
                        ValueActivity.PutExtra("iTreat", "1. Drink plenty of fluids.\n2. Treat fever\n3. Antibiotics");
                        ValueActivity.PutExtra("iPrev", "1. Cook your food from animal sources throughly.\n2. Always clean the areas of your food preparation.\n3. Wash your hands properly");
                        ValueActivity.PutExtra("iDoc", "See the physician.");
                        StartActivity(ValueActivity);
                        break;
                    case 21:
                        ValueActivity.PutExtra("iName", "Scabies");
                        ValueActivity.PutExtra("iDesc", "Scabies is a contagious skin disease that is caused by the mite known as the Sarcoptes scabiei");
                        ValueActivity.PutExtra("iSymp", "• Itching and rash may be all over the body between the fingers, wrists, elbows, armpits, groin area, nipples, waist, buttocks, and shoulder blades, tiny burrows\n• Look like grayish - white or skin - colored lines on the skin may be seen\n• A Pimple – like Rash may be present, intense itching, especially at night");
                        ValueActivity.PutExtra("iTreat", "1. Wash your clothes and linen in hot water.\n2. Buy a special lotion like Permethoin for treatment from drug store and follow the directions carefully.\n3. Itching may prevent 1 - 2 weeks after the treatment.\n4. Washing your hands and cutting your  fingernails carefully can prevent secondary infections.\n5. Antihistamines may help to reduce or relieve the itching.");
                        ValueActivity.PutExtra("iPrev", "Good personal hygiene, Always keep yourself and your clothes clean, Knowledge about scabies.");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 22:
                        ValueActivity.PutExtra("iName", "Shingles");
                        ValueActivity.PutExtra("iDesc", "Shingles is also called herpes zoster. It is an infection that causes a painful rash. A reactivates of provinely affected varicella zoster called chicken pox");
                        ValueActivity.PutExtra("iSymp", "• Painful Blisters usually scab over in about 3 – 5 days and disappear after 2to 4 weeks, blister-type rash that develops in the same area as pain and tingling, pain itching, or tingling along the affected nerve pathway due to nerve involment");
                        ValueActivity.PutExtra("iTreat", "Acyclovir");
                        ValueActivity.PutExtra("iPrev", "Avoid contact or communicate with people whose immunity may be reduced due to drug/ radiation  or disease therapy like pregnant women");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 23:
                        ValueActivity.PutExtra("iName", "Streptococcal Infections: Scarlet Fever and Strep Throat");
                        ValueActivity.PutExtra("iDesc", "Strep throat and scarlet fever are both caused by streptococcal bacteria. Untreated streptococcal infection may result of Rheumatic fever");
                        ValueActivity.PutExtra("iSymp", "• Red, swollen lips, strawberry – like tongue\n• Nausea\n• Vomiting\n• Red Rash that looks like sunburn and feels like rough sandpaper, flushed cheeks and pale area around mouth\n• Fever(37.4-38.2°c), rash most often begins on chest and stomach and then spreads to, rest of body\n• Rash usually lasts 2 – 7 days, when rash fades, skin on hands and feet may start to peel\n• Sore Throat");
                        ValueActivity.PutExtra("iTreat", "1. For antibiotic treatment therapy, see the physician.\n2. To prevent the result of rheumatic heart disease, ensure full course of antibiotics.\n3. Drink acetaminophen to control the fever");
                        ValueActivity.PutExtra("iPrev", "Proper food-handling and hand-washing.");
                        ValueActivity.PutExtra("iDoc", "See the physician for more treatment.");
                        StartActivity(ValueActivity);
                        break;
                    case 24:
                        ValueActivity.PutExtra("iName", "Swimmer’s Itch");
                        ValueActivity.PutExtra("iDesc", "Swimmer’s itch is a itchy skin rash caused by very tiny parasites");
                        ValueActivity.PutExtra("iSymp", "• Small blisters\n• Small reddish pimples\n• Tingling\n• Burning, or itching of the skin(itching can be severe)");
                        ValueActivity.PutExtra("iTreat", "1. Avoid scratching the affected areas.\n2. You can use use antihistamines, calamine, warm water with baking soda, apply cool compresses for the treatment");
                        ValueActivity.PutExtra("iPrev", "1. Applying waterproof sunscreen when you go swimming.\n2. Use dry towel right after leaving the water.\n3. Ideally, take a bath immediately after swimming, then use dry towel");
                        ValueActivity.PutExtra("iDoc", "See physician for assistance.");
                        StartActivity(ValueActivity);
                        break;
                    case 25:
                        ValueActivity.PutExtra("iName", "Tonsillitis(ATP)");
                        ValueActivity.PutExtra("iDesc", "It is an inflammation of the tonsils");
                        ValueActivity.PutExtra("iSymp", "• Vomiting\n• Headache\n• Difficult and painful of swallowing\n• Swollen red tonsils with white spots\n• Sore throat - last longer than 48hours");
                        ValueActivity.PutExtra("iTreat", "1. Make sure to drink lots of fluids\n2. Amoxicillin 15 - 30 mg / kg / dose Q8h for 10 days\n3. Co amoxiclar 30mg / kg / day\n4. Gargle bactidol 3x a day");
                        ValueActivity.PutExtra("iPrev", "Avoidance of sugary foods  “sweets” increase oval fluids intake");
                        ValueActivity.PutExtra("iDoc", "Seek doctor if the condition getting worse.");
                        StartActivity(ValueActivity);
                        break;

                }
                
            };

           
        }
    }
}