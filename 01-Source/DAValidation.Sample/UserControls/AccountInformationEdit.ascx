<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountInformationEdit.ascx.cs" Inherits="DAValidation.Sample.UserControls.AccountInformationEdit" %>

<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>
<%@ Import Namespace="DAValidation.Sample.Entities" %>

<dav:MetadataSource runat="server" ID="msAccountInformation" ObjectType="<%$ Code: typeof(AccountInformation) %>" />
<table style="max-width: 600px">
	<tr>
		<td colspan="2">
			<asp:ValidationSummary runat="server" ID="vsAccountInformation" DisplayMode="BulletList" HeaderText="Account Information Validation Summary" ValidationGroup="AccountInformation" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblUsername" Text="Username" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbUsername" ValidationGroup="AccountInformation" runat="server" />
			<dav:DataAnnotationsValidator ID="davUsername" runat="server" 
				Text="*"
				ValidationGroup="AccountInformation"
				MetadataSourceID="msAccountInformation"
				ControlToValidate="tbUsername"
				ObjectProperty="Username" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblPassword" Text="Password" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbPassword" ValidationGroup="AccountInformation" TextMode="Password" runat="server" />
			<dav:DataAnnotationsValidator ID="davPassword" runat="server" 
				ValidationGroup="AccountInformation"
				MetadataSourceID="msAccountInformation"
				ControlToValidate="tbPassword"
				ObjectProperty="Password" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblPasswordConfirmation" Text="Password Confirmation" TextMode="Password" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbPasswordConfirmation" ValidationGroup="AccountInformation" TextMode="Password" runat="server" />
			<dav:DataAnnotationsValidator ID="davPasswordConfirmation" runat="server"
				ValidationGroup="AccountInformation"
				MetadataSourceID="msAccountInformation"
				ControlToValidate="tbPasswordConfirmation"
				ObjectProperty="PasswordConfirmation" />
			<asp:CompareValidator runat="server" ID="cvPasswordConfirmation" 
				ValidationGroup="AccountInformation"
				ControlToValidate="tbPassword"
				ControlToCompare="tbPasswordConfirmation" 
				Operator="Equal" 
				ErrorMessage="<%$ Resources: AccountInformation, AccountInformation_PasswordConfirmation_Equality %>"/>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblSecurityQuestion" Text="Security Question" runat="server" />
	
		</td>
		<td>
			<asp:TextBox ID="tbSecurityQuestion" ValidationGroup="AccountInformation" runat="server" />
			<dav:DataAnnotationsValidator ID="davSecurityQuestion" runat="server" 
				ValidationGroup="AccountInformation"
				MetadataSourceID="msAccountInformation"
				ControlToValidate="tbSecurityQuestion"
				ObjectProperty="SecurityQuestion" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblSecurityAnswer" Text="Security Answer" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbSecurityAnswer" ValidationGroup="AccountInformation" runat="server" />
			<dav:DataAnnotationsValidator ID="davSecurityAnswer" runat="server" 
				ValidationGroup="AccountInformation"
				MetadataSourceID="msAccountInformation"
				ControlToValidate="tbSecurityAnswer"
				ObjectProperty="SecurityAnswer" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label runat="server" ID="lblDummyDataGrid" Text="GridView with dummy data"></asp:Label>
		</td>
		<td>
			<asp:ObjectDataSource runat="server" ID="odsDummyData" 
				TypeName="DAValidation.Sample.UserControls.AccountInformationEdit"
				SelectMethod="GetData" />
			<asp:GridView runat="server" DataSourceID="odsDummyData" AutoGenerateColumns="True" />
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnAccountInfoSubmit" Text="Submit" ValidationGroup="AccountInformation" runat="server" />
			<asp:Button ID="btnAccountInfoCancel" Text="Cancel" CausesValidation="false" runat="server" />
		</td>
	</tr>
</table>