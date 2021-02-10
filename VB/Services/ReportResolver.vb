Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace T132094.Services
	Public Class CustomWebDocumentViewerReportResolver
		Implements IWebDocumentViewerReportResolver

		Public Sub New()
		End Sub
		Public Function Resolve(ByVal reportUniqueName As String) As XtraReport Implements IWebDocumentViewerReportResolver.Resolve
			Select Case reportUniqueName
				Case "DefaultReport"
					Return New DefaultReport()
				Case "Categories"
					Return New CategoriesReport()
				Case "Products"
					Return New ProductsReport()
				Case "Orders"
					Return New OrdersReport()
				Case Else
					' Try to create a report using the fully qualified type name.
					Dim t As Type = Type.GetType(reportUniqueName)
					Return If(GetType(XtraReport).IsAssignableFrom(t), DirectCast(Activator.CreateInstance(t), XtraReport), Nothing)
			End Select
		End Function
	End Class
End Namespace
