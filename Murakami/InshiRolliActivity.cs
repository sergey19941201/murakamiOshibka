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

using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Json;
using Android.Graphics;
using Android.Preferences;

namespace Murakami
{
    [Activity(Label = "InshiRolliActivity")]
    public class InshiRolliActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.InshiRolli);

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename = System.IO.Path.Combine(path, "cache.txt");
            JsonValue readJson;
            var jsonString = File.ReadAllText(filename);
            readJson = JsonObject.Parse(jsonString);


            ParseAndDisplay(readJson);
            ParseAndDisplay1(readJson);
            ParseAndDisplay2(readJson);
            ParseAndDisplay3(readJson);
            ParseAndDisplay4(readJson);
            ParseAndDisplay5(readJson);
            ParseAndDisplay6(readJson);
            ParseAndDisplay7(readJson);
            ParseAndDisplay8(readJson);
            ParseAndDisplay9(readJson);
            ParseAndDisplay10(readJson);
            ParseAndDisplay11(readJson);
            ParseAndDisplay12(readJson);
            ParseAndDisplay13(readJson);

            //buttons
          
        }

        private async void ParseAndDisplay(JsonValue readJson)
        {
            TextView productname = FindViewById<TextView>(Resource.Id.posttitle);
            TextView price = FindViewById<TextView>(Resource.Id.price);
            TextView weight = FindViewById<TextView>(Resource.Id.weight);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.image);

            ImageButton add = FindViewById<ImageButton>(Resource.Id.add);
            

            add.Click += delegate
            {
                var intent = new Intent(this, typeof(rollChedderITempuraSKrevetkoy));
                StartActivity(intent);
            };

          
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[0];

            productname.Text = firstitem["post_title"];
            price.Text = firstitem["price"] + " ���";
            weight.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay1(JsonValue readJson)
        {
            TextView productname1 = FindViewById<TextView>(Resource.Id.posttitle1);
            TextView price1 = FindViewById<TextView>(Resource.Id.price1);
            TextView weight1 = FindViewById<TextView>(Resource.Id.weight1);
            ImageView imagen1 = FindViewById<ImageView>(Resource.Id.image1);
            ImageButton add1 = FindViewById<ImageButton>(Resource.Id.add1);

            add1.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSpaisiLosos));
                StartActivity(intent);
            };

            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[1];

            productname1.Text = firstitem["post_title"];
            price1.Text = firstitem["price"] + " ���";
            weight1.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen1, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay2(JsonValue readJson)
        {

            TextView productname2 = FindViewById<TextView>(Resource.Id.posttitle2);
            TextView price2 = FindViewById<TextView>(Resource.Id.price2);
            TextView weight2 = FindViewById<TextView>(Resource.Id.weight2);
            ImageView imagen2 = FindViewById<ImageView>(Resource.Id.image2);
            ImageButton add2 = FindViewById<ImageButton>(Resource.Id.add2);

            add2.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSPastrami));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[2];

            productname2.Text = firstitem["post_title"];
            price2.Text = firstitem["price"] + " ���";
            weight2.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen2, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay3(JsonValue readJson)
        {

            TextView productname3 = FindViewById<TextView>(Resource.Id.posttitle3);
            TextView price3 = FindViewById<TextView>(Resource.Id.price3);
            TextView weight3 = FindViewById<TextView>(Resource.Id.weight3);
            ImageView imagen3 = FindViewById<ImageView>(Resource.Id.image3);
            ImageButton add3 = FindViewById<ImageButton>(Resource.Id.add3);

            add3.Click += delegate
            {
                var intent = new Intent(this, typeof(rollOgurechniyLosos));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[3];

            productname3.Text = firstitem["post_title"];
            price3.Text = firstitem["price"] + " ���";
            weight3.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen3, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay4(JsonValue readJson)
        {

            TextView productname4 = FindViewById<TextView>(Resource.Id.posttitle4);
            TextView price4 = FindViewById<TextView>(Resource.Id.price4);
            TextView weight4 = FindViewById<TextView>(Resource.Id.weight4);
            ImageView imagen4 = FindViewById<ImageView>(Resource.Id.image4);
            ImageButton add4 = FindViewById<ImageButton>(Resource.Id.add4);

            add4.Click += delegate
            {
                var intent = new Intent(this, typeof(rollOshiAburiSLososemIGolSousom));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[4];

            productname4.Text = firstitem["post_title"];
            price4.Text = firstitem["price"] + " ���";
            weight4.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen4, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay5(JsonValue readJson)
        {
            TextView productname5 = FindViewById<TextView>(Resource.Id.posttitle5);
            TextView price5 = FindViewById<TextView>(Resource.Id.price5);
            TextView weight5 = FindViewById<TextView>(Resource.Id.weight5);
            ImageView imagen5 = FindViewById<ImageView>(Resource.Id.image5);
            ImageButton add5 = FindViewById<ImageButton>(Resource.Id.add5);

            add5.Click += delegate
            {
                var intent = new Intent(this, typeof(rollOshiSLososemITuntsom));
                StartActivity(intent);
            };

            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[5];

            productname5.Text = firstitem["post_title"];
            price5.Text = firstitem["price"] + " ���";
            weight5.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen5, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay6(JsonValue readJson)
        {


            TextView productname6 = FindViewById<TextView>(Resource.Id.posttitle6);
            TextView price6 = FindViewById<TextView>(Resource.Id.price6);
            TextView weight6 = FindViewById<TextView>(Resource.Id.weight6);
            ImageView imagen6 = FindViewById<ImageView>(Resource.Id.image6);
            ImageButton add6 = FindViewById<ImageButton>(Resource.Id.add6);

            add6.Click += delegate
            {
                var intent = new Intent(this, typeof(rollOgurechniyUgor));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[6];

            productname6.Text = firstitem["post_title"];
            price6.Text = firstitem["price"] + " ���";
            weight6.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen6, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay7(JsonValue readJson)
        {
            TextView productname7 = FindViewById<TextView>(Resource.Id.posttitle7);
            TextView price7 = FindViewById<TextView>(Resource.Id.price7);
            TextView weight7 = FindViewById<TextView>(Resource.Id.weight7);
            ImageView imagen7 = FindViewById<ImageView>(Resource.Id.image7);
            ImageButton add7 = FindViewById<ImageButton>(Resource.Id.add7);

            add7.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSTuntsomSnezhnimKrabomISousomIzAvokado));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[7];

            productname7.Text = firstitem["post_title"];
            price7.Text = firstitem["price"] + " ���";
            weight7.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen7, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay8(JsonValue readJson)
        {
            TextView productname8 = FindViewById<TextView>(Resource.Id.posttitle8);
            TextView price8 = FindViewById<TextView>(Resource.Id.price8);
            TextView weight8 = FindViewById<TextView>(Resource.Id.weight8);
            ImageView imagen8 = FindViewById<ImageView>(Resource.Id.image8);
            ImageButton add8 = FindViewById<ImageButton>(Resource.Id.add8);

            add8.Click += delegate
            {
                var intent = new Intent(this, typeof(rollRainbowNewStyle));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[8];

            productname8.Text = firstitem["post_title"];
            price8.Text = firstitem["price"] + " ���";
            weight8.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen8, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay9(JsonValue readJson)
        {
            TextView productname9 = FindViewById<TextView>(Resource.Id.posttitle9);
            TextView price9 = FindViewById<TextView>(Resource.Id.price9);
            TextView weight9 = FindViewById<TextView>(Resource.Id.weight9);
            ImageView imagen9 = FindViewById<ImageView>(Resource.Id.image9);
            ImageButton add9 = FindViewById<ImageButton>(Resource.Id.add9);

            add9.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSpaisiTunets));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[9];


            productname9.Text = firstitem["post_title"];
            price9.Text = firstitem["price"] + " ���";
            weight9.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen9, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay10(JsonValue readJson)
        {
            TextView productname10 = FindViewById<TextView>(Resource.Id.posttitle10);
            TextView price10 = FindViewById<TextView>(Resource.Id.price10);
            TextView weight10 = FindViewById<TextView>(Resource.Id.weight10);
            ImageView imagen10 = FindViewById<ImageView>(Resource.Id.image10);
            ImageButton add10 = FindViewById<ImageButton>(Resource.Id.add10);

            add10.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSpaisiOsminog));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[10];



            productname10.Text = firstitem["post_title"];
            price10.Text = firstitem["price"] + " ���";
            weight10.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen10, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay11(JsonValue readJson)
        {

            TextView productname11 = FindViewById<TextView>(Resource.Id.posttitle11);
            TextView price11 = FindViewById<TextView>(Resource.Id.price11);
            TextView weight11 = FindViewById<TextView>(Resource.Id.weight11);
            ImageView imagen11 = FindViewById<ImageView>(Resource.Id.image11);
            ImageButton add11 = FindViewById<ImageButton>(Resource.Id.add11);

            add11.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSUgremIAvokado));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[11];


            productname11.Text = firstitem["post_title"];
            price11.Text = firstitem["price"] + " ���";
            weight11.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen11, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay12(JsonValue readJson)
        {
            TextView productname12 = FindViewById<TextView>(Resource.Id.posttitle12);
            TextView price12 = FindViewById<TextView>(Resource.Id.price12);
            TextView weight12 = FindViewById<TextView>(Resource.Id.weight12);
            ImageView imagen12 = FindViewById<ImageView>(Resource.Id.image12);
            ImageButton add12 = FindViewById<ImageButton>(Resource.Id.add12);

            add12.Click += delegate
            {
                var intent = new Intent(this, typeof(rollSoSniezhnimKrabomIOgurtsom));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[12];


            productname12.Text = firstitem["post_title"];
            price12.Text = firstitem["price"] + " ���";
            weight12.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen12, firstitem["img_url"], null, 5000000);

        }
        private async void ParseAndDisplay13(JsonValue readJson)
        {


            TextView productname13 = FindViewById<TextView>(Resource.Id.posttitle13);
            TextView price13 = FindViewById<TextView>(Resource.Id.price13);
            TextView weight13 = FindViewById<TextView>(Resource.Id.weight13);
            ImageView imagen13 = FindViewById<ImageView>(Resource.Id.image13);
            ImageButton add13 = FindViewById<ImageButton>(Resource.Id.add13);

            add13.Click += delegate
            {
                var intent = new Intent(this, typeof(rollAliaska));
                StartActivity(intent);
            };
            // Zagruska detalnogo prosmotra, ego poka net
            /* add.Click += delegate
             {
                 var intent = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent);
             };
             productname.Click += delegate
             {
                 var intent485 = new Intent(this, typeof(BludoDniaActivity));
                 StartActivity(intent485);
             };*/

            JsonValue firstitem = readJson[13];

            productname13.Text = firstitem["post_title"];
            price13.Text = firstitem["price"] + " ���";
            weight13.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen13, firstitem["img_url"], null, 5000000);

        }
}
 
}