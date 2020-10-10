using CoreAnimation;
using Foundation;

using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class MiRestaurantController : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        HoraETableSource objHoraETableSource;
        MesaETableSource objMesaETableSource;
        UIImageView topmenulogo = new UIImageView();
        UIView leftmenu = new UIView();
        UITableView menutable = new UITableView();
        public MiRestaurantController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MiRestImage.Frame = new RectangleF((float)MiRestImage.Frame.X, (float)MiRestImage.Frame.Y, (float)View.Bounds.Width, 188);
            MiRestImage.Image = UIImage.FromBundle("mirestimg.png");
            MiRestImage.ContentMode = UIViewContentMode.ScaleAspectFill;

            View.AddConstraints(new NSLayoutConstraint[] {
                NSLayoutConstraint.Create(MiRestImage,NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, MiRestImage, NSLayoutAttribute.CenterX, 1f, 0f),
                NSLayoutConstraint.Create(MiRestImage,NSLayoutAttribute.CenterY, NSLayoutRelation.Equal, MiRestImage, NSLayoutAttribute.CenterY, 1f, 0f),
                NSLayoutConstraint.Create(MiRestImage,NSLayoutAttribute.Width, NSLayoutRelation.Equal, MiRestImage, NSLayoutAttribute.Width, .5f, 0f),
                NSLayoutConstraint.Create(MiRestImage,NSLayoutAttribute.Height, NSLayoutRelation.Equal, MiRestImage, NSLayoutAttribute.Height, .3f, 0f)});
            MiREditarNombreTableViewCell.Frame = new RectangleF((float)MiREditarNombreTableViewCell.Frame.X , (float)MiREditarNombreTableViewCell.Frame.Y , (float)View.Bounds.Width - 32 , (float)MiREditarNombreTableViewCell.Frame.Height);
            _MiREditarDireccionTableViewCell_.Frame = new RectangleF((float)_MiREditarDireccionTableViewCell_.Frame.X,(float)_MiREditarDireccionTableViewCell_.Frame.Y , (float)UIScreen.MainScreen.Bounds.Width - 32 , (float)_MiREditarDireccionTableViewCell_.Frame.Height);
            //MiREditarDireccionTableViewCell.Frame = new RectangleF((float)MiREditarDireccionTableViewCell.Frame.X, (float)MiREditarDireccionTableViewCell.Frame.Y, (float)View.Bounds.Width - 32, (float)MiREditarDireccionTableViewCell.Frame.Height);

            objHoraETableSource = new HoraETableSource();
            objMesaETableSource = new MesaETableSource();
            var sizeofscreen = objHoraETableSource.GetTotalRows() * 40;
            var sizeofscreen_ = objMesaETableSource.GetTotalRows() * 40;

            //MiREditarDireccionTableViewCell.Frame = new RectangleF((float)MiREditarDireccionTableViewCell.Frame.X, (float)MiREditarDireccionTableViewCell.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width - 32 , (float)MiREditarDireccionTableViewCell.Frame.Height);
            MiREditarHoraTableViewCell.Frame = new RectangleF((float)MiREditarHoraTableViewCell.Frame.X, (float)MiREditarHoraTableViewCell.Frame.Y , (float)UIScreen.MainScreen.Bounds.Width - 32 , (float)MiREditarHoraTableViewCell.Frame.Height + (float)sizeofscreen);
            HoraMiRestTableViewList.Frame = new RectangleF((float)HoraMiRestTableViewList.Frame.X, (float)HoraMiRestTableViewList.Frame.Y, (float)MiREditarHoraTableViewCell.Frame.Width, (float)HoraMiRestTableViewList.Frame.Height + (float)sizeofscreen);
            HoraMiRestTableViewList.Source = objHoraETableSource;

            MiREditarDireccionTableViewCell.Frame = new RectangleF((float)MiREditarDireccionTableViewCell.Frame.X, (float)MiREditarDireccionTableViewCell.Frame.Y + (float)MiREditarHoraTableViewCell.Frame.Height - (float)54, (float)UIScreen.MainScreen.Bounds.Width - 32, (float)MiREditarDireccionTableViewCell.Frame.Height);
            MiREditarMesasTableViewCell.Frame = new RectangleF((float)MiREditarMesasTableViewCell.Frame.X , (float)MiREditarDireccionTableViewCell.Frame.Height + (float)MiREditarDireccionTableViewCell.Frame.Y + 8, (float)UIScreen.MainScreen.Bounds.Width - (float)32 , (float)MiREditarMesasTableViewCell.Frame.Height + (float)sizeofscreen_);
            MesaMiRestTableViewList.Frame = new RectangleF((float)MesaMiRestTableViewList.Frame.X, (float)MesaMiRestTableViewList.Frame.Y, (float)MiREditarMesasTableViewCell.Frame.Width, (float)MesaMiRestTableViewList.Frame.Height + (float)sizeofscreen_);
            MesaMiRestTableViewList.Source = objMesaETableSource;

            _MiRestauranteSV_.ContentInset = new UIEdgeInsets(0, 0, (float)MiREditarMesasTableViewCell.Frame.Y + (float)MiREditarMesasTableViewCell.Frame.Height + 8, 0);
            FnInitializeView();
            topmenulogo.Image = UIImage.FromBundle("logoonmenu.png");
            topmenulogo.Frame = new RectangleF(92, 30, 66, 66);
            leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
            menutable.Frame = new RectangleF(0, 110, 250, 86);
            _TopNavBar_.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            leftmenu.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            menutable.ScrollEnabled = false;
            menutable.SeparatorStyle = UITableViewCellSeparatorStyle.None;

            leftmenu.Add(topmenulogo);
            leftmenu.Add(menutable);
            leftmenu.Hidden = true;
            View.Add(leftmenu);
            FnBindMenu();
            leftmenu.Hidden = false;
        }

        void FnInitializeView()
        {
            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);
            topmenulogo_.SetBackgroundImage(UIImage.FromBundle("Menu.png"), UIControlState.Normal);

            topmenulogo_.TouchUpInside += delegate (object sender, EventArgs e)
            {

                if (leftmenu.Frame.X >= 0)
                {
                    leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    _MiRestauranteSV_.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                else
                {
                    leftmenu.Frame = new RectangleF(0, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    _MiRestauranteSV_.Frame = new RectangleF(250, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
            };

            MiEditorHoraBtn.TouchUpInside += delegate (object sender, EventArgs e)
            {
                HorariosController controller = this.Storyboard.InstantiateViewController("HorariosCntrlr") as HorariosController;
                this.NavigationController.PushViewController(controller, true);
                FnSwipeRightToLeft();
            };

            MiEditorMesasBtn.TouchUpInside += delegate (object sender, EventArgs e)
            {
                MesasController controller = this.Storyboard.InstantiateViewController("MesasCntrlr") as MesasController;
                this.NavigationController.PushViewController(controller, true);
                FnSwipeRightToLeft();
            };

        }

        void FnSwipeLeftToRight()
        {
            if (leftmenu.Hidden)
                FnPerformTableTransition();

        }

        void FnSwipeRightToLeft()
        {
            if (!leftmenu.Hidden)
                FnPerformTableTransition();
        }
        void FnPerformTableTransition()
        {
            leftmenu.Hidden = !leftmenu.Hidden;
            var transition = new CATransition();
            transition.Duration = 0.25f;
            transition.Type = CAAnimation.TransitionPush;
            if (leftmenu.Hidden)
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeOut"));
                transition.Subtype = CAAnimation.TransitionFromRight;
            }
            else
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeIn"));
                transition.Subtype = CAAnimation.TransitionFromLeft;
            }
            leftmenu.Layer.AddAnimation(transition, null);
        }
        void FnBindMenu()
        {
            if (objMenuTableSource != null)
            {
                objMenuTableSource.MenuSelected -= FnMenuSelected;
                objMenuTableSource = null;
            }
            objMenuTableSource = new MenuTableSourceClass();
            objMenuTableSource.MenuSelected += ObjMenuTableSource_MenuSelected;
            menutable.Source = objMenuTableSource;
        }

        private void ObjMenuTableSource_MenuSelected(string obj)
        {

            if (obj.Equals("RESERVACIONES"))
            {
                DashboardController controller = this.Storyboard.InstantiateViewController("DashboardCntrlr") as DashboardController;
                this.NavigationController.PushViewController(controller, true);
                FnSwipeRightToLeft();
            }
        }

        void FnMenuSelected(string strMenuSeleted)
        {
            //var okCancelAlertController = UIAlertController.Create("Alert Title", "Choose from two buttons", UIAlertControllerStyle.Alert);

            ////Add Actions
            //okCancelAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => Console.WriteLine("Okay was clicked")));
            //okCancelAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alert => Console.WriteLine("Cancel was clicked")));

            ////Present Alert
            //PresentViewController(okCancelAlertController, true, null);

            //if (strMenuSeleted.Equals("RESERVAR"))
            //{
            PerformSegue("LinkToOrderDtls", this);
            FnSwipeRightToLeft();
            //}
        }
        void FnAnimateView(nfloat frameY, UIView view)
        {
            UIView.Animate(0.2f, 0.1f, UIViewAnimationOptions.CurveEaseIn, delegate
            {
                var frame = View.Frame;
                frame.Y = frameY;
                view.Frame = frame;
            }, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}