Imports DevExpress.XtraReports.Services
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace T132094.Services
    Public Class CustomReportProvider
        Implements DevExpress.XtraReports.Services.IReportProvider

        Public Function GetReport(ByVal id As String, ByVal context As ReportProviderContext) As XtraReport Implements IReportProvider.GetReport
            Select Case id
                Case "DefaultReport"
                    Return New DefaultReport()
                Case "Categories"
                    Return New CategoriesReport()
                Case "Products"
                    Return New ProductsReport()
                Case "Orders"
                    Return New OrdersReport()
                Case Else
                    Return Nothing
            End Select
        End Function
    End Class
End Namespace
