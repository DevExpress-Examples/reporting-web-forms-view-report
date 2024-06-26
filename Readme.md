<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T132094)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/T132094/Default.aspx) (VB: [Default.aspx](./VB/T132094/Default.aspx))
* **[Default.aspx.cs](./CS/T132094/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T132094/Default.aspx.vb))**
<!-- default file list end -->
# ASPxDocumentViewer - How to dynamically preview a report in document viewer after a button was clicked


<p>This example demonstrates how to load a report to <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5193">ASPxDocumentViewer</a>  control dynamically at runtime.<br /><br />The ASPxDocumentViewer control uses a callback to display a report. According to the <a href="http://msdn.microsoft.com/en-us/library/ms178472%28v=vs.85%29.aspx">ASP.NET Page Life Cycle</a>, the ASP.NET WebForms page state should be restored on all postbacks and callbacks. To make the ASPxDocumentViewer control work correctly, a report that was dynamically assigned to it should be restored when the page is reloaded on a callback.<br /><strong>Take special note</strong> that if the report is not restored on a callback, the ASPxDocumentViewer control remains empty after assigning a report to it.<br /><br />In this code example, the Session variable is used to save the ASPxDocumentViewer state. When the page is loaded for the first time, the Session variable is not yet specified and the ASPxDocumentViewer remains empty. But after the button is clicked, the currently displayed report name is saved into the session (in the btPreview_Click event handler). Then, when the page is reloaded, this name is used to restore the report (in the Page_Load event handler).</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-view-report&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-view-report&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
