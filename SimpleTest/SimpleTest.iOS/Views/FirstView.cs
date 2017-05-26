using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using SimpleTest.Core.ViewModels;
using System;

using UIKit;

namespace SimpleTest.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

      
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<FirstView, MainViewModel>();
            set.Bind(FirstNameTextField).To(vm => vm.FirstName);
            set.Bind(LastNameTextField).To(vm => vm.LastName);
            set.Bind(FullNameLabel).To(vm => vm.FullName);
            set.Apply();
        }
    }
}