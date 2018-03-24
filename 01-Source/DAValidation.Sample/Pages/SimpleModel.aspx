<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleModel.aspx.cs" Inherits="DAValidation.Sample.Pages.SimpleModel" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register TagPrefix="uc" TagName="ContactInformationEdit" Src="~/UserControls/ContactInformationEdit.ascx" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<uc:ContactInformationEdit runat="server" ID="ucContactInformationEdit" />
</asp:Content>