using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using ZXing.Mobile;

namespace Location.APP.Droid
{
    [Activity(Label = "Localizar Familia", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                TabLayoutResource = Resource.Layout.tabs;
                ToolbarResource = Resource.Layout.toolbar;

                base.OnCreate(bundle);
                MobileBarcodeScanner.Initialize(Application);
                ZXing.Net.Mobile.Forms.Android.Platform.Init();
                Xamarin.FormsGoogleMaps.Init(this, bundle);
                global::Xamarin.Forms.Forms.Init(this, bundle);

                LoadApplication(new App());
            }
            catch (Exception ex)
            {
                //throw ex;
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            global::ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

}

