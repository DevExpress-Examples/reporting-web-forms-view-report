using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T132094.Services {
    public class CustomReportProvider : DevExpress.XtraReports.Services.IReportProvider {
        public XtraReport GetReport(string id, ReportProviderContext context) {
            switch (id) {
                case "DefaultReport":
                    return new DefaultReport();
                case "Categories":
                    return new CategoriesReport();
                case "Products":
                    return new ProductsReport();
                case "Orders":
                    return new OrdersReport();
                default:
                    return null;
            }
        }
    }
}
