Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraReports.UI

Namespace T132094
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Private Function GetReportByName(ByVal reportName As String) As XtraReport
			Dim report As XtraReport = Nothing
			Select Case reportName
				Case "Categories"
					report = New CategoriesReport()
				Case "Products"
					report = New ProductsReport()
				Case "Orders"
					report = New OrdersReport()
			End Select
			Return report
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim reportName As String = CStr(Session("ReportName"))
			If (Not String.IsNullOrEmpty(reportName)) Then
				documentViewer.Report = GetReportByName(reportName)
			End If
		End Sub

		Protected Sub btPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim reportName As String = CStr(cbReportType.Value)

			documentViewer.Report = GetReportByName(reportName)
			Session("ReportName") = reportName
		End Sub
	End Class
End Namespace