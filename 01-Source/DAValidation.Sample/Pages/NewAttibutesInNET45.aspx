<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewAttibutesInNET45.aspx.cs" Inherits="DAValidation.Sample.Pages.NewAttibutesInNET45" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register Src="~/UserControls/CustomerEdit.ascx" TagPrefix="uc" TagName="CustomerEdit" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<uc:CustomerEdit runat="server" id="CustomerEdit" />
</asp:Content>