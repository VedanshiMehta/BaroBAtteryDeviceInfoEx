using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace BaroBAtteryDeviceInfoEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class DeviceInfoEx :Activity
    {
        private Button mButton;
        private TextView mtext1;
        private TextView mtext2;
        private TextView mtext3;
        private TextView mtext4;
        private TextView mtext5;
        private TextView mtext6;
        private TextView mtext7;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.deviceDemo);
            UIReference();
            UIClickEvent();

        }
        private void UIClickEvent()
        {
            mButton.Click += MButton_Click;

        }
        private async void MButton_Click(object sender, EventArgs e)
        {
            mtext1.Text = DeviceInfo.Model;
            mtext2.Text = DeviceInfo.Manufacturer;
            mtext3.Text = DeviceInfo.Name;
            mtext4.Text = DeviceInfo.VersionString;

            


            mtext5.Text = DeviceInfo.Platform.ToString();
            
            mtext6.Text = DeviceInfo.Idiom.ToString();
            mtext7.Text = DeviceInfo.DeviceType.ToString();



        }

        private void UIReference()
        {
            mButton = FindViewById<Button>(Resource.Id.buttonCI);
            mtext1 = FindViewById<TextView>(Resource.Id.textViewC1);
            mtext2 = FindViewById<TextView>(Resource.Id.textViewC2);
            mtext3 = FindViewById<TextView>(Resource.Id.textViewC3);
            mtext4 = FindViewById<TextView>(Resource.Id.textViewC4);
            mtext5 = FindViewById<TextView>(Resource.Id.textViewC5);
            mtext6 = FindViewById<TextView>(Resource.Id.textViewC6);
            mtext7 = FindViewById<TextView>(Resource.Id.textViewC7);
        }
    }
}