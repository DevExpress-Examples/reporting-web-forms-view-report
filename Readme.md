<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/T132094/Default.aspx) (VB: [Default.aspx](./VB/T132094/Default.aspx))
* **[Default.aspx.cs](./CS/T132094/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T132094/Default.aspx.vb))**
<!-- default file list end -->
# ASPxDocumentViewer - How to dynamically preview a report in document viewer after a button was clicked
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t132094/)**
<!-- run online end -->

This example demonstrates how to dynamically load a report to the [ASPxWebDocumentViewer](https://docs.devexpress.com/XtraReports/17738/web-reporting/asp-net-webforms-reporting/document-viewer) control at runtime on a button click. 

Implement a custom [IWebDocumentViewerReportResolver](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerReportResolver) service. Then, handle a button's client-side `Click` event and pass a report name to the client-side [OpenReport](https://docs.devexpress.com/XtraReports/js-ASPxClientWebDocumentViewer#js_aspxclientwebdocumentviewer_openreport_url_) method.

Note: switch to the 14.1.5 branch to learn how to complete the task for the ASPxWebDocumentViewer control.


