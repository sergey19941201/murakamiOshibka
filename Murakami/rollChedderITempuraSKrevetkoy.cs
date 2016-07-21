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
using System.Globalization;

namespace Murakami
{
    [Activity(Label = "rollChedderITempuraSKrevetkoy", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class rollChedderITempuraSKrevetkoy : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.detalniyProsmotr);

            int count = 1;
            //int price2;



            ImageButton plus = FindViewById<ImageButton>(Resource.Id.plus);


            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filename = System.IO.Path.Combine(path, "cache.txt");
            JsonValue readJson;
            var jsonString = File.ReadAllText(filename);
            readJson = JsonObject.Parse(jsonString);

            ParseAndDisplay(readJson);
        }

        private async void ParseAndDisplay(JsonValue readJson)
        {
            TextView productname = FindViewById<TextView>(Resource.Id.posttitle);
            TextView price = FindViewById<TextView>(Resource.Id.price);
            TextView discription = FindViewById<TextView>(Resource.Id.discription);
            TextView weight = FindViewById<TextView>(Resource.Id.weight);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.image);
            TextView quantity = FindViewById<TextView>(Resource.Id.quantity);

            ImageButton plus = FindViewById<ImageButton>(Resource.Id.plus);
            int count = 1;
            int sku;

            JsonValue firstitem = readJson[0];

            productname.Text = firstitem["post_title"];
            price.Text = firstitem["price"];
            weight.Text = firstitem["weight"];
            discription.Text = firstitem["post_excerpt"];
            sku = firstitem["sku"];


            ImageButton minus = FindViewById<ImageButton>(Resource.Id.minus);


            Koush.UrlImageViewHelper.SetUrlDrawable(imagen, firstitem["img_url"], null, 5000000);


            float price2 = float.Parse(price.Text, CultureInfo.InvariantCulture);
            plus.Click += delegate
            {
                quantity.Text = string.Format("{0}", ++count);
                price.Text = string.Format("{0}", count * price2);
            };
            minus.Click += delegate
            {
                quantity.Text = string.Format("{0}", count > 1 ? --count : 1);
                price.Text = string.Format("{0}", count * price2);
            };
        }
    }
}