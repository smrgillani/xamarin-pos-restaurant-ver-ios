// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace iosplease
{
    [Register ("HoraRow")]
    partial class HoraRow
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _HoraRowDayName_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _HoraRowDayTimeE_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _HoraRowDayTimeS_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView HoraOuterBody { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch MySwitch { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_HoraRowDayName_ != null) {
                _HoraRowDayName_.Dispose ();
                _HoraRowDayName_ = null;
            }

            if (_HoraRowDayTimeE_ != null) {
                _HoraRowDayTimeE_.Dispose ();
                _HoraRowDayTimeE_ = null;
            }

            if (_HoraRowDayTimeS_ != null) {
                _HoraRowDayTimeS_.Dispose ();
                _HoraRowDayTimeS_ = null;
            }

            if (HoraOuterBody != null) {
                HoraOuterBody.Dispose ();
                HoraOuterBody = null;
            }

            if (MySwitch != null) {
                MySwitch.Dispose ();
                MySwitch = null;
            }
        }
    }
}