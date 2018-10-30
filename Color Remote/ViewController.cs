using Foundation;
using System;
using UIKit;
using CoreGraphics;
using CoreAnimation;

namespace Color_Remote
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            View.BackgroundColor = UIColor.FromRGB(164, 164, 164);

            contentView.Frame = new CGRect(0, View.SafeAreaInsets.Top + 70, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - 50);
            var maskingShapeLayer = new CAShapeLayer()
            {
                Path = UIBezierPath.FromRoundedRect(contentView.Bounds, UIRectCorner.TopRight | UIRectCorner.TopLeft, new CGSize(25, 25)).CGPath
            };
            contentView.Layer.Mask = maskingShapeLayer;

            headingLabel.Text = "Colors";
            headingLabel.Font = UIFont.FromName("Roboto", 24);
            headingLabel.SizeToFit();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}