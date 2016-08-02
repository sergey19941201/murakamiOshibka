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
    [Activity(Label = "SetRestoranovActivity", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SetRestoranovActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.SetRestoranov);

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

            ImageButton smotret_na_karte = FindViewById<ImageButton>(Resource.Id.smotret_na_karte);
            smotret_na_karte.Click += delegate
            {
                var intent = new Intent(this, typeof(kartaActivity));
                StartActivity(intent);
            };
        }
    }
}






