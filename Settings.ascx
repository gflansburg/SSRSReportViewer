<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="Gafware.Modules.SSRSReportViewer.Settings" %>
<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

	<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
	<fieldset>
        <div class="dnnFormItem">
            <dnn:Label ID="lblConnectionString" runat="server" ControlName="txtConnectionString" Suffix=":" /> 
            <asp:TextBox ID="txtConnectionString" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblHeight" runat="server" ControlName="txtheight" Suffix=":" /> 
            <telerik:RadNumericTextBox ID="txtHeight" MinValue="0" runat="server" Width="50px" NumberFormat-DecimalDigits="0" /> px
        </div>
    </fieldset>

