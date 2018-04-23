Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Dim styleFormatCondition2 As New DevExpress.XtraGrid.StyleFormatCondition()
			Dim styleFormatCondition3 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 142)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(548, 277)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			styleFormatCondition1.Appearance.Options.UseBackColor = True
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
			styleFormatCondition1.Expression = "Contains([Name], '1')"
			styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			styleFormatCondition2.Appearance.Options.UseBackColor = True
			styleFormatCondition2.ApplyToRow = True
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
			styleFormatCondition2.Expression = "Contains([Name], '2')"
			styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime
			styleFormatCondition3.Appearance.Options.UseBackColor = True
			styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
			styleFormatCondition3.Expression = "[Number] > 0"
			Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1, styleFormatCondition2, styleFormatCondition3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove);
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.ribbonGalleryBarItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 2
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(548, 142)
			' 
			' ribbonGalleryBarItem1
			' 
			Me.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1"
			Me.ribbonGalleryBarItem1.Id = 1
			Me.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Appearance"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.ribbonGalleryBarItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.panel1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 419)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(5)
			Me.panelControl1.Size = New System.Drawing.Size(548, 60)
			Me.panelControl1.TabIndex = 4
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(7, 7)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(534, 46)
			Me.panel1.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(35, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "label1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 479)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private ribbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
	End Class
End Namespace

