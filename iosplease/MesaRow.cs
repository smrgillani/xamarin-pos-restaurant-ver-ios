using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace iosplease
{
    public partial class MesaRow : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MesaRow");
        public static readonly UINib Nib;

        static MesaRow()
        {
            Nib = UINib.FromName("MesaRow", NSBundle.MainBundle);
        }

        protected MesaRow(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public static MesaRow Create()
        {
            return (MesaRow)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string tableType,string tableSeats,string tableAvlbls, string tableAvgTime, string tableName)
        {

            MesasRow_TableType.Text = tableType;
            MesasRow_TableSeats.Text = tableSeats;
            MesasRow_TableAvllbl.Text = tableAvlbls;
            MesasRow_AvgTime.Text = tableAvgTime;
            MesasRow_TableName.Text = tableName;
            MesasRow_TableType.Frame = new RectangleF((float)MesasRow_TableType.Frame.X, (float)MesasRow_TableType.Frame.Y, (float)MesaRowOuterBody.Frame.Width, (float)MesasRow_TableType.Frame.Height);
            MySwitchBtn.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)MySwitchBtn.Frame.X + 65 : (float)MySwitchBtn.Frame.X - 30) , (float)MySwitchBtn.Frame.Y, (float)MySwitchBtn.Frame.Width, (float)MySwitchBtn.Frame.Height);
            MesasRow_TableAvllbl.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)MesasRow_TableAvllbl.Frame.X + 60 : (float)MesasRow_TableAvllbl.Frame.X-30), (float)MesasRow_TableAvllbl.Frame.Y, (float)MesasRow_TableAvllbl.Frame.Width, (float)MesasRow_TableAvllbl.Frame.Height);

            MesasRow_AvgTime.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)MesasRow_AvgTime.Frame.X + 60 : (float)MesasRow_AvgTime.Frame.X - 30), (float)MesasRow_AvgTime.Frame.Y, (float)MesasRow_AvgTime.Frame.Width, (float)MesasRow_AvgTime.Frame.Height);
            MesasRow_TableName.Frame = new RectangleF(((float)UIScreen.MainScreen.Bounds.Width > 320 ? (float)MesasRow_TableName.Frame.X + 60 : (float)MesasRow_TableName.Frame.X - 30), (float)MesasRow_TableName.Frame.Y, (float)MesasRow_TableName.Frame.Width, (float)MesasRow_TableName.Frame.Height);

            MesaRowOuterBody.Frame = new RectangleF((float)MesaRowOuterBody.Frame.X,(float)MesaRowOuterBody.Frame.Y,(float)UIScreen.MainScreen.Bounds.Width - 14 , (float)MesaRowOuterBody.Frame.Height);
            MesasRow_TableType.Frame = new RectangleF((float)MesasRow_TableType.Frame.X, (float)MesasRow_TableType.Frame.Y, (float)MesaRowOuterBody.Frame.Width , (float)MesasRow_TableType.Frame.Height);
        }
    }
}
