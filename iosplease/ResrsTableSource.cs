using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
   public class ResrsTableSource : UITableViewSource
    {
        readonly string[] customerName;
        readonly string[] timeandDate;
        readonly string[] personNum;
        readonly string[] AreaDtl;
        readonly string[] NoteOfResr;
        readonly string[] ConCOde;
        internal event Action<string> MenuSelected;

        public ResrsTableSource()
        {
            customerName = ResrConstants.cusNames;
            timeandDate = ResrConstants.dateandTime;
            personNum = ResrConstants.persons;
            AreaDtl = ResrConstants.areas;
            NoteOfResr = ResrConstants.notes;
            ConCOde = ResrConstants.concodes;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return customerName.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            ResrRow cell = tableView.DequeueReusableCell(ResrRow.Key) as ResrRow ?? ResrRow.Create();
            cell.BindData(" " + " " +customerName[indexPath.Row], "  "+ timeandDate[indexPath.Row], personNum[indexPath.Row], AreaDtl[indexPath.Row], NoteOfResr[indexPath.Row], ConCOde[indexPath.Row]);

            //cell.SeparatorInset = UIEdgeInsetsMake(0, 0, 0, CGRectGetWidth(tableView.bounds));

            return cell;
        }

        public int GetTotalRows()
        {
            return customerName.Length;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (MenuSelected != null)
                MenuSelected(customerName[indexPath.Row]);

            tableView.DeselectRow(indexPath, true);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView();
        }
    }
}