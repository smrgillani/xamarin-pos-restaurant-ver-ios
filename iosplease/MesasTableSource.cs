using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
    public class MesasTableSource : UITableViewSource
    {
        readonly string[] tableType;
        readonly string[] tableSeats;
        readonly string[] tableAvlTbls;
        readonly string[] tableAvgTime;
        readonly string[] tableName;

        internal event Action<string> MenuSelected;

        public MesasTableSource()
        {
            tableType = MesasConstants.tableType;
            tableSeats = MesasConstants.tableSeats;
            tableAvlTbls = MesasConstants.tableAvailables;
            tableAvgTime = MesasConstants.tableAvgTime;
            tableName = MesasConstants.tableName;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableType.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            MesaRow cell = tableView.DequeueReusableCell(MesaRow.Key) as MesaRow ?? MesaRow.Create();
            cell.BindData("   " + tableType[indexPath.Row], tableSeats[indexPath.Row], tableAvlTbls[indexPath.Row], tableAvgTime[indexPath.Row], tableName[indexPath.Row]);

            return cell;
        }

        public int GetTotalRows()
        {
            return tableType.Length;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (MenuSelected != null)
                MenuSelected(tableType[indexPath.Row]);

            tableView.DeselectRow(indexPath, true);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView();
        }
    }
}