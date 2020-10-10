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
    [Register ("ReservationDtlsController")]
    partial class ReservationDtlsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton __btnIcon__ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _Dtls_Cus_Name_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ReservDtlsNote { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ReservDtlsView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ResrvDtlsConBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (__btnIcon__ != null) {
                __btnIcon__.Dispose ();
                __btnIcon__ = null;
            }

            if (_Dtls_Cus_Name_ != null) {
                _Dtls_Cus_Name_.Dispose ();
                _Dtls_Cus_Name_ = null;
            }

            if (ReservDtlsNote != null) {
                ReservDtlsNote.Dispose ();
                ReservDtlsNote = null;
            }

            if (ReservDtlsView != null) {
                ReservDtlsView.Dispose ();
                ReservDtlsView = null;
            }

            if (ResrvDtlsConBtn != null) {
                ResrvDtlsConBtn.Dispose ();
                ResrvDtlsConBtn = null;
            }
        }
    }
}