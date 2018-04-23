using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using System.Drawing;

namespace WindowsApplication1
{
    public static class MyGridCellInfoHelper 
    {
        public static GridCellInfo GetCellInfo(this GridView view, int rowHandle, GridColumn col)
        {
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            GridCellInfo ci = viewInfo.GetGridCellInfo(rowHandle, col);
            if (ci == null)
                return null;
            viewInfo.UpdateCellAppearance(ci);
            return ci;
        }

        public static GridCellInfo GetCellInfoUnderMouseCursor(this GridView view, Point location)
        {
            GridHitInfo hi = view.CalcHitInfo(location);
            if (hi.InRowCell)
                return GetCellInfo(view, hi.RowHandle, hi.Column);
            return null;
        }

    }
}
