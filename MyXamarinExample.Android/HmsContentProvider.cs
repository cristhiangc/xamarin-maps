﻿using System;
using Android.Content;
using Android.Database;
using Com.Huawei.Agconnect.Config;

namespace MyXamarinExample.Droid
{
    [ContentProvider(new string[] { MyXamarinExample.Droid.HmsContentProvider.AUTHORITY })]
    public class HmsContentProvider : ContentProvider
    {

        public const string AUTHORITY = "pe.cgonzales.hmsdemoapp.HmsContentProvider";

        public override bool OnCreate()
        {
            AGConnectServicesConfig config = AGConnectServicesConfig.FromContext(Context);
            config.OverlayWith(new HmsLazyInputStream(Context));

            return false;
        }

        public override int Delete(Android.Net.Uri uri, string selection, string[] selectionArgs)
        {
            throw new NotImplementedException();
        }

        public override string GetType(Android.Net.Uri uri)
        {
            throw new NotImplementedException();
        }

        public override Android.Net.Uri Insert(Android.Net.Uri uri, ContentValues values)
        {
            throw new NotImplementedException();
        }

        public override ICursor Query(Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
        {
            throw new NotImplementedException();
        }

        public override int Update(Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs)
        {
            throw new NotImplementedException();
        }
    }
}
