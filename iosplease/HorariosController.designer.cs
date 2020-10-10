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

namespace iosplease
{
    [Register ("HorariosController")]
    partial class HorariosController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _back_button_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView HoraTableListVIew { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_back_button_ != null) {
                _back_button_.Dispose ();
                _back_button_ = null;
            }

            if (HoraTableListVIew != null) {
                HoraTableListVIew.Dispose ();
                HoraTableListVIew = null;
            }
        }
    }
}