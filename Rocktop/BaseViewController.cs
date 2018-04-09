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
            var next = new MainView();
            View.BackgroundColor = UIColor.LightGray;
            Title = "Rocktop";
            var usernameField = new UITextField
            {
                Placeholder = "Username",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CoreGraphics.CGRect(30, View.Bounds.Height/3, View.Bounds.Width - 60, 30)
            };
            var passwordField = new UITextField
            {
                Placeholder = "Password",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CoreGraphics.CGRect(30, View.Bounds.Height/3 + 40, View.Bounds.Width - 60, 30),
                SecureTextEntry = true
            };
            var loginButton = UIButton.FromType(UIButtonType.RoundedRect);
            loginButton.Frame = new CoreGraphics.CGRect(30, View.Bounds.Height/3 + 80, (View.Bounds.Width - 60), 40);
            loginButton.SetTitle("Submit", UIControlState.Normal);
            loginButton.Font = UIFont.PreferredSubheadline;
            loginButton.BackgroundColor = UIColor.White;
            loginButton.TouchUpInside += delegate
            {
                NavigationController.PushViewController(next, true);
            };
            View.AddSubview(usernameField);
            View.AddSubview(passwordField);
            View.AddSubview(loginButton);
        }
    }
}