using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Rocktop
{
    class BaseViewController : UIViewController
    {
        public BaseViewController()
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.LightGray;
            Title = "Rocktop";
            var usernameField = new UITextField
            {
                Placeholder = "Enter username",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CoreGraphics.CGRect(30, 82, 20, 10)
            };
            View.AddSubview(usernameField);
        }
    }
}