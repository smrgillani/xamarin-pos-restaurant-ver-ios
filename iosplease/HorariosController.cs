using Foundation;
using System;
using UIKit;

namespace iosplease
{
    public partial class HorariosController : UIViewController
    {
        HoraTableSource objHoraTableSource;

        public HorariosController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            objHoraTableSource = new HoraTableSource();
            objHoraTableSource.MenuSelected += ObjHoraTableSource_MenuSelected;
            HoraTableListVIew.Source = objHoraTableSource;
            HoraTableListVIew.ContentInset = new UIEdgeInsets(0, 0, 50, 0);

            _back_button_.TouchUpInside += delegate (object sender, EventArgs e)
            {
                MiRestaurantController controller = this.Storyboard.InstantiateViewController("MiRestaurantCntrlr") as MiRestaurantController;
                this.NavigationController.PushViewController(controller, true);
            };
            View.Layer.BackgroundColor = UIColor.FromRGB(188, 188, 188).CGColor;

            _back_button_.TouchUpInside += delegate (object sender, EventArgs e)
            {
                MiRestaurantController controller = this.Storyboard.InstantiateViewController("MiRestaurantCntrlr") as MiRestaurantController;
                this.NavigationController.PushViewController(controller, true);
            };
        }

        private void ObjHoraTableSource_MenuSelected(string obj)
        {

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}