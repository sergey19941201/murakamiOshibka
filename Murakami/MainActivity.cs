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
using Android.Content.PM;
using System.Timers;
using Android.Net;
using System.Xml;
using System.IO;

using System.Threading.Tasks;
using Murakami;


namespace Murakami
{

    [Activity(MainLauncher = true, NoHistory = true, Label = "Murakami", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Splash);

            CheckNetwork();

            //dlia Inshi rolli
            string url = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=82";
            var json = await FetchAsync(url);

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(path, "cache.txt");
            File.WriteAllText(filename, json);

            //dlia Goryachie rolli
            string url1 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=83";
            var json1 = await FetchAsync1(url1);

            var path1 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename1 = Path.Combine(path1, "cache1.txt");
            File.WriteAllText(filename1, json1);

            //dlia California
            string url2 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=85";
            var json2 = await FetchAsync2(url2);

            var path2 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename2 = Path.Combine(path2, "cache2.txt");
            File.WriteAllText(filename2, json2);

            //dlia Deserts
            string url3 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=74";
            var json3 = await FetchAsync3(url3);

            var path3 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename3 = Path.Combine(path3, "cache3.txt");
            File.WriteAllText(filename3, json3);

            //dlia bluda dnia 
            string url4 = "http://new.murakami.ua/?mkapi=getProductsOfDay";
            var json4 = await FetchAsync4(url4);

            var path4 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename4 = Path.Combine(path4, "cache4.txt");
            File.WriteAllText(filename4, json4);

            //dlia Drakoni 
            string url5 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=84";
            var json5 = await FetchAsync5(url5);

            var path5 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename5 = Path.Combine(path5, "cache5.txt");
            File.WriteAllText(filename5, json5);

            //dlia Filadelfia 
            string url6 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=87";
            var json6 = await FetchAsync6(url6);

            var path6 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename6 = Path.Combine(path6, "cache6.txt");
            File.WriteAllText(filename6, json6);

            //dlia Lanchi 
            string url7 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=182";
            var json7 = await FetchAsync7(url7);

            var path7 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename7 = Path.Combine(path7, "cache7.txt");
            File.WriteAllText(filename7, json7);

            //dlia Lapsha 
            string url8 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=70";
            var json8 = await FetchAsync8(url8);

            var path8 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename8 = Path.Combine(path8, "cache8.txt");
            File.WriteAllText(filename8, json8);

            //dlia Maki 
            string url9 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=86";
            var json9 = await FetchAsync9(url9);

            var path9 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename9 = Path.Combine(path9, "cache9.txt");
            File.WriteAllText(filename9, json9);

            //dlia Napitki 
            string url10 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=79,176";
            var json10 = await FetchAsync10(url10);

            var path10 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename10 = Path.Combine(path10, "cache10.txt");
            File.WriteAllText(filename10, json10);

            //dlia OsnovniBluda 
            string url11 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=72";
            var json11 = await FetchAsync11(url11);

            var path11 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename11 = Path.Combine(path11, "cache11.txt");
            File.WriteAllText(filename11, json11);

            //dlia Salads 
            string url12 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=88";
            var json12 = await FetchAsync12(url12);

            var path12 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename12 = Path.Combine(path12, "cache12.txt");
            File.WriteAllText(filename12, json12);

            //dlia Sashimi 
            string url13 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=89";
            var json13 = await FetchAsync13(url13);

            var path13 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename13 = Path.Combine(path13, "cache13.txt");
            File.WriteAllText(filename13, json13);

            //dlia Sets 
            string url14 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=77";
            var json14 = await FetchAsync14(url14);

            var path14 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename14 = Path.Combine(path14, "cache14.txt");
            File.WriteAllText(filename14, json14);

            //dlia Souces 
            string url15 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=90";
            var json15 = await FetchAsync15(url15);

            var path15 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename15 = Path.Combine(path15, "cache15.txt");
            File.WriteAllText(filename15, json15);

            //dlia Soupes 
            string url16 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=91";
            var json16 = await FetchAsync16(url16);

            var path16 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename16 = Path.Combine(path16, "cache16.txt");
            File.WriteAllText(filename16, json16);

            //dlia Sushi 
            string url17 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=92";
            var json17 = await FetchAsync17(url17);

            var path17 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename17 = Path.Combine(path17, "cache17.txt");
            File.WriteAllText(filename17, json17);

            //dlia Tepan 
            string url18 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=95";
            var json18 = await FetchAsync18(url18);

            var path18 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename18 = Path.Combine(path18, "cache18.txt");
            File.WriteAllText(filename18, json18);

            //dlia Zakuski 
            string url19 = "http://www.murakami.ua/?mkapi=getProductsByCat&cat_id=75";
            var json19 = await FetchAsync19(url19);

            var path19 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename19 = Path.Combine(path19, "cache19.txt");
            File.WriteAllText(filename19, json19);

            //dlia Akcii 
            string url20 = "http://murakami.ua/?mkapi=getActions";
            var json20 = await FetchAsync20(url20);

            var path20 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename20 = Path.Combine(path20, "cache20.txt");
            File.WriteAllText(filename20, json20);

            //dlia Novosti 
            string url21 = "http://murakami.ua/?mkapi=getNews";
            var json21 = await FetchAsync21(url21);

            var path21 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename21 = Path.Combine(path21, "cache21.txt");
            File.WriteAllText(filename21, json21);

            //timer      
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 sec.
            timer.AutoReset = false; // Do not reset the timer after it's elapsed
            timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                StartActivity(typeof(MainActivity));
            };
            timer.Start();
        }


        //dlia Inshi rolli
        public async Task<string> FetchAsync(string url)
        {
            string jsonString;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url);
                StreamReader reader = new StreamReader(stream);
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }

        //dlia Goryachie rolli
        public async Task<string> FetchAsync1(string url1)
        {
            string jsonString1;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url1);
                StreamReader reader = new StreamReader(stream);
                jsonString1 = reader.ReadToEnd();
            }

            return jsonString1;
        }

        //dlia California
        public async Task<string> FetchAsync2(string url2)
        {
            string jsonString2;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url2);
                StreamReader reader = new StreamReader(stream);
                jsonString2 = reader.ReadToEnd();
            }

            return jsonString2;
        }

        //dlia Deserts
        public async Task<string> FetchAsync3(string url3)
        {
            string jsonString3;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url3);
                StreamReader reader = new StreamReader(stream);
                jsonString3 = reader.ReadToEnd();
            }

            return jsonString3;
        }

        //dlia bluda dnia
        public async Task<string> FetchAsync4(string url4)
        {
            string jsonString4;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url4);
                StreamReader reader = new StreamReader(stream);
                jsonString4 = reader.ReadToEnd();
            }

            return jsonString4;
        }

        //dlia Drakoni
        public async Task<string> FetchAsync5(string url5)
        {
            string jsonString5;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url5);
                StreamReader reader = new StreamReader(stream);
                jsonString5 = reader.ReadToEnd();
            }

            return jsonString5;
        }

        //dlia Filadelfia 

        public async Task<string> FetchAsync6(string url6)
        {
            string jsonString6;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url6);
                StreamReader reader = new StreamReader(stream);
                jsonString6 = reader.ReadToEnd();
            }

            return jsonString6;
        }

        //dlia Lanchi 

        public async Task<string> FetchAsync7(string url7)
        {
            string jsonString7;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url7);
                StreamReader reader = new StreamReader(stream);
                jsonString7 = reader.ReadToEnd();
            }

            return jsonString7;
        }

        //dlia Lapsha 
        public async Task<string> FetchAsync8(string url8)
        {
            string jsonString8;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url8);
                StreamReader reader = new StreamReader(stream);
                jsonString8 = reader.ReadToEnd();
            }

            return jsonString8;
        }

        //dlia Maki 
        public async Task<string> FetchAsync9(string url9)
        {
            string jsonString9;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url9);
                StreamReader reader = new StreamReader(stream);
                jsonString9 = reader.ReadToEnd();
            }

            return jsonString9;
        }

        //dlia Napitki 
        public async Task<string> FetchAsync10(string url10)
        {
            string jsonString10;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url10);
                StreamReader reader = new StreamReader(stream);
                jsonString10 = reader.ReadToEnd();
            }

            return jsonString10;
        }

        //dlia OsnovniBluda 
        public async Task<string> FetchAsync11(string url11)
        {
            string jsonString11;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url11);
                StreamReader reader = new StreamReader(stream);
                jsonString11 = reader.ReadToEnd();
            }

            return jsonString11;
        }

        //dlia Salads 
        public async Task<string> FetchAsync12(string url12)
        {
            string jsonString12;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url12);
                StreamReader reader = new StreamReader(stream);
                jsonString12 = reader.ReadToEnd();
            }

            return jsonString12;
        }

        //dlia Sashimi 
        public async Task<string> FetchAsync13(string url13)
        {
            string jsonString13;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url13);
                StreamReader reader = new StreamReader(stream);
                jsonString13 = reader.ReadToEnd();
            }

            return jsonString13;
        }

        //dlia Sets 
        public async Task<string> FetchAsync14(string url14)
        {
            string jsonString14;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url14);
                StreamReader reader = new StreamReader(stream);
                jsonString14 = reader.ReadToEnd();
            }

            return jsonString14;
        }

        //dlia Souces 
        public async Task<string> FetchAsync15(string url15)
        {
            string jsonString15;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url15);
                StreamReader reader = new StreamReader(stream);
                jsonString15 = reader.ReadToEnd();
            }

            return jsonString15;
        }

        //dlia Soupes 
        public async Task<string> FetchAsync16(string url16)
        {
            string jsonString16;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url16);
                StreamReader reader = new StreamReader(stream);
                jsonString16 = reader.ReadToEnd();
            }

            return jsonString16;
        }

        //dlia Sushi 
        public async Task<string> FetchAsync17(string url17)
        {
            string jsonString17;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url17);
                StreamReader reader = new StreamReader(stream);
                jsonString17 = reader.ReadToEnd();
            }

            return jsonString17;
        }

        //dlia Tepan 
        public async Task<string> FetchAsync18(string url18)
        {
            string jsonString18;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url18);
                StreamReader reader = new StreamReader(stream);
                jsonString18 = reader.ReadToEnd();
            }

            return jsonString18;
        }

        //dlia Zakuski 
        public async Task<string> FetchAsync19(string url19)
        {
            string jsonString19;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url19);
                StreamReader reader = new StreamReader(stream);
                jsonString19 = reader.ReadToEnd();
            }

            return jsonString19;
        }

        //dlia Akcii 
        public async Task<string> FetchAsync20(string url20)
        {
            string jsonString20;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url20);
                StreamReader reader = new StreamReader(stream);
                jsonString20 = reader.ReadToEnd();
            }

            return jsonString20;
        }

        //dlia Novosti 
        public async Task<string> FetchAsync21(string url21)
        {
            string jsonString21;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url21);
                StreamReader reader = new StreamReader(stream);
                jsonString21 = reader.ReadToEnd();
            }

            return jsonString21;
        }


        // metod proverki ineta
        public void CheckNetwork()
        {
            var connectivityManager = (ConnectivityManager)GetSystemService(ConnectivityService);
            var activeConnection = connectivityManager.ActiveNetworkInfo;
            if ((activeConnection != null) && activeConnection.IsConnected)
            {
                //Toast.MakeText (this, "OK", ToastLength.Short).Show ();
            }
            else
            {
                //Toast.MakeText (this, "Подключитесь к интернету", ToastLength.Short).Show ();
                RunOnUiThread(() =>
                {
                    AlertDialog.Builder builder;
                    builder = new AlertDialog.Builder(this);
                    builder.SetTitle("Внимание! ");
                    builder.SetMessage("Подключитесь к интернету");
                    builder.SetCancelable(false);
                    builder.SetPositiveButton("Готово", delegate { Finish(); });
                    builder.Show();
                }
                );
            }
        }
    }

    [Activity(Label = "Murakami", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            ImageButton menu = FindViewById<ImageButton>(Resource.Id.menu);
            menu.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            ImageButton logo_murakami = FindViewById<ImageButton>(Resource.Id.logo_murakami);
            logo_murakami.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
            

            Button restorani = FindViewById<Button>(Resource.Id.restorani);
            restorani.Click += delegate
            {
                var intent = new Intent(this, typeof(SetRestoranovActivity));
                StartActivity(intent);
            };

            Button bludoDnia = FindViewById<Button>(Resource.Id.bludoDnia);
            bludoDnia.Click += delegate
            {
                var intent = new Intent(this, typeof(BludoDniaActivity));
                StartActivity(intent);
            };

            Button dostavka = FindViewById<Button>(Resource.Id.dostavka);
            dostavka.Click += delegate
            {
                var intent = new Intent(this, typeof(MenuActivity));
                StartActivity(intent);
            };

            Button proMurkami = FindViewById<Button>(Resource.Id.proMurkami);
            proMurkami.Click += delegate
            {
                var intent = new Intent(this, typeof(ProMurakamiActivity));
                StartActivity(intent);
            };

            ImageButton vk = FindViewById<ImageButton>(Resource.Id.vk);
            vk.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vk.com/murakami_restaurant_delivery");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            ImageButton twitter = FindViewById<ImageButton>(Resource.Id.twitter);
            twitter.Click += delegate
            {

                var uri = Android.Net.Uri.Parse("https://twitter.com/murakami_rest");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            ImageButton facebook = FindViewById<ImageButton>(Resource.Id.facebook);
            facebook.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://www.facebook.com/MURAKAMI.rest");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            ImageButton instagram = FindViewById<ImageButton>(Resource.Id.instagram);
            instagram.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://www.instagram.com/murakami_in_ua/");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            Button call = FindViewById<Button>(Resource.Id.tel);
            call.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("tel:+380442308888");
                var intent641 = new Intent(Intent.ActionDial, uri);
                StartActivity(intent641);
            };

            Button akcii = FindViewById<Button>(Resource.Id.akcii);
            akcii.Click += delegate
            {
                var intent = new Intent(this, typeof(AkciiActivity));
                StartActivity(intent);
            };

            Button novosti = FindViewById<Button>(Resource.Id.novosti);
            novosti.Click += delegate
            {
                var intent = new Intent(this, typeof(NovostiActivity));
                StartActivity(intent);
            };

        }

        public async Task<string> FetchAsync(string url)
        {
            string jsonString;
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url);
                StreamReader reader = new StreamReader(stream);
                jsonString = reader.ReadToEnd();
            }
            return jsonString;
        }

    }

}



