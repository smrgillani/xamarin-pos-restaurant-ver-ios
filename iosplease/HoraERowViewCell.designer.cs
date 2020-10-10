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
    [Register ("HoraERowViewCell")]
    partial class HoraERowViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HoraERowDayName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HoraERowDayTime { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (HoraERowDayName != null) {
                HoraERowDayName.Dispose ();
                HoraERowDayName = null;
            }

            if (HoraERowDayTime != null) {
                HoraERowDayTime.Dispose ();
                HoraERowDayTime = null;
            }
        }
    }
}