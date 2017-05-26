// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;

namespace SimpleTest.iOS.Views
{
    [Register("FirstView")]
    partial class FirstView
    {

        UIKit.UILabel FirstNameLabel;

        [Outlet]
        UIKit.UITextField FirstNameTextField { get; set; }
               
        UIKit.UILabel LastNameLabel;

        [Outlet]
        UIKit.UITextField LastNameTextField { get; set; }

        [Outlet]
        UIKit.UILabel FullNameLabe { get; set; }


        void ReleaseDesignerOutlets()
        {
            if (FirstNameLabel != null)
            {
                FirstNameLabel.Dispose();
                FirstNameLabel = null;
            }

            if (FirstNameTextField != null)
            {
                FirstNameTextField.Dispose();
                FirstNameTextField = null;
            }

            if (LastNameLabel != null)
            {
                LastNameLabel.Dispose();
                LastNameLabel = null;
            }

            if (LastNameTextField != null)
            {
                LastNameTextField.Dispose();
                LastNameTextField = null;
            }

            if (FullNameLabe != null)
            {
                FullNameLabe.Dispose();
                FullNameLabe = null;
            }
        }
    }
}