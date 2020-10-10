using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
    public class MesaETableSource : UITableViewSource
    {
        readonly string[] tableDesc;
        readonly string[] numofPersons;
        readonly string[] numofTables;

        internal event Action<string> MenuSelected;

        public MesaETableSource()
        {
            tableDesc = MesaConstants.tableDesc;
            numofPersons = MesaConstants.numofPersons;
            numofTables = MesaConstants.numofTables;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableDesc.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            MesaERowViewCell cell = tableView.DequeueReusableCell(MesaERowViewCell.Key) as MesaERowViewCell ?? MesaERowViewCell.Create();
            cell.BindData( tableDesc[indexPath.Row], numofPersons[indexPath.Row], numofTables[indexPath.Row]);

            return cell;
        }

        public int GetTotalRows()
        {
            return tableDesc.Length;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (MenuSelected != null)
                MenuSelected(tableDesc[indexPath.Row]);

            tableView.DeselectRow(indexPath, true);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView();
        }
    }
}