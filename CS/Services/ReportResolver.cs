using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T132094.Services {
    public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver {
        public CustomWebDocumentViewerReportResolver() { }
        public XtraReport Resolve(string reportUniqueName) {
            switch (reportUniqueName) {
                case "DefaultReport":
                    return new DefaultReport();
                case "Categories":
                    return new CategoriesReport();
                case "Products":
                    return new ProductsReport();
                case "Orders":
                    return new OrdersReport();
                default:
                    // Try to create a report using the fully qualified type name.
                    Type t = Type.GetType(reportUniqueName);
                    return typeof(XtraReport).IsAssignableFrom(t) ?
                        (XtraReport)Activator.CreateInstance(t) :
                        null;
            }
        }
    }
}
