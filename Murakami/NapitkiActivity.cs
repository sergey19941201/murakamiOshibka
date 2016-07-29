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
    [Activity(Label = "NapitkiActivity")]
    public class NapitkiActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Napitki);

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename = System.IO.Path.Combine(path, "cache10.txt");
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
                var intent = new Intent(this, typeof(SokRichYabluchniy));
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
            price.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichTomatniy));
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
            price1.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichPersikoviy));
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
            price2.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichEkzotik));
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
            price3.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichGreypfrutoviy));
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
            price4.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichVishneviy));
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
            price5.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichApelsinoviy));
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
            price6.Text = firstitem["price"] + " грн";
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
                var intent = new Intent(this, typeof(sokRichAnanasoviy));
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
            price7.Text = firstitem["price"] + " грн";
            weight7.Text = firstitem["weight"];


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen7, firstitem["img_url"], null, 5000000);

        }
    }
}