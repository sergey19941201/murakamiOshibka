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
using Android.Graphics;
using Android.Preferences;


namespace Murakami
{
    [Activity(Label = "Murakami", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ProMurakamiActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProMurkami);

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
            call.Click += delegate {
                var uri = Android.Net.Uri.Parse("tel:+380442308888");
                var intent641 = new Intent(Intent.ActionDial, uri);
                StartActivity(intent641);
            };
        }
    }
}