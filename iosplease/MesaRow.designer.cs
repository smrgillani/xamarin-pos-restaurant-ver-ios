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
    [Register ("MesaRow")]
    partial class MesaRow
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView MesaRowOuterBody { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MesasRow_AvgTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MesasRow_TableAvllbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MesasRow_TableName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MesasRow_TableSeats { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MesasRow_TableType { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch MySwitchBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MesaRowOuterBody != null) {
                MesaRowOuterBody.Dispose ();
                MesaRowOuterBody = null;
            }

            if (MesasRow_AvgTime != null) {
                MesasRow_AvgTime.Dispose ();
                MesasRow_AvgTime = null;
            }

            if (MesasRow_TableAvllbl != null) {
                MesasRow_TableAvllbl.Dispose ();
                MesasRow_TableAvllbl = null;
            }

            if (MesasRow_TableName != null) {
                MesasRow_TableName.Dispose ();
                MesasRow_TableName = null;
            }

            if (MesasRow_TableSeats != null) {
                MesasRow_TableSeats.Dispose ();
                MesasRow_TableSeats = null;
            }

            if (MesasRow_TableType != null) {
                MesasRow_TableType.Dispose ();
                MesasRow_TableType = null;
            }

            if (MySwitchBtn != null) {
                MySwitchBtn.Dispose ();
                MySwitchBtn = null;
            }
        }
    }
}