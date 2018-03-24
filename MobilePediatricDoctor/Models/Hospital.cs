using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using TheWae.Models;
using System;
using System.Collections;
using MobilePediatricDoctor;

namespace TheWae.Models
{
    [Activity(Label = "Hospital", Theme = "@style/MyTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Hospital : AppCompatActivity
    {
        string[] hospitallists = new string[]
              {
                "Adventist Medical Center Manila","Alabang Medical Center","Alfonso Medical Clinic","Allied Care Experts (ACE) Medical Center - Pateros","Amang Rodriguez Memorial Medical Center","Army General Hospital","Asian Hospital and Medical Center","A. Zarate General Hospital","Bagong Lipunan Health Center","Bangkulasi Health Center","Calalang General Hospital","Capitol Medical Center","Cardinal Santos Medical Center","Chinese General Hospital and Medical Center","Centuria Medical Makati","Cruz-Rabe Maternity","De Los Santos Medical Center","Dr. Jose Fabella Memorial Hospital","Dr. Sabili General Hospital","Fatima University Medical Center","Garcia General Hospital","Hemotek Renal Center","Hillside General Hospital","John F. Cotton Corporate Wellness Center","John Paul Hospital","Jose R. Reyes Memorial Medical Center","Lady of Lourdes Hospital of Caybiga Inc.","Las Piñas City Medical Center","Las Pinas Doctors Hospital","Las Piñas General Hospital and Satellite Trauma Center","Makati Medical Center","Malabon City Hospital","Mandaluyong City Medical Center","Martinez Memorial Hospital","MCU-FDT Medical Foundation Hospital","MCPC St. Therese of Lisieux Doctors Hospital","Medical Center Taguig, Inc.","Metropolitan Medical Center","Mira Mar Hospital","M.R. Flores Health Center","National Center for Mental Health","Navotas City Hospital","Navotas Emergency and Lying -in Clinic","Nodado General Hospital","Olivarez General Hospital","Ospital ng Makati","Ospital ng Maynila Medical Center","Ospital Ng Muntinlupa","Our Lady of Grace Hospital", "Pagamutang Bayan ng Malabon", "Paranaque Doctor's Hospital", "Pasay City General Hospital", "Pasig City General Hospital", "Protacio Hospital", "Providence Hospital", "Rizal Medical Center", "Quezon City General Hospital", "Saint Claire's Hospital and Nursery Dormitory", "Saint Joseph Maternity and Medical Clinic", "San Juan Medical Center", "Santa Rita De Baclaran Hospital", "San Lorenzo Ruiz Women's Hospital", "Santissimo Rosario General Hospital", "St. Anthony Medical Center", "St. Clare’s Medical Center", "St. Luke's Medical Center - Quezon City", "St. Martin de Porres Charity Hospital", "St. Victoria Hospital", "Taguig District Hospital", "The Medical City", "Tokyo Healthlink Inc, Alabang", "Unciano General Hospital", "Unihealth-Paranaque Hospital", "University of Perpetual Help DALTA Medical Center", "Valenzuela Citicare Medical Center", "Valenzuela City General Hospital", "Victor R. Potenciano Medical Center", "VT Maternity Hospital"
              };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Hospital);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.hosptoolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Hospital List";

            var hosplist = FindViewById<ListView>(Resource.Id.hosplist);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, hospitallists);
            hosplist.Adapter = adapter;

            hosplist.ItemClick += (s, e) =>
            {
                var hIntent = new Intent(this, typeof(HospitalDesc));
                switch (e.Position)
                {
                    case 0:
                        hIntent.PutExtra("Name", "Adventist Medical Center Manila");
                        hIntent.PutExtra("City", "Pasay City");
                        hIntent.PutExtra("Add", "1975 Corner Donada and San Juan Street, Pasay, 1300 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 525 9191");
                        StartActivity(hIntent);
                        break;
                    case 1:
                        hIntent.PutExtra("Name", "Alabang Medical Center");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "8 Corregidor, Cupang, Muntinlupa, 1771 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 850 8719");
                        StartActivity(hIntent);
                        break;
                    case 2:
                        hIntent.PutExtra("Name", "Alfonso Medical Clinic");
                        hIntent.PutExtra("City", "Pasay City");
                        hIntent.PutExtra("Add", "1975 Corner Donada and San Juan Street, Pasay, 1300 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 525 9191");
                        StartActivity(hIntent);
                        break;
                    case 3:
                        hIntent.PutExtra("Name", "Allied Care Experts (ACE) Medical Center - Pateros");
                        hIntent.PutExtra("City", "Pateros City");
                        hIntent.PutExtra("Add", "884 P. Herrera, Pateros, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 706 9398");
                        StartActivity(hIntent);
                        break;
                    case 4:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Amang Rodriguez Memorial Medical Center");
                        hIntent.PutExtra("City", "Marikina City");
                        hIntent.PutExtra("Add", "Sumulong Highway Sto. Nino, Marikina, 1800 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 941 5854");
                        StartActivity(hIntent);
                        break;
                    case 5:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Army General Hospital");
                        hIntent.PutExtra("City", "Taguig City");
                        hIntent.PutExtra("Add", "Barangay Pinagsama, Taguig, 1630 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 845 9555");
                        StartActivity(hIntent);
                        break;
                    case 6:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Asian Hospital and Medical Center");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "2205 Civic Dr, Alabang, Muntinlupa, 1780 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 771 9000");
                        StartActivity(hIntent);
                        break;
                    case 7:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "A.Zarate General Hospital");
                        hIntent.PutExtra("City", "Las Piñas City");
                        hIntent.PutExtra("Add", "13-765 Atlas compond naga road,Las Pinas,2011 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 874 6903");
                        StartActivity(hIntent);
                        break;
                    case 8:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Bagong Lipunan Health Center");
                        hIntent.PutExtra("City", "Navotas City");
                        hIntent.PutExtra("Add", "Los Martires St, Nvotas City, 1485 Metro Manila");
                        hIntent.PutExtra("Contact", "(2) 281 8728 | (2) 283 0697 | (2) 283 0697");
                        StartActivity(hIntent);
                        break;
                    case 9:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Bangkulasi Health Center");
                        hIntent.PutExtra("City", "Navotas City");
                        hIntent.PutExtra("Add", "Tuazon St, Navotas, Metro Manila");
                        hIntent.PutExtra("Contact", "63 2 281 8732");
                        StartActivity(hIntent);
                        break;
                    case 10:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Calalang General Hospital");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "MacArthur Highway, Valenzuela City, Manila, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 291 6802");
                        StartActivity(hIntent);
                        break;
                    case 11:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Capitol Medical Center");
                        hIntent.PutExtra("City", "Quezon City");
                        hIntent.PutExtra("Add", "Quezon Avenue Cor. Scout Magbanua St, Diliman, Quezon City, 1103 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 372 3825");
                        StartActivity(hIntent);
                        break;
                    case 12:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Cardinal Santos Medical Center");
                        hIntent.PutExtra("City", "San Juan City");
                        hIntent.PutExtra("Add", "10 Wilson, Greenhills West, San Juan, 1500 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 727 0001");
                        StartActivity(hIntent);
                        break;
                    case 13:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Chinese General Hospital and Medical Center");
                        hIntent.PutExtra("City", "Manila");
                        hIntent.PutExtra("Add", "286 Blumentritt Rd, Sampaloc, Manila, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 711 4141");
                        StartActivity(hIntent);
                        break;
                    case 14:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Centuria Medical Makati");
                        hIntent.PutExtra("City", "Makati City");
                        hIntent.PutExtra("Add", "Century City Kalayaan Ave. cor. Salamanca St., Brgy, Makati, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 793 8606");
                        StartActivity(hIntent);
                        break;
                    case 15:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Cruz-Rabe Maternity & General Hospital");
                        hIntent.PutExtra("City", "Taguig City");
                        hIntent.PutExtra("Add", "57 Gen. A Luna St, Taguig, 1634 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 642 3433");
                        StartActivity(hIntent);
                        break;
                    case 16:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "De Los Santos Medical Center");
                        hIntent.PutExtra("City", "Quezon City");
                        hIntent.PutExtra("Add", "201 E Rodriguez Sr. Ave, Quezon City, 1112 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 893 5762");
                        StartActivity(hIntent);
                        break;
                    case 17:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Dr. Jose Fabella Memorial Hospital");
                        hIntent.PutExtra("City", "Manila");
                        hIntent.PutExtra("Add", "1003 Lope de Vega St, Santa Cruz, Manila, 1003 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 733 8537");
                        StartActivity(hIntent);
                        break;
                    case 18:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Dr. Sabili General Hospital");
                        hIntent.PutExtra("City", "Taguig City");
                        hIntent.PutExtra("Add", "Number 313, General Santos Avenue, Lower Bicutan, Taguig, Metro Manila");
                        hIntent.PutExtra("Contact", "0905 404 8348");
                        StartActivity(hIntent);
                        break;
                    case 19:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Fatima University Medical Center");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "120 MacArthur Highway, Valenzuela, 1440 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 291 6538");
                        StartActivity(hIntent);
                        break;
                    case 20:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Garcia General Hospital");
                        hIntent.PutExtra("City", "Marikina City");
                        hIntent.PutExtra("Add", "49 Bayan-Bayanan Ave, Marikina, 1810 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 941 5511");
                        StartActivity(hIntent);
                        break;
                    case 21:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Hemotek Renal Center");
                        hIntent.PutExtra("City", "San Juan City");
                        hIntent.PutExtra("Add", "226, 3rd level Health Cube Bldg Wilson, San Juan, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 571 8991");
                        StartActivity(hIntent);
                        break;
                    case 22:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Hillside General Hospital");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "Km. 23, West Service Road, Cupang, Muntinlupa, 1770 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 842 3958");
                        StartActivity(hIntent);
                        break;
                    case 23:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "John F. Cotton Corporate Wellness Center");
                        hIntent.PutExtra("City", "Pasig City");
                        hIntent.PutExtra("Add", "Meralco Center, Ortigas Avenue, Metro Manila, Pasig, 1600");
                        hIntent.PutExtra("Contact", "(02) 622 8428");
                        StartActivity(hIntent);
                        break;
                    case 24:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "John Paul Hospital");
                        hIntent.PutExtra("City", "Malabon City");
                        hIntent.PutExtra("Add", "12 Mariano Ponce, Bagong Barrio West, Kalakhang Maynila, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 361 8959");
                        StartActivity(hIntent);
                        break;
                    case 25:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Jose R. Reyes Memorial Medical Center");
                        hIntent.PutExtra("City", "Manila");
                        hIntent.PutExtra("Add", "San Lazaro Compound, Rizal Avenue, Santa Cruz");
                        hIntent.PutExtra("Contact", "732-1077, 711-9491 to 98 (Trunkline) , 732-1629 (TF)");
                        StartActivity(hIntent);
                        break;
                    case 26:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Fatima University Medical Center");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "120 MacArthur Highway, Valenzuela, 1440 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 291 6538");
                        StartActivity(hIntent);
                        break;
                    case 27:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Lady of Lourdes Hospital of Caybiga Inc.");
                        hIntent.PutExtra("City", "Caloocan City");
                        hIntent.PutExtra("Add", "15 General Luis St, Caybiga");
                        hIntent.PutExtra("Contact", "9835582 / 9841413");
                        StartActivity(hIntent);
                        break;
                    case 28:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Las Piñas City Medical Center");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "120 MacArthur Highway, Valenzuela, 1440 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 291 6538");
                        StartActivity(hIntent);
                        break;
                    case 29:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Las Piñas General Hospital and Satellite Trauma Center");
                        hIntent.PutExtra("City", "Las Piñas City");
                        hIntent.PutExtra("Add", "Diego Cera Ave, Bernabe Compound, Pulanglupa I, Las Piñas City Metro, Manila, Las Pinas, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 873 0557");
                        StartActivity(hIntent);
                        break;
                    case 30:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Makati Medical Center");
                        hIntent.PutExtra("City", "Makati City");
                        hIntent.PutExtra("Add", "2 Amorsolo Street, Legazpi Village, Makati, 1229 Kalakhang Maynila");
                        hIntent.PutExtra("Contact", "(02) 285 2898");
                        StartActivity(hIntent);
                        break;
                    case 31:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Malabon City Hospital");
                        hIntent.PutExtra("City", "Malabon City");
                        hIntent.PutExtra("Add", "Metro Manila, Longos, City of Malabon, 1409 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 285 2898");
                        StartActivity(hIntent);
                        break;
                    case 32:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Mandaluyong City Medical Center");
                        hIntent.PutExtra("City", "Mandaluyong City");
                        hIntent.PutExtra("Add", "605 Boni Ave, Mandaluyong, 1550 Metro Manila");
                        hIntent.PutExtra("Contact", "0919 781 7760");
                        StartActivity(hIntent);
                        break;
                    case 33:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Martinez Memorial Hospital");
                        hIntent.PutExtra("City", "Caloocan City");
                        hIntent.PutExtra("Add", "198 A. Mabini St.");
                        hIntent.PutExtra("Contact", "(02) 288 8661");
                        StartActivity(hIntent);
                        break;
                    case 34:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "MCU-FDT Medical Foundation Hospital");
                        hIntent.PutExtra("City", "Caloocan City");
                        hIntent.PutExtra("Add", "EDSA");
                        hIntent.PutExtra("Contact", "3672031 to 45");
                        StartActivity(hIntent);
                        break;
                    case 35:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "MCPC St. Therese of Lisieux Doctors Hospital");
                        hIntent.PutExtra("City", "Pasig City");
                        hIntent.PutExtra("Add", "C. Raymundo Ave, Pasig, 1600 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 546 2833");
                        StartActivity(hIntent);
                        break;
                    case 36:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Medical Center Taguig, Inc.");
                        hIntent.PutExtra("City", "Taguig City");
                        hIntent.PutExtra("Add", "Levi Mariano Avenue, Brgy. Ususan, Taguig, 1630 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 888 6284");
                        StartActivity(hIntent);
                        break;
                    case 37:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Metropolitan Medical Center");
                        hIntent.PutExtra("City", "Manila");
                        hIntent.PutExtra("Add", "1357 Masangkay St, Santa Cruz, Manila, 1012 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 863 2500");
                        StartActivity(hIntent);
                        break;
                    case 38:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Mira Mar Hospital");
                        hIntent.PutExtra("City", "Pasay City");
                        hIntent.PutExtra("Add", "F.B. Harrison St, Pasay, 1300 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 831 6922");
                        StartActivity(hIntent);
                        break;
                    case 39:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "M.R. Flores Health Center");
                        hIntent.PutExtra("City", "Pateros City");
                        hIntent.PutExtra("Add", "Pateros, Metro Manila");
                        hIntent.PutExtra("Contact", "63 2 643 3486");
                        StartActivity(hIntent);
                        break;
                    case 40:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "National Center for Mental Health");
                        hIntent.PutExtra("City", "Mandaluyong City");
                        hIntent.PutExtra("Add", "Nueve de Pebrero St., Mauway, Mandaluyong, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 531 9001");
                        StartActivity(hIntent);
                        break;
                    case 41:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Navotas City Hospital");
                        hIntent.PutExtra("City", "Navotas City");
                        hIntent.PutExtra("Add", "M. Naval St, Navotas, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 351 8021");
                        StartActivity(hIntent);
                        break;
                    case 42:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Navotas Emergency and Lying-in Clinic");
                        hIntent.PutExtra("City", "Navotas City");
                        hIntent.PutExtra("Add", "M. Naval St, Navotas, Metro Manila");
                        hIntent.PutExtra("Contact", "282-4082");
                        StartActivity(hIntent);
                        break;
                    case 43:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Nodado General Hospital");
                        hIntent.PutExtra("City", "Caloocan City");
                        hIntent.PutExtra("Add", "Area A, Camarin");
                        hIntent.PutExtra("Contact", "9628021");
                        StartActivity(hIntent);
                        break;
                    case 44:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Olivarez General Hospital");
                        hIntent.PutExtra("City", "Parañaque City");
                        hIntent.PutExtra("Add", "Dr Arcadio Santos Ave, Parañaque, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 826 7966");
                        StartActivity(hIntent);
                        break;
                    case 46:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Ospital ng Maynila Medical Center");
                        hIntent.PutExtra("City", "Manila");
                        hIntent.PutExtra("Add", " 719,President Quirino Avenue,Roxas, Boulevard,Malate, Manila, Metro Manila, 1004 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 524 6061");
                        StartActivity(hIntent);
                        break;
                    case 45:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Ospital ng Makati");
                        hIntent.PutExtra("City", "Makati City");
                        hIntent.PutExtra("Add", "Sampaguita St, Makati, 1218 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 882 6316");
                        StartActivity(hIntent);
                        break;
                    case 47:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Ospital Ng Muntinlupa");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "Civic Drive Filinvest Ave Corporate City, Alabang, Muntinlupa, 1780 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 771 0457");
                        StartActivity(hIntent);
                        break;
                    case 48:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Our Lady of Grace Hospital");
                        hIntent.PutExtra("City", "Caloocan City");
                        hIntent.PutExtra("Add", "8th Avenue corner F. Roxas St.");
                        hIntent.PutExtra("Contact", "3611124");
                        StartActivity(hIntent);
                        break;
                    case 49:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Pagamutang Bayan ng Malabon");
                        hIntent.PutExtra("City", "Malabon City");
                        hIntent.PutExtra("Add", "B-43 Maya-Maya St, Longos, City of Malabon, 1409 Metro Manila");
                        hIntent.PutExtra("Contact", "0939 188 7757");
                        StartActivity(hIntent);
                        break;
                    case 50:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Paranaque Doctor's Hospital");
                        hIntent.PutExtra("City", "Parañaque City");
                        hIntent.PutExtra("Add", "175 Doña Soledad Ave Better Living Subdivision, Parañaque, 1711 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 776 0644");
                        StartActivity(hIntent);
                        break;
                    case 51:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Pasay City General Hospital");
                        hIntent.PutExtra("City", "Pasay City");
                        hIntent.PutExtra("Add", " P. Burgos St., Pasay, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 833 6022");
                        StartActivity(hIntent);
                        break;
                    case 52:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Pasig City General Hospital");
                        hIntent.PutExtra("City", "Pasig City");
                        hIntent.PutExtra("Add", "547 Eusebio, Pasig, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 642 7380");
                        StartActivity(hIntent);
                        break;
                    case 53:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Protacio Hospital");
                        hIntent.PutExtra("City", "Parañaque City");
                        hIntent.PutExtra("Add", "484 Quirino Ave, Baclaran, Parañaque, 1700 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 852 2953");
                        StartActivity(hIntent);
                        break;
                    case 54:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Providence Hospital");
                        hIntent.PutExtra("City", "Quezon City");
                        hIntent.PutExtra("Add", "1515 Quezon Ave, Diliman, Quezon City, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 558 6999");
                        StartActivity(hIntent);
                        break;
                    case 55:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Rizal Medical Center");
                        hIntent.PutExtra("City", "Pasig City");
                        hIntent.PutExtra("Add", "Pasig Blvd, Pasig, 1600 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 865 8400");
                        StartActivity(hIntent);
                        break;
                    case 56:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Quezon City General Hospital");
                        hIntent.PutExtra("City", "Quezon City");
                        hIntent.PutExtra("Add", "Project 8, Quezon City, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 426 1314");
                        StartActivity(hIntent);
                        break;
                    case 57:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Saint Claire's Hospital and Nursery Dormitory");
                        hIntent.PutExtra("City", "Pasay City");
                        hIntent.PutExtra("Add", "Pasay City Sport Complex, Pasay City, 1300 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 833 2625");
                        StartActivity(hIntent);
                        break;
                    case 58:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Saint Joseph Maternity and Medical Clinic");
                        hIntent.PutExtra("City", "Navotas City");
                        hIntent.PutExtra("Add", "285, M. Naval Street, Barangay Sipac, Navotas, 1485 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 281 9091");
                        StartActivity(hIntent);
                        break;
                    case 59:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "San Juan Medical Center");
                        hIntent.PutExtra("City", "San Juan City");
                        hIntent.PutExtra("Add", "71 N Domingo St, San Juan, 1500 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 724 3266");
                        StartActivity(hIntent);
                        break;
                    case 60:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Santa Rita De Baclaran Hospital");
                        hIntent.PutExtra("City", "Parañaque City");
                        hIntent.PutExtra("Add", "1072 G.G. Cruz, Baclaran, Parañaque, 1700 Kalakhang Maynila");
                        hIntent.PutExtra("Contact", "(02) 831 7006");
                        StartActivity(hIntent);
                        break;
                    case 61:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "San Lorenzo Ruiz Women's Hospital");
                        hIntent.PutExtra("City", "Malabon City");
                        hIntent.PutExtra("Add", "o. reyes St., Malabon, 1478 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 294 4853");
                        StartActivity(hIntent);
                        break;
                    case 62:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Santissimo Rosario General Hospital");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "2 Espiritu St. Espiritu, Lungsod ng Valenzuela, Kalakhang Maynila");
                        hIntent.PutExtra("Contact", "(02) 291 6985");
                        StartActivity(hIntent);
                        break;
                    case 63:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "St. Anthony Medical Center");
                        hIntent.PutExtra("City", "Marikina City");
                        hIntent.PutExtra("Add", "32 Santa Ana Ext., Marikina, 1801 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 682 2000");
                        StartActivity(hIntent);
                        break;
                    case 64:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "St. Clare’s Medical Center");
                        hIntent.PutExtra("City", "Makati City");
                        hIntent.PutExtra("Add", "1838 Dian St, Makati, 1235 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 831 6511");
                        StartActivity(hIntent);
                        break;
                    case 65:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "St. Luke's Medical Center - Quezon City");
                        hIntent.PutExtra("City", "Quezon City");
                        hIntent.PutExtra("Add", "279 E Rodriguez Sr. Ave, Quezon City, 1112 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 723 0101");
                        StartActivity(hIntent);
                        break;
                    case 66:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "St. Martin de Porres Charity Hospital");
                        hIntent.PutExtra("City", "San Juan City");
                        hIntent.PutExtra("Add", "Bonifacio Street, San Juan, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 723 0741");
                        StartActivity(hIntent);
                        break;
                   case 67:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "St. Victoria Hospital");
                        hIntent.PutExtra("City", "Marikina City");
                        hIntent.PutExtra("Add", " 444JP Rizal, Sto Nino, Marikina, 1800 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 942 2022");
                        StartActivity(hIntent);
                        break;
                    case 68:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Taguig District Hospital");
                        hIntent.PutExtra("City", "Pateros City");
                        hIntent.PutExtra("Add", "Service Rd, Taguig-Pateros, Taguig, 1630 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 837 8132");
                        StartActivity(hIntent);
                        break;
                    case 69:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "The Medical City");
                        hIntent.PutExtra("City", "Pasig City");
                        hIntent.PutExtra("Add", "Ortigas Ave, Pasig, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 988 1000");
                        StartActivity(hIntent);
                        break;
                    case 70:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Tokyo Healthlink Inc, Alabang");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "2 Madrigal Ave, Ayala Alabang, Muntinlupa, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 772 2678");
                        StartActivity(hIntent);
                        break;
                    case 71:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Unciano General Hospital");
                        hIntent.PutExtra("City", "Makati City");
                        hIntent.PutExtra("Add", "Boni Avenue Corner Dansalan Street, Mandaluyong, 1550 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 533 6565");
                        StartActivity(hIntent);
                        break;
                    case 72:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Unihealth-Paranaque & Hospital Medical Center");
                        hIntent.PutExtra("City", "Parañaque City");
                        hIntent.PutExtra("Add", "Dr Arcadio Santos Ave, Parañaque, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 832 0636");
                        StartActivity(hIntent);
                        break;
                    case 73:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "University of Perpetual Help DALTA Medical Center");
                        hIntent.PutExtra("City", "Las Piñas City");
                        hIntent.PutExtra("Add", "Alabang - Zapote Road, Las Pinas, 1740 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 874 8515");
                        StartActivity(hIntent);
                        break;
                    case 74:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Valenzuela Citicare Medical Center");
                        hIntent.PutExtra("City", "Valenzuela City");
                        hIntent.PutExtra("Add", "MacArthur Highway, Valenzuela, Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 860 9300");
                        StartActivity(hIntent);
                        break;
                    case 75:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Valenzuela City General Hospital");
                        hIntent.PutExtra("City", "Muntinlupa City");
                        hIntent.PutExtra("Add", "Padrigal St, Karuhatan, Valenzuela City, 1441 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 294 6711");
                        StartActivity(hIntent);
                        break;
                    case 76:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "Victor R. Potenciano Medical Center");
                        hIntent.PutExtra("City", "Mandaluyong City");
                        hIntent.PutExtra("Add", "163 Epifanio de los Santos Ave, Mandaluyong, 1501 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 464 9999");
                        StartActivity(hIntent);
                        break;
                    case 77:
                        hIntent = new Intent(this, typeof(HospitalDesc));
                        hIntent.PutExtra("Name", "VT Maternity Hospital");
                        hIntent.PutExtra("City", "Marikina City");
                        hIntent.PutExtra("Add", "22 Guerilla St. Toyota Ave, Marikina, 1800 Metro Manila");
                        hIntent.PutExtra("Contact", "(02) 942 6669");
                        StartActivity(hIntent);
                        break;
                }

            };

        }
      
    }
}
