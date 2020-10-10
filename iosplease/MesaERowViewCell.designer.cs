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
    [Register ("MesaERowViewCell")]
    partial class MesaERowViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _MesaNumberOftables_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _MesaPersonsDesc_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _MesaTableDesc_ { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_MesaNumberOftables_ != null) {
                _MesaNumberOftables_.Dispose ();
                _MesaNumberOftables_ = null;
            }

            if (_MesaPersonsDesc_ != null) {
                _MesaPersonsDesc_.Dispose ();
                _MesaPersonsDesc_ = null;
            }

            if (_MesaTableDesc_ != null) {
                _MesaTableDesc_.Dispose ();
                _MesaTableDesc_ = null;
            }
        }
    }
}