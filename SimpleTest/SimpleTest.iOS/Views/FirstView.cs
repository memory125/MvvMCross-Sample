using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using SimpleTest.Core.ViewModels;
using System;

using UIKit;

namespace SimpleTest.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

      
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<FirstView, MainViewModel>();
            set.Bind(FirstNameTextField).To(vm => vm.FirstName);
            set.Bind(LastNameTextField).To(vm => vm.LastName);
            set.Bind(FullNameLabe).To(vm => vm.FullName);
            set.Apply();
        }
    }
}