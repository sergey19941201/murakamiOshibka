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
    [Activity(Label = "detalniyProsmotrActivity")]
    public class detalniyProsmotrActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.detalniyProsmotr);
            
            int count = 1;
        
            TextView quantity = FindViewById<TextView>(Resource.Id.quantity);
            TextView price = FindViewById<TextView>(Resource.Id.price);

            float price2 = float.Parse(price.Text, CultureInfo.InvariantCulture);

            ImageButton plus = FindViewById<ImageButton>(Resource.Id.plus);
            plus.Click += delegate
            {
                quantity.Text = string.Format("{0}", ++count);
                price.Text = string.Format("{0}", count * price2 + "грн");
            };

            ImageButton minus = FindViewById<ImageButton>(Resource.Id.minus);
            minus.Click += delegate
            {
                quantity.Text = string.Format("{0}", count > 1 ? --count : 1);
                price.Text = string.Format("{0}", count * price2 + "грн");
            };
        }
    }
}