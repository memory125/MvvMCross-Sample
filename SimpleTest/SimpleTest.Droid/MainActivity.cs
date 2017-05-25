using System;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SimpleTest.Droid
{
    [Activity(Label = "SimpleTest.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);    
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);
        }
    }
}

