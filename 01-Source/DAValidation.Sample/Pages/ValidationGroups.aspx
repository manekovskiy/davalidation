<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidationGroups.aspx.cs" Inherits="DAValidation.Sample.Pages.ValidationGroups" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register TagPrefix="uc" TagName="ContactInformationEdit" Src="~/UserControls/ContactInformationEdit.ascx" %>
<%@ Register TagPrefix="uc" TagName="AccountInformationEdit" Src="~/UserControls/AccountInformationEdit.ascx" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<table>
		<thead>
			<th>ContactInformation Group</th>
			<th>AccountInformation Group</th>
		</thead>
		<tbody>
			<tr>
				<td>
					<uc:ContactInformationEdit runat="server" ID="ucContactInformationEdit" />
				</td>
				<td>
					<uc:AccountInformationEdit runat="server" ID="ucAccountInformationEdit" />
				</td>
			</tr>	
		</tbody>
	</table>
</asp:Content>