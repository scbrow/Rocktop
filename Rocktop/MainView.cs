using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Rocktop
{
    class MainView : UIViewController
    {
        public MainView()
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;
            var title = new UILabel();
            title.Text = "Rocktop";
            title.Font = UIFont.FromName("Helvetica-Bold", 60f);
            title.Frame = new CoreGraphics.CGRect(30, 70, 200, 50);
            title.TextAlignment = UITextAlignment.Center;
            var counter = new UILabel();
            counter.Text = "$3,405,691";
            counter.Font = UIFont.FromName("Helvetica", 70f);
            counter.Frame = new CoreGraphics.CGRect(30, 130, 200, 80);
            counter.TextAlignment = UITextAlignment.Center;
            View.AddSubview(title);
            View.AddSubview(counter);
        }
    }
}