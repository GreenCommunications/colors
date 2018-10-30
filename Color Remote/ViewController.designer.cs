// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Color_Remote
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider bS { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider gS { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider rS { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bS != null) {
                bS.Dispose ();
                bS = null;
            }

            if (contentView != null) {
                contentView.Dispose ();
                contentView = null;
            }

            if (gS != null) {
                gS.Dispose ();
                gS = null;
            }

            if (headingLabel != null) {
                headingLabel.Dispose ();
                headingLabel = null;
            }

            if (rS != null) {
                rS.Dispose ();
                rS = null;
            }
        }
    }
}