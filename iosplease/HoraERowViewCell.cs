using System;

using Foundation;
using UIKit;

namespace iosplease
{
    public partial class HoraERowViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HoraERowViewCell");
        public static readonly UINib Nib;

        static HoraERowViewCell()
        {
            Nib = UINib.FromName("HoraERowViewCell", NSBundle.MainBundle);
        }

        protected HoraERowViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static HoraERowViewCell Create()
        {
            return (HoraERowViewCell)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string dayname , string daytime)
        {

            HoraERowDayName.Text = dayname;
            HoraERowDayTime.Text = daytime;
        }
    }
}
