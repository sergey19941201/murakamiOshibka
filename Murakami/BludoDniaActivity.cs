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
    [Activity(Label = "BludoDniaActivity", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class BludoDniaActivity : Activity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BludoDnia);

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
            var filename = System.IO.Path.Combine(path, "cache4.txt");
            JsonValue readJson;
            var jsonString = File.ReadAllText(filename);
            readJson = JsonObject.Parse(jsonString);

           ParseAndDisplay(readJson);

        }

        private async void ParseAndDisplay(JsonValue readJson)
        {
            TextView productname = FindViewById<TextView>(Resource.Id.posttitle);
            TextView price = FindViewById<TextView>(Resource.Id.price);
            TextView weight = FindViewById<TextView>(Resource.Id.weight);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.image);
            ImageButton add = FindViewById<ImageButton>(Resource.Id.add);

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
    }
}






