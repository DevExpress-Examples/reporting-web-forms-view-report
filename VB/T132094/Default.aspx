<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="T132094.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v14.1.Web, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<table>
			<tr>
				<td>
					<dx:ASPxComboBox ID="cbReportType" runat="server" ValueType="System.String">
						<Items>
							<dx:ListEditItem Text="(Empty)" Value="" />
							<dx:ListEditItem Text="Categories Report" Value="Categories" />
							<dx:ListEditItem Text="Products Report" Value="Products" />
							<dx:ListEditItem Text="Orders Report" Value="Orders" />
						</Items>
					</dx:ASPxComboBox>
				</td>
				<td>
					<dx:ASPxButton ID="btPreview" runat="server" Text="Preview" 
						onclick="btPreview_Click">
					</dx:ASPxButton>
				</td>
			</tr>
		</table>
		<dx:ASPxDocumentViewer ID="documentViewer" runat="server">
		</dx:ASPxDocumentViewer>
	</div>
	</form>
</body>
</html>