using System;

using Foundation;
using UIKit;

namespace iosplease
{
    public partial class MesaERowViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MesaERowViewCell");
        public static readonly UINib Nib;

        static MesaERowViewCell()
        {
            Nib = UINib.FromName("MesaERowViewCell", NSBundle.MainBundle);
        }

        protected MesaERowViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static MesaERowViewCell Create()
        {
            return (MesaERowViewCell)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string tabledesc, string numofper , string numoftables)
        {

            _MesaTableDesc_.Text = tabledesc;
            _MesaPersonsDesc_.Text = numofper;
            _MesaNumberOftables_.Text = numoftables;
        }
    }
}
