using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace App3
{
    [Activity(Label = "App3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
        }
    }
}

