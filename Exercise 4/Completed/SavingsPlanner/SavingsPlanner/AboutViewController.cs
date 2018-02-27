using Foundation;
using System;
using UIKit;

namespace SavingsPlanner
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController(IntPtr handle) : base(handle)
        {
        }

        partial void CloseButton_TouchUpInside(UIButton sender)
        {
            DismissViewController(true, null);
        }
    }
}