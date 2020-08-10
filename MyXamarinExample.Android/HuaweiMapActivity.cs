using Android.App;
using Android.OS;
using Com.Huawei.Hms.Maps;
using Com.Huawei.Hms.Maps.Model;

namespace MyXamarinExample.Droid
{
    [Activity(Label = "HuaweiMapActivity")]
    public class HuaweiMapActivity : Activity, IOnMapReadyCallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HuaweiMapActivityLayout);

            var mapFragment = (MapFragment) FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }

        public void OnMapReady(HuaweiMap theMap)
        {
            theMap.UiSettings.CompassEnabled = true;
            theMap.UiSettings.ZoomControlsEnabled = true;
            theMap.MyLocationEnabled = true;

            var bitmap = MyMapUtils.getMarkerIcon(Resources);
            var icon = BitmapDescriptorFactory.FromBitmap(bitmap);
            /* Esta linea funciona con androidx */
            //var icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.markerblue);

            var position1 = new LatLng(-12.006049, -77.060307);
            MarkerOptions markerOptions = new MarkerOptions()
                .InvokePosition(position1)
                .InvokeTitle("Marker Title")
                .InvokeSnippet("Marker Description")
                .InvokeIcon(icon);
            theMap.AddMarker(markerOptions);

            var position2 = new LatLng(-11.994160, -77.061681);
            MarkerOptions markerOptions2 = new MarkerOptions()
                .InvokePosition(position2)
                .InvokeTitle("Marker Title")
                .InvokeSnippet("Marker Description")
                .InvokeIcon(icon);
            theMap.AddMarker(markerOptions2);
        }
    }
}
