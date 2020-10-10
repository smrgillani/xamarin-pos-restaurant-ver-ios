using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class DashboardController : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        ResrsTableSource objResrTableSource;
        UIImageView topmenulogo = new UIImageView();
        UIView leftmenu = new UIView();
        UITableView menutable = new UITableView();

        public DashboardController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            FnInitializeView();
            
            DashboardMainView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
            topmenulogo.Image = UIImage.FromBundle("logoonmenu.png");
            topmenulogo.Frame = new RectangleF(92, 30, 66, 66);
            leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
            menutable.Frame = new RectangleF(0, 110, 250, 86);
            TopNavBar.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            leftmenu.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            ResListTable.Frame = new RectangleF((float)ResListTable.Frame.X, (float)ResListTable.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width, (float)ResListTable.Frame.Height);
            menutable.ScrollEnabled = false;
            menutable.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            
            leftmenu.Add(topmenulogo);
            leftmenu.Add(menutable);
            leftmenu.Hidden = true;
            View.Add(leftmenu);
            FnBindMenu();
            FnBindResTable();
            leftmenu.Hidden = false;

        }

        void FnBindResTable()
        {
            if (objResrTableSource != null)
            {
                objResrTableSource = null;
            }
            objResrTableSource = new ResrsTableSource();
            var sizeofscreen = objResrTableSource.GetTotalRows();
            objResrTableSource.MenuSelected += FnMenuSelected;
            ResListTable.Source = objResrTableSource;
            ResListTable.ContentInset = new UIEdgeInsets(0, 0, 50, 0);
            ResListTable.ReloadData();
        }

        void FnInitializeView()
        {
            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);
            btnIcon.SetBackgroundImage(UIImage.FromBundle("Menu.png"), UIControlState.Normal);

            btnIcon.TouchUpInside += delegate (object sender, EventArgs e)
            {

                if (leftmenu.Frame.X >= 0)
                {
                    leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    DashboardMainView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                else
                {
                    leftmenu.Frame = new RectangleF(0, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    DashboardMainView.Frame = new RectangleF(250, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                //leftmenu.Hidden = false;
                
                //FnPerformTableTransition();
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
            
            if (obj.Equals("MI RESTAURANTE"))
            {
                MiRestaurantController controller = this.Storyboard.InstantiateViewController("MiRestaurantCntrlr") as MiRestaurantController;
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