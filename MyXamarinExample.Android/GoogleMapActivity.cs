using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Gms.Maps.Model;

namespace MyXamarinExample.Droid
{
    [Activity(Label = "GoogleMapActivity")]
    public class GoogleMapActivity : Activity, IOnMapReadyCallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GoogleMapActivityLayout);

            var mapFragment = (MapFragment) FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap theMap)
        {
            theMap.UiSettings.CompassEnabled = true;
            theMap.UiSettings.ZoomControlsEnabled = true;
            //theMap.MyLocationEnabled = true;

            var bitmap = MyMapUtils.getMarkerIcon(Resources);
            var icon = BitmapDescriptorFactory.FromBitmap(bitmap);

            var position1 = new LatLng(-12.006049, -77.060307);
            MarkerOptions markerOptions = new MarkerOptions()
                .SetPosition(position1)
                .SetTitle("Marker Title")
                .SetSnippet("Marker Description")
                .SetIcon(icon);
            theMap.AddMarker(markerOptions);
        }
    }
}
