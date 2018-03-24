<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomAttribute.aspx.cs" Inherits="DAValidation.Sample.Pages.CustomAttribute" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register Src="~/UserControls/AccountInformationEdit.ascx" TagPrefix="uc" TagName="AccountInformationEdit" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<uc:AccountInformationEdit runat="server" ID="ucAccountInformationEdit" />
</asp:Content>