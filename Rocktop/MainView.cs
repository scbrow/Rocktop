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
            View.BackgroundColor = UIColor.LightGray;
           
            var search = new UITextField
            {
                Placeholder = "Search",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CoreGraphics.CGRect(5, 70, View.Bounds.Width - 70, 30),
                //SecureTextEntry = true
            };
            var title = new UILabel
            {
                
                Text = "RockTop",
                Frame = new CoreGraphics.CGRect(5, 120, View.Bounds.Width - 40, 70),
                                        Font = UIFont.FromName("Helvetica", 30f)
            };
            var totalWinnings = new UILabel
            {
                Text = "Total Winnings:",
                Frame = new CoreGraphics.CGRect(5, 160, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f)
            };
            var money = new UILabel
            {
                Text = "$4,921,657.91",
                Frame = new CoreGraphics.CGRect(5, 190, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f), 
                TextColor = UIColor.Green
            };

            this.NavigationItem.SetRightBarButtonItem(
                new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender, args) => {
            // button was clicked
            }), true);

            var cats = new UILabel
            {
                Text = "Categories:",
                Frame = new CoreGraphics.CGRect(5, 250, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 30f)
            };
        
            var hottestComps = new UILabel
            {
                Text = "Hottest Competitions:",
                Frame = new CoreGraphics.CGRect(5, 400, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 30f)
            };

            var sports = new UILabel
            {
                Text = "Sports",
                Frame = new CoreGraphics.CGRect(5, 310, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f)
            };
           
            var music = new UILabel
            {
                Text = "Music",
                Frame = new CoreGraphics.CGRect(5, 290, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f)
            };

            var stunts = new UILabel
            {
                Text = "Stunts",
                Frame = new CoreGraphics.CGRect(5, 330, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f)
            };

            var seeMore = UIButton.FromType(UIButtonType.RoundedRect);
            seeMore.Frame = new CoreGraphics.CGRect(-120, 380, (View.Bounds.Width - 60), 40);
            seeMore.SetTitle("See more", UIControlState.Normal);
            seeMore.Font = UIFont.PreferredSubheadline;
            seeMore.BackgroundColor = UIColor.LightGray;
            seeMore.TouchUpInside += delegate
            {
          //      NavigationController.PushViewController(next, true);
            };

            var comp1 = new UILabel
            {
                Text = "Best High Dive (1,037,977 Participants)",
                Frame = new CoreGraphics.CGRect(5, 440, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f),
                TextColor = UIColor.Blue
            };

            var comp2 = new UILabel
            {
                Text = "Longest Skateboard Railgrind (841,063 Participants)",
                Frame = new CoreGraphics.CGRect(5, 460, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f), 
                TextColor = UIColor.Blue
            };

            var comp3 = new UILabel
            {
                Text = "Fastest Hot Dog Swallow (412,293 Participants)",
                Frame = new CoreGraphics.CGRect(5, 480, View.Bounds.Width, 70),
                Font = UIFont.FromName("Helvetica", 20f),
                TextColor = UIColor.Blue
            };


            var seeMoreVids = UIButton.FromType(UIButtonType.RoundedRect);
            seeMoreVids.Frame = new CoreGraphics.CGRect(-120, 540, (View.Bounds.Width - 60), 40);
            seeMoreVids.SetTitle("See more", UIControlState.Normal);
            seeMoreVids.Font = UIFont.PreferredSubheadline;
            seeMoreVids.BackgroundColor = UIColor.LightGray;
            seeMoreVids.TouchUpInside += delegate
            {
           //     NavigationController.PushViewController(next, true);
            };






            View.AddSubview(title);
            View.AddSubview(money);
            View.AddSubview(totalWinnings);
            View.AddSubview(search);
            View.AddSubview(cats);
            View.AddSubview(hottestComps);
            View.AddSubview(sports);
            View.AddSubview(music);
            View.AddSubview(stunts);
            View.AddSubview(seeMore);
            View.AddSubview(comp1);
            View.AddSubview(comp2);
            View.AddSubview(comp3);
            View.AddSubview(seeMoreVids);
        }
    }
}