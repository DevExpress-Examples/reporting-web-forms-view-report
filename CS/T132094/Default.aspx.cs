using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.UI;

namespace T132094 {
    public partial class Default : System.Web.UI.Page {
        private XtraReport GetReportByName(string reportName) {
            XtraReport report = null;
            switch (reportName) {
                case "Categories":
                    report = new CategoriesReport();
                    break;
                case "Products":
                    report = new ProductsReport();
                    break;
                case "Orders":
                    report = new OrdersReport();
                    break;
            }
            return report;
        }

        protected void Page_Load(object sender, EventArgs e) {
            string reportName = (string) Session["ReportName"];
            if (!String.IsNullOrEmpty(reportName)) {
                documentViewer.Report = GetReportByName(reportName);
            }
        }

        protected void btPreview_Click(object sender, EventArgs e) {
            string reportName = (string) cbReportType.Value;

            documentViewer.Report = GetReportByName(reportName);
            Session["ReportName"] = reportName;
        }       
    }
}