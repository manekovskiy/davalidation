<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePanelExample.aspx.cs" Inherits="DAValidation.Sample.Pages.UpdatePanelExample" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register TagPrefix="uc" TagName="ContactInformationEdit" Src="~/UserControls/ContactInformationEdit.ascx" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<asp:UpdatePanel runat="server">
		<ContentTemplate>
			<uc:ContactInformationEdit runat="server" ID="ucContactInformationEdit" />	
		</ContentTemplate>
	</asp:UpdatePanel>
</asp:Content>