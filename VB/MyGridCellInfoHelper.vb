Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing

Namespace WindowsApplication1
	Public Module MyGridCellInfoHelper

		<System.Runtime.CompilerServices.Extension> _
		Public Function GetCellInfo(ByVal view As GridView, ByVal rowHandle As Integer, ByVal col As GridColumn) As GridCellInfo
			Dim viewInfo As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
			Dim ci As GridCellInfo = viewInfo.GetGridCellInfo(rowHandle, col)
			If ci Is Nothing Then
				Return Nothing
			End If
			viewInfo.UpdateCellAppearance(ci)
			Return ci
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public Function GetCellInfoUnderMouseCursor(ByVal view As GridView, ByVal location As Point) As GridCellInfo
			Dim hi As GridHitInfo = view.CalcHitInfo(location)
			If hi.InRowCell Then
				Return GetCellInfo(view, hi.RowHandle, hi.Column)
			End If
			Return Nothing
		End Function

	End Module
End Namespace
