using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using garbage;
using Foundation;
using UIKit;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Reflection;

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
                if(connect("login," + usernameField.Text + "," + passwordField.Text))
                    NavigationController.PushViewController(next, true);
            };
            var createButton = UIButton.FromType(UIButtonType.RoundedRect);
            createButton.Frame = new CoreGraphics.CGRect(30, View.Bounds.Height / 3 + 130, (View.Bounds.Width - 60), 40);
            createButton.SetTitle("Submit", UIControlState.Normal);
            createButton.Font = UIFont.PreferredSubheadline;
            createButton.BackgroundColor = UIColor.White;
            createButton.TouchUpInside += delegate
            {
                if (connect("create," + usernameField.Text + "," + passwordField.Text))
                    NavigationController.PushViewController(next, true);
            };
           
            View.AddSubview(usernameField);
            View.AddSubview(passwordField);
            View.AddSubview(loginButton);
<<<<<<< HEAD
            View.AddSubview(createButton);
        }
        public bool connect(string input)
        {
            java.lang.Class clie = typeof(Garbo);
            java.lang.Thread.currentThread().setContextClassLoader(clie.getClassLoader());
            Garbo g = new Garbo();
            int output = g.connect(input);
            if (output == 1 || output == 2)
                return true;
            return false;
=======
    
           

>>>>>>> 291c4ac... * AppDelegate.cs: edits
        }
    }
}