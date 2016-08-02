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
    [Activity(Label = "LanchiActivity")]
    public class LanchiActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Lanchi);

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
            var filename = System.IO.Path.Combine(path, "cache7.txt");
            JsonValue readJson;
            var jsonString = File.ReadAllText(filename);
            readJson = JsonObject.Parse(jsonString);

            ParseAndDisplay(readJson);
            ParseAndDisplay1(readJson);
            ParseAndDisplay2(readJson);
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
                var intent = new Intent(this, typeof(kuriniyBulionSYaytsomSalatOvoshchnoySZapravkoyNasuKrahmalnayaLapshaSOvoshchamiISvininoy));
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
                var intent = new Intent(this, typeof(supMisoSalatOvoshchnoySLososemKurinieKrilliaTeriakiSSirnimSousom));
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
                var intent = new Intent(this, typeof(fudziyama));
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
    }
}