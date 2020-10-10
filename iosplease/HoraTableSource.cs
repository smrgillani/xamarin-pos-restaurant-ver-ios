using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
    public class HoraTableSource : UITableViewSource
    {
        readonly string[] dayName;
        readonly string[] dayTime;
        internal event Action<string> MenuSelected;

        public HoraTableSource()
        {
            dayName = HoraConstants.dayName;
            dayTime = HoraConstants.dayTime;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return dayName.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            HoraRow cell = tableView.DequeueReusableCell(HoraRow.Key) as HoraRow ?? HoraRow.Create();
            cell.BindData("  "+dayName[indexPath.Row], dayTime[indexPath.Row].Split('-')[0] , dayTime[indexPath.Row].Split('-')[1]);

            return cell;
        }

        public int GetTotalRows()
        {
            return dayName.Length;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (MenuSelected != null)
                MenuSelected(dayName[indexPath.Row]);

            tableView.DeselectRow(indexPath, true);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView();
        }
    }
}