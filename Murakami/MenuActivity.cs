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
    [Activity(Label = "Murakami", Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Menu);


           
            Button rolli = FindViewById<Button>(Resource.Id.rolli);
            rolli.Click += delegate
            {
                var intent = new Intent(this, typeof(InshiRolliActivity));
                StartActivity(intent);
            };

            Button seti = FindViewById<Button>(Resource.Id.seti);
            seti.Click += delegate
            {
                var intent = new Intent(this, typeof(SetsActivity));
                StartActivity(intent);
            };

            Button sushi = FindViewById<Button>(Resource.Id.sushi);
            sushi.Click += delegate
            {
                var intent = new Intent(this, typeof(SushiActivity));
                StartActivity(intent);
            };

            Button deserts = FindViewById<Button>(Resource.Id.deserts);
            deserts.Click += delegate
            {
                var intent = new Intent(this, typeof(desertsActivity));
                StartActivity(intent);
            };

            Button salads = FindViewById<Button>(Resource.Id.salads);
            salads.Click += delegate
            {
                var intent = new Intent(this, typeof(SaladsActivity));
                StartActivity(intent);
            };

            Button souces = FindViewById<Button>(Resource.Id.souces);
            souces.Click += delegate
            {
                var intent = new Intent(this, typeof(SoucesActivity));
                StartActivity(intent);
            };

            Button soupes = FindViewById<Button>(Resource.Id.soupes);
            soupes.Click += delegate
            {
                var intent = new Intent(this, typeof(SoupesActivity));
                StartActivity(intent);
            };

            Button tepan = FindViewById<Button>(Resource.Id.tepan);
            tepan.Click += delegate
            {
                var intent = new Intent(this, typeof(TepanActivity));
                StartActivity(intent);
            };

            Button zakuski = FindViewById<Button>(Resource.Id.zakuski);
            zakuski.Click += delegate
            {
                var intent = new Intent(this, typeof(ZakuskiActivity));
                StartActivity(intent);
            };

            Button napoi = FindViewById<Button>(Resource.Id.napoi);
            napoi.Click += delegate
            {
                var intent = new Intent(this, typeof(NapitkiActivity));
                StartActivity(intent);
            };

            Button goryachi = FindViewById<Button>(Resource.Id.goryachi);
            goryachi.Click += delegate
            {
                var intent = new Intent(this, typeof(GoryachieRolliActivity));
                StartActivity(intent);
            };

            Button sashimi = FindViewById<Button>(Resource.Id.sashimi);
            sashimi.Click += delegate
            {
                var intent = new Intent(this, typeof(SashimiActivity));
                StartActivity(intent);
            };

            Button lanchi = FindViewById<Button>(Resource.Id.lanchi);
            lanchi.Click += delegate
            {
                var intent = new Intent(this, typeof(LanchiActivity));
                StartActivity(intent);
            };

            Button california = FindViewById<Button>(Resource.Id.california);
            california.Click += delegate
            {
                var intent = new Intent(this, typeof(CaliforniaActivity));
                StartActivity(intent);
            };

            Button drakoni = FindViewById<Button>(Resource.Id.drakoni);
            drakoni.Click += delegate
            {
                var intent = new Intent(this, typeof(drakoniActivity));
                StartActivity(intent);
            };

            Button filadelfia = FindViewById<Button>(Resource.Id.filadelfia);
            filadelfia.Click += delegate
            {
                var intent = new Intent(this, typeof(FiladelfiaActivity));
                StartActivity(intent);
            };

            Button goryachierolli = FindViewById<Button>(Resource.Id.goryachierolli);
            goryachierolli.Click += delegate
            {
                var intent = new Intent(this, typeof(GoryachieRolliActivity));
                StartActivity(intent);
            };


            Button maki = FindViewById<Button>(Resource.Id.maki);
            maki.Click += delegate
            {
                var intent = new Intent(this, typeof(MakiActivity));
                StartActivity(intent);
            };

            Button osnovni = FindViewById<Button>(Resource.Id.osnovni);
            osnovni.Click += delegate
            {
                var intent = new Intent(this, typeof(OsnovniBludaActivity));
                StartActivity(intent);
            };
            
        }
    }
}