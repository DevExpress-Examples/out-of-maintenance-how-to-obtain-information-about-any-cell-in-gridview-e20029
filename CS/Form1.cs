using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars.Helpers;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1);
            gridControl1.DataSource = CreateTable(20);
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Gray;
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            WriteInfoToPanel(gridView1.GetCellInfoUnderMouseCursor(e.Location));
        }
        private void WriteInfoToPanel(GridCellInfo info)
        {
            if (info != null)
            {
                panel1.BackColor = info.Appearance.BackColor;
                label1.Text = String.Format("Value={0}, Bounds={1}", info.CellValue, info.Bounds);
            }
        }

    }
}
