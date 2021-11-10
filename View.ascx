<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Gafware.Modules.SSRSReportViewer.View" %>
<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<div class="dnnFormItem">
    <dnn:Label ID="lblReports" runat="server" /> 
    <asp:DropDownList runat="server" ID="lstReports" AutoPostBack="true" OnSelectedIndexChanged="lstReports_SelectedIndexChanged" DataTextField="Name" DataValueField="Path" />
</div>
<br />
<div style="width: 100%; height: <#= ReportViewerHeight %>; overflow: auto;" class="SSRSReport">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" ProcessingMode="Remote" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%" Height="800px" />
</div>
