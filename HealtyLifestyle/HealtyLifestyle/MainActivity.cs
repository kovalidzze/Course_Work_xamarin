﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace HealtyLifestyle
{
    [Activity(Label = "@string/app_name", Icon = "@drawable/icon", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button calculateBtn = FindViewById<Button>(Resource.Id.calculateKBJYBtn);
            var recBtn = FindViewById<Button>(Resource.Id.receptsList);

            

            calculateBtn.Click += delegate {
                Intent calculateKBJUIntent = new Intent(this, typeof(CalculateKBJUActivity));
                StartActivity(calculateKBJUIntent);
            };

            recBtn.Click += delegate {
                Intent intent = new Intent(this, typeof(FuckUp));
                StartActivity(intent);

            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}