using Android.App;
using Android.Content.PM;
using Android.Gms.Common;
using Android.OS;
using Android.Widget;
using Android.Content;
using Com.Huawei.Hms.Api;

namespace MyXamarinExample.Droid
{
    [Activity(Label = "MyXamarinExample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        bool isGooglePlayServicesAvailable;
        bool isHuaweiMobileServicesAvailable;

        Button googleButton;
        Button huaweiButton;
        TextView googleText;
        TextView huaweiText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainActivity);
            isGooglePlayServicesAvailable = ValidateGooglePlayServices();
            isHuaweiMobileServicesAvailable = ValidateHuaweiMobileServices();

            googleButton = FindViewById<Button>(Resource.Id.googleButton);
            huaweiButton = FindViewById<Button>(Resource.Id.huaweiButton);
            googleText = FindViewById<TextView>(Resource.Id.googleText);
            huaweiText = FindViewById<TextView>(Resource.Id.huaweiText);

            googleButton.Click += (sender, e) => {
                var i = new Intent(BaseContext, typeof(GoogleMapActivity));
                StartActivity(i);
            };

            huaweiButton.Click += (sender, e) => {
                var i = new Intent(BaseContext, typeof(HuaweiMapActivity));
                StartActivity(i);
            };

            if (isGooglePlayServicesAvailable)
            {
                googleText.Text = "GooglePlayServices AVAILABLE";
            }
            else
            {
                googleText.Text = "GooglePlayServices MISSING";
            }

            if (isHuaweiMobileServicesAvailable)
            {
                huaweiText.Text = "HMS AVAILABLE";
            }
            else
            {
                huaweiText.Text = "HMS MISSING";
            }
        }

        bool ValidateGooglePlayServices()
        {
            var queryResult = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            return queryResult == Android.Gms.Common.ConnectionResult.Success;
        }

        bool ValidateHuaweiMobileServices()
        {
            var queryResult = HuaweiApiAvailability.Instance.IsHuaweiMobileServicesAvailable(this);
            return queryResult == Com.Huawei.Hms.Api.ConnectionResult.Success;
        }
    }
}