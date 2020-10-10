using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace iosplease
{
    public partial class ResrRow : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ResrRow");
        public static readonly UINib Nib;

        static ResrRow()
        {
            Nib = UINib.FromName("ResrRow", NSBundle.MainBundle);
        }

        protected ResrRow(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static ResrRow Create()
        {
            return (ResrRow)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string rowcusname , string date_time , string persons , string area , string notes , string code)
        {
            
            _Row_Customer_Name_.Text = rowcusname;
            _Row_DateAndTime_.Text = date_time;
            _Row_DateAndTime_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(12) : UIFont.SystemFontOfSize(14));
            _Persons_Title_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(12) : UIFont.SystemFontOfSize(14));
            _Persons_Title_.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_Persons_Title_.Frame.X - 30 : (float)_Persons_Title_.Frame.X), (float)_Persons_Title_.Frame.Y, (float)_Persons_Title_.Frame.Width, (float)_Persons_Title_.Frame.Height);

            _Row_Persons_.Text = persons;
            _Row_Persons_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(12) : UIFont.SystemFontOfSize(14));
            _Row_Persons_.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_Row_Persons_.Frame.X - 35 : (float)_Row_Persons_.Frame.X), (float)_Row_Persons_.Frame.Y, (float)_Row_Persons_.Frame.Width, (float)_Row_Persons_.Frame.Height);

            _Areas_Title_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(12) : UIFont.SystemFontOfSize(14));
            _Areas_Title_.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_Areas_Title_.Frame.X - 35 : (float)_Areas_Title_.Frame.X), (float)_Areas_Title_.Frame.Y, (float)_Areas_Title_.Frame.Width, (float)_Areas_Title_.Frame.Height);
            _Row_Area_.Text = area;
            _Row_Area_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(12) : UIFont.SystemFontOfSize(14));
            _Row_Area_.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_Row_Area_.Frame.X - 35 : (float)_Row_Area_.Frame.X), (float)_Row_Area_.Frame.Y, (float)_Row_Area_.Frame.Width, (float)_Row_Area_.Frame.Height);

            _Row_Notes_.Text = notes;
            _Row_Notes_.Font = ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? UIFont.SystemFontOfSize(10) : UIFont.SystemFontOfSize(13));
            _Row_Notes_.Frame = new RectangleF((float)_Row_Notes_.Frame.X, (float)_Row_Notes_.Frame.Y, ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_Row_Notes_.Frame.Width - 35 : (float)_Row_Notes_.Frame.Width), (float)_Row_Notes_.Frame.Height);

            _Row_Con_Code_.Text = code;
            ResrvRowMainView.Frame = new RectangleF((float)ResrvRowMainView.Frame.X, (float)ResrvRowMainView.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width-20, (float)ResrvRowMainView.Frame.Height);
            _Row_Customer_Name_.Frame = new RectangleF((float)_Row_Customer_Name_.Frame.X, (float)_Row_Customer_Name_.Frame.Y, (float)ResrvRowMainView.Frame.Width, (float)_Row_Customer_Name_.Frame.Height);
            _ClickButtonView_.Frame = new RectangleF( ((float)UIScreen.MainScreen.Bounds.Width >= 375 ? (float)_ClickButtonView_.Frame.X + 50 : ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)_ClickButtonView_.Frame.X - 40  : (float)_ClickButtonView_.Frame.X) ), (float)_ClickButtonView_.Frame.Y, (float)_ClickButtonView_.Frame.Width, (float)_ClickButtonView_.Frame.Height);

        }
    }
}
