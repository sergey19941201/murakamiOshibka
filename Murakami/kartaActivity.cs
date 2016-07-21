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
using Android.Gms.Maps;

namespace Murakami
{
    [Activity(Label = "kartaActivity", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class kartaActivity : Activity, IOnMapReadyCallback
    {

        private GoogleMap mMap;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.karta);

            ImageButton spisok = FindViewById<ImageButton>(Resource.Id.spisok);
            spisok.Click += delegate
            {
                var intent = new Intent(this, typeof(SetRestoranovActivity));
                StartActivity(intent);
            };

            SetUpMap();
        }




        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;
        }

    }
}