Imports Microsoft.VisualBasic
Imports System
Namespace T132094
	Partial Public Class OrdersReport
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
			Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbDetails = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbShipTo = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwindDataSource = New DevExpress.DataAccess.Sql.SqlDataSource("nwindConnection")
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' lbOrderID
			' 
			Me.lbOrderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
			Me.lbOrderID.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lbOrderID.Name = "lbOrderID"
			Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbOrderID.SizeF = New System.Drawing.SizeF(91.66666F, 23F)
			Me.lbOrderID.StylePriority.UseFont = False
			Me.lbOrderID.Text = "lbOrderID"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbTitle
			' 
			Me.lbTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Title")})
			Me.lbTitle.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00012F, 44.00002F)
			Me.lbTitle.Name = "lbTitle"
			Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbTitle.SizeF = New System.Drawing.SizeF(330F, 23F)
			Me.lbTitle.StylePriority.UseFont = False
			Me.lbTitle.StylePriority.UseTextAlignment = False
			Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDate, Me.lbDetails, Me.lbTitle, Me.lbShipTo, Me.lbOrderID})
			Me.Detail.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.Detail.HeightF = 100F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseFont = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDate
			' 
			Me.lbDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "{0:dddd, dd MMMM, yyyy}")})
			Me.lbDate.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic)
			Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(101.6667F, 10.00001F)
			Me.lbDate.Name = "lbDate"
			Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDate.SizeF = New System.Drawing.SizeF(238.3334F, 23F)
			Me.lbDate.StylePriority.UseFont = False
			Me.lbDate.Text = "lbDate"
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Orders Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' lbDetails
			' 
			Me.lbDetails.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 67.00001F)
			Me.lbDetails.Name = "lbDetails"
			Me.lbDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDetails.SizeF = New System.Drawing.SizeF(330F, 32.99999F)
			Me.lbDetails.StylePriority.UseTextAlignment = False
			Me.lbDetails.Text = "[FirstName] [LastName]"
			Me.lbDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.HeightF = 100F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbShipTo
			' 
			Me.lbShipTo.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.lbShipTo.LocationFloat = New DevExpress.Utils.PointFloat(352.5F, 10.00001F)
			Me.lbShipTo.Multiline = True
			Me.lbShipTo.Name = "lbShipTo"
			Me.lbShipTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbShipTo.SizeF = New System.Drawing.SizeF(287.5F, 89.99999F)
			Me.lbShipTo.StylePriority.UseFont = False
			Me.lbShipTo.Text = "Ship To [ContactName] ([CompanyName]):" & Constants.vbCrLf & "[ShipCountry], [ShipCity] [ShipPostalCode" & "]" & Constants.vbCrLf & "[ShipRegion]" & Constants.vbCrLf & "[ShipAddress]"
			' 
			' nwindDataSource
			' 
			tableQuery1.Name = "Orders"
			tableInfo1.Name = "Orders"
			columnInfo1.Name = "OrderID"
			columnInfo2.Name = "CustomerID"
			columnInfo3.Name = "EmployeeID"
			columnInfo4.Name = "OrderDate"
			columnInfo5.Name = "RequiredDate"
			columnInfo6.Name = "ShippedDate"
			columnInfo7.Name = "ShipVia"
			columnInfo8.Name = "Freight"
			columnInfo9.Name = "ShipName"
			columnInfo10.Name = "ShipAddress"
			columnInfo11.Name = "ShipCity"
			columnInfo12.Name = "ShipRegion"
			columnInfo13.Name = "ShipPostalCode"
			columnInfo14.Name = "ShipCountry"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			Me.nwindDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
			Me.nwindDataSource.ResultSchemaSerializable = resources.GetString("nwindDataSource.ResultSchemaSerializable")
			' 
			' OrdersReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSource
			Me.Version = "14.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private lbOrderID As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private lbTitle As DevExpress.XtraReports.UI.XRLabel
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private lbDate As DevExpress.XtraReports.UI.XRLabel
		Private lbDetails As DevExpress.XtraReports.UI.XRLabel
		Private lbShipTo As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private nwindDataSource As DevExpress.DataAccess.Sql.SqlDataSource

	End Class
End Namespace
