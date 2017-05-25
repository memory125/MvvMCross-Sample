using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using SimpleTest.Core.ViewModels;
using System;

namespace SimpleTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            //RegisterServices();
            //InitializeServices();

            try
            {
                RegisterAppStart<MainViewModel>();
            }
            catch (Exception e)
            {
                throw ;
            }

        }

        //private void RegisterServices()
        //{
        //    Mvx.LazyConstructAndRegisterSingleton<IDeviceService, DeviceService>();
        //    Mvx.LazyConstructAndRegisterSingleton<ICountdownService, CountdownService>();
        //}

        //private void InitializeServices()
        //{
        //    var countDownService = Mvx.Resolve<ICountdownService>();
        //    countDownService.Initialize();
        //}
    }
}
