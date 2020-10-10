using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace iosplease
{
    public partial class MesasController : UIViewController
    {
        MesasTableSource objMesasTableSource;

        public MesasController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            objMesasTableSource = new MesasTableSource();
            objMesasTableSource.MenuSelected += ObjHoraTableSource_MenuSelected;
            MesaTableListVIew.Source = objMesasTableSource;
            MesaTableListVIew.ContentInset = new UIEdgeInsets(0, 0, 50, 0);

            _back_button_.TouchUpInside += delegate (object sender, EventArgs e)
            {
                MiRestaurantController controller = this.Storyboard.InstantiateViewController("MiRestaurantCntrlr") as MiRestaurantController;
                this.NavigationController.PushViewController(controller, true);
            };
            View.Layer.BackgroundColor = UIColor.FromRGB(188,188,188).CGColor;
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