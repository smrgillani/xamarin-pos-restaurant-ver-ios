using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class ReservationDtlsController : UIViewController
    {
        public ReservationDtlsController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ReservDtlsView.Frame = new RectangleF((float)ReservDtlsView.Frame.X, (float)ReservDtlsView.Frame.Y, ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)UIScreen.MainScreen.Bounds.Width - 14 - (float)ReservDtlsView.Frame.X : (float)ReservDtlsView.Frame.Width), (float)ReservDtlsView.Frame.Height);
            _Dtls_Cus_Name_.Frame = new RectangleF((float)_Dtls_Cus_Name_.Frame.X , (float)_Dtls_Cus_Name_.Frame.Y , (float)ReservDtlsView.Frame.Width , (float)_Dtls_Cus_Name_.Frame.Height);
            ResrvDtlsConBtn.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)ResrvDtlsConBtn.Frame.X - 100 : (float)ResrvDtlsConBtn.Frame.X), (float)ResrvDtlsConBtn.Frame.Y, (float)ResrvDtlsConBtn.Frame.Width, (float)ResrvDtlsConBtn.Frame.Height);
            ReservDtlsNote.Frame = new RectangleF((float)ReservDtlsNote.Frame.X, (float)ReservDtlsNote.Frame.Y, ((float)UIScreen.MainScreen.Bounds.Width <= 320 ? (float)ReservDtlsNote.Frame.Width - 17 : (float)ReservDtlsNote.Frame.Width), (float)ReservDtlsNote.Frame.Height);


            __btnIcon__.TouchUpInside += delegate (object sender, EventArgs e)
            {
                DashboardController controller = this.Storyboard.InstantiateViewController("DashboardCntrlr") as DashboardController;
                this.NavigationController.PushViewController(controller, true);
            };
        }
    }
}