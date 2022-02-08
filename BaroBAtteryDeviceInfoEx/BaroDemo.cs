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
    class BaroDemo : Activity
    {

        private Button start;
        private Button stop;
        private TextView textV;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.baroDemo);
            UIReference();
            UIClickEvent();
        }

        private void UIClickEvent()
        {
            start.Click += Start_Click;
            stop.Click += Stop_Click;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (Barometer.IsMonitoring)
            {
                Barometer.ReadingChanged -= Barometer_ReadingChanged;
                Barometer.Stop();
            }
        }



        private void Start_Click(object sender, EventArgs e)
        {
            if (!Barometer.IsMonitoring)
            {
                Barometer.ReadingChanged += Barometer_ReadingChanged;
                Barometer.Start(SensorSpeed.UI);

            }
        }

        private void Barometer_ReadingChanged(object sender, BarometerChangedEventArgs e)
        {
            textV.Text = $"Pressure: {e.Reading.PressureInHectopascals} hectopascals";
        }


        private void UIReference()
        {
            start = FindViewById<Button>(Resource.Id.buttonStartBD);
            stop = FindViewById<Button>(Resource.Id.buttonStopBD);
            textV = FindViewById<TextView>(Resource.Id.textViewBD);

        }
    }
}
   
