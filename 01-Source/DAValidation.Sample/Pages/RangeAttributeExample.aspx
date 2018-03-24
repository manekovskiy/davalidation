<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RangeAttributeExample.aspx.cs" Inherits="DAValidation.Sample.Pages.RangeAttributeExample" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register Src="~/UserControls/RangesEdit.ascx" TagPrefix="uc" TagName="RangesEdit" %>

<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<uc:RangesEdit runat="server" ID="ucRangesEdit" />
</asp:Content>