using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace BaroBAtteryDeviceInfoEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button myBarometer;
        Button myBattery;
        Button myDeviceInfo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            myBarometer = FindViewById<Button>(Resource.Id.button1);
            myBattery = FindViewById<Button>(Resource.Id.button2);
            myDeviceInfo = FindViewById<Button>(Resource.Id.button3);


            myBarometer.Click += MyBarometer_Click;
            myBattery.Click += MyBattery_Click;
            myDeviceInfo.Click += MyDeviceInfo_Click;
        }

        private void MyDeviceInfo_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(DeviceInfoEx));
            StartActivity(k);
        }

        private void MyBattery_Click(object sender, System.EventArgs e)
        {

            Intent j = new Intent(Application.Context, typeof(BatteryDemo));
            StartActivity(j);
        }

        private void MyBarometer_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(BaroDemo));
            StartActivity(i);
        }

        private void MyPropertyDemo_Click(object sender, System.EventArgs e)
        {

        }





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}