Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraBars.Helpers

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Public Sub New()
			InitializeComponent()
			SkinHelper.InitSkinGallery(ribbonGalleryBarItem1)
			gridControl1.DataSource = CreateTable(20)
			gridView1.Columns(2).AppearanceCell.BackColor = Color.Gray
		End Sub

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			WriteInfoToPanel(gridView1.GetCellInfoUnderMouseCursor(e.Location))
		End Sub
		Private Sub WriteInfoToPanel(ByVal info As GridCellInfo)
			If info IsNot Nothing Then
				panel1.BackColor = info.Appearance.BackColor
				label1.Text = String.Format("Value={0}, Bounds={1}", info.CellValue, info.Bounds)
			End If
		End Sub

	End Class
End Namespace
