using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SimpleTest.Core;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace SimpleTest.Droid
{
    class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        //protected override void InitializePlatformServices()
        //{
        //    base.InitializePlatformServices();

        //    Mvx.LazyConstructAndRegisterSingleton<IDeviceLocalDataService, DeviceLocalDataService>();
        //}
    }
}