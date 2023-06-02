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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column18 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression18 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join3 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbDetails = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbShipTo = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.nwindDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' lbOrderID
			' 
			Me.lbOrderID.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
			Me.lbOrderID.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lbOrderID.Name = "lbOrderID"
			Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbOrderID.SizeF = New System.Drawing.SizeF(91.66666F, 23F)
			Me.lbOrderID.StylePriority.UseFont = False
			Me.lbOrderID.Text = "lbOrderID"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbTitle
			' 
			Me.lbTitle.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")})
			Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold)
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
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.lbDate, Me.lbDetails, Me.lbTitle, Me.lbShipTo, Me.lbOrderID})
			Me.Detail.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F)
			Me.Detail.HeightF = 127.6042F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseFont = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDate
			' 
			Me.lbDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
			Me.lbDate.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Italic)
			Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(101.6667F, 10.00001F)
			Me.lbDate.Name = "lbDate"
			Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDate.SizeF = New System.Drawing.SizeF(238.3334F, 23F)
			Me.lbDate.StylePriority.UseFont = False
			Me.lbDate.Text = "lbDate"
			Me.lbDate.TextFormatString = "{0:dddd, dd MMMM, yyyy}"
			' 
			' lbDetails
			' 
			Me.lbDetails.Font = New DevExpress.Drawing.DXFont("Times New Roman", 12F)
			Me.lbDetails.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 84.6042F)
			Me.lbDetails.Name = "lbDetails"
			Me.lbDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDetails.SizeF = New System.Drawing.SizeF(330F, 32.99999F)
			Me.lbDetails.StylePriority.UseFont = False
			Me.lbDetails.StylePriority.UseTextAlignment = False
			Me.lbDetails.Text = "[FirstName] [LastName]"
			Me.lbDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbShipTo
			' 
			Me.lbShipTo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("lbShipTo.ExpressionBindings"))})
			Me.lbShipTo.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F)
			Me.lbShipTo.LocationFloat = New DevExpress.Utils.PointFloat(352.5F, 67.00001F)
			Me.lbShipTo.Multiline = True
			Me.lbShipTo.Name = "lbShipTo"
			Me.lbShipTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbShipTo.SizeF = New System.Drawing.SizeF(287.5F, 50.60416F)
			Me.lbShipTo.StylePriority.UseFont = False
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New DevExpress.Drawing.DXFont("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Orders Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' nwindDataSource
			' 
			Me.nwindDataSource.ConnectionName = "nwindConnection"
			Me.nwindDataSource.Name = "nwindDataSource"
			columnExpression1.ColumnName = "OrderID"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""358"" />"
			table1.Name = "Orders"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CustomerID"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "EmployeeID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "RequiredDate"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "ShippedDate"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "ShipVia"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Freight"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ShipName"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "ShipAddress"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "ShipCity"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "ShipRegion"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ShipPostalCode"
			columnExpression13.Table = table1
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ShipCountry"
			columnExpression14.Table = table1
			column14.Expression = columnExpression14
			columnExpression15.ColumnName = "LastName"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""418"" />"
			table2.Name = "Employees"
			columnExpression15.Table = table2
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "FirstName"
			columnExpression16.Table = table2
			column16.Expression = columnExpression16
			columnExpression17.ColumnName = "CompanyName"
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""138"" />"
			table3.Name = "Shippers"
			columnExpression17.Table = table3
			column17.Expression = columnExpression17
			columnExpression18.ColumnName = "Supplier"
			table4.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""198"" />"
			table4.Name = "OrderDetails"
			columnExpression18.Table = table4
			column18.Expression = columnExpression18
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Columns.Add(column15)
			selectQuery1.Columns.Add(column16)
			selectQuery1.Columns.Add(column17)
			selectQuery1.Columns.Add(column18)
			selectQuery1.Name = "Orders"
			relationColumnInfo1.NestedKeyColumn = "EmployeeID"
			relationColumnInfo1.ParentKeyColumn = "EmployeeID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "ShipperID"
			relationColumnInfo2.ParentKeyColumn = "ShipVia"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			relationColumnInfo3.NestedKeyColumn = "OrderID"
			relationColumnInfo3.ParentKeyColumn = "OrderID"
			join3.KeyColumns.Add(relationColumnInfo3)
			join3.Nested = table4
			join3.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Relations.Add(join3)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			selectQuery1.Tables.Add(table4)
			Me.nwindDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.nwindDataSource.ResultSchemaSerializable = resources.GetString("nwindDataSource.ResultSchemaSerializable")
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'Supplier Info:' + [Supplier]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(352.5F, 10.00001F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(287.5F, 57F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' OrdersReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSource
			Me.Version = "20.2"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

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
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
