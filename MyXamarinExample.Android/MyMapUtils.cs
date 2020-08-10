using System;
using System.Collections.Generic;
using System.Linq;

using Android;
using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.Gms.Maps;
using Android.Graphics;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;

namespace MyXamarinExample.Droid
{
    public static class MyMapUtils
    {
        public static Bitmap getMarkerIcon(Resources resources)
        {
            var bitmap = BitmapFactory.DecodeResource(resources, Resource.Drawable.markerblack);
            return Bitmap.CreateScaledBitmap(bitmap, 60, 100, false);
        }
    }
}
