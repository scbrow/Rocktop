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
            title.Font = UIFont.PreferredHeadline;
            title.Frame = new CoreGraphics.CGRect(30, 50, View.Bounds.Width - 60, 50);
            var counter = new UILabel();
            counter.Text = "$3,405,691";
            counter.Font = UIFont.PreferredTitle2;
            counter.Frame = new CoreGraphics.CGRect(30, 130, View.Bounds.Width - 60, 40);
            View.AddSubview(title);
            View.AddSubview(counter);
        }
    }
}