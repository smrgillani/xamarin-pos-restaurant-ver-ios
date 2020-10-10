using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace iosplease
{
    public partial class HoraRow : UITableViewCell
    {

        public static readonly NSString Key = new NSString("HoraRow");
        public static readonly UINib Nib;

        static HoraRow()
        {
            Nib = UINib.FromName("HoraRow", NSBundle.MainBundle);
        }

        protected HoraRow(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static HoraRow Create()
        {
            return (HoraRow)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string dayname, string daytimes , string daytimee)
        {

            _HoraRowDayName_.Text = dayname;
            _HoraRowDayTimeS_.Text = daytimes;
            _HoraRowDayTimeE_.Text = daytimee;
            HoraOuterBody.Frame = new RectangleF((float)HoraOuterBody.Frame.X, (float)HoraOuterBody.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width - 17, (float)HoraOuterBody.Frame.Height);
            _HoraRowDayName_.Frame = new RectangleF((float)_HoraRowDayName_.Frame.X, (float)_HoraRowDayName_.Frame.Y,(float)HoraOuterBody.Frame.Width , (float)_HoraRowDayName_.Frame.Height);
            MySwitch.Frame = new RectangleF( ((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)MySwitch.Frame.X + 50 : (float)MySwitch.Frame.X - 25), (float)MySwitch.Frame.Y, (float)MySwitch.Frame.Width, (float)MySwitch.Frame.Height);
            _HoraRowDayTimeE_.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)_HoraRowDayTimeE_.Frame.X : (float)_HoraRowDayTimeE_.Frame.X - 10) , (float)_HoraRowDayTimeE_.Frame.Y , (float)_HoraRowDayTimeE_.Frame.Width , (float)_HoraRowDayTimeE_.Frame.Height);

        }
    }
}
