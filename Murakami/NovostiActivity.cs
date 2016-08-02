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
    [Activity(Label = "NovostiActivity")]
    public class NovostiActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Novosti);

            ImageButton menuButton = FindViewById<ImageButton>(Resource.Id.menuButton);
            menuButton.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            ImageButton logoButton = FindViewById<ImageButton>(Resource.Id.logoButton);
            logoButton.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename = System.IO.Path.Combine(path, "cache21.txt");
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
            TextView name = FindViewById<TextView>(Resource.Id.name);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.image);

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

            name.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay1(JsonValue readJson)
        {
            TextView name1 = FindViewById<TextView>(Resource.Id.name1);
            ImageView imagen1 = FindViewById<ImageView>(Resource.Id.image1);

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

            name1.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen1, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay2(JsonValue readJson)
        {
            TextView name2 = FindViewById<TextView>(Resource.Id.name2);
            ImageView imagen2 = FindViewById<ImageView>(Resource.Id.image2);

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

            name2.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen2, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay3(JsonValue readJson)
        {
            TextView name3 = FindViewById<TextView>(Resource.Id.name3);
            ImageView imagen3 = FindViewById<ImageView>(Resource.Id.image3);

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

            name3.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen3, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay4(JsonValue readJson)
        {
            TextView name4 = FindViewById<TextView>(Resource.Id.name4);
            ImageView imagen4 = FindViewById<ImageView>(Resource.Id.image4);

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

            name4.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen4, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay5(JsonValue readJson)
        {
            TextView name5 = FindViewById<TextView>(Resource.Id.name5);
            ImageView imagen5 = FindViewById<ImageView>(Resource.Id.image5);

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

            name5.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen5, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay6(JsonValue readJson)
        {
            TextView name6 = FindViewById<TextView>(Resource.Id.name6);
            ImageView imagen6 = FindViewById<ImageView>(Resource.Id.image6);

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

            name6.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen6, firstitem["img"], null, 5000000);

        }

        private async void ParseAndDisplay7(JsonValue readJson)
        {
            TextView name7 = FindViewById<TextView>(Resource.Id.name7);
            ImageView imagen7 = FindViewById<ImageView>(Resource.Id.image7);

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

            name7.Text = firstitem["title"];

            Koush.UrlImageViewHelper.SetUrlDrawable(imagen7, firstitem["img"], null, 5000000);

        }
    }
}
