using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using T132094.Services;

namespace T132094 {
    public class Global_asax : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            DefaultWebDocumentViewerContainer.Register<IReportProvider, CustomReportProvider>();            
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}
