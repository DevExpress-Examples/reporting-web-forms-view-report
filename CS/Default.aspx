<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T132094.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v22.2.Web.WebForms, Version=22.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function previewReport() {
            documentViewer.OpenReport(cbReportType.GetSelectedItem().value.toString());
        }
    </script>
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <dx:ASPxComboBox ID="cbReportType" ClientInstanceName="cbReportType" runat="server" ValueType="System.String" AutoPostBack="false" SelectedIndex="0">
                        <Items>
                            <dx:ListEditItem Text="(Empty)" Value="DefaultReport" />
                            <dx:ListEditItem Text="Categories Report" Value="Categories" />
                            <dx:ListEditItem Text="Products Report" Value="Products" />
                            <dx:ListEditItem Text="Orders Report" Value="Orders" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
                <td>
                    <dx:ASPxButton ID="btPreview" runat="server" Text="Preview" AutoPostBack="false" >
                        <ClientSideEvents Click="previewReport" />
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
     
        <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" ClientInstanceName="documentViewer" runat="server">            
            <ClientSideEvents Init="previewReport" />
        </dx:ASPxWebDocumentViewer>
     
    </div>
    </form>
</body>
</html>
