<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomerEdit.ascx.cs" Inherits="DAValidation.Sample.UserControls.CustomerEdit" %>
<%@ Import Namespace="DAValidation.Sample.Entities" %>
<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>

<dav:MetadataSource runat="server" ID="msCustomer" ObjectType="<%$ Code: typeof(Customer) %>" />
<table style="max-width: 600px">
	<tr>
		<td colspan="2">
			<asp:ValidationSummary runat="server" ID="vsCustomer" DisplayMode="BulletList" HeaderText="Account Information Validation Summary" ValidationGroup="CustomerEdit" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblName" Text="Full name" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbName" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davUsername" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbName"
				ObjectProperty="Name" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblEmailAddress" Text="Email address" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbEmailAddress" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davEmailAddress" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbEmailAddress"
				ObjectProperty="EmailAddress" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblPhoto" Text="Select photo" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbPhoto" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davPhoto" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbPhoto"
				ObjectProperty="PhotoFilePath" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblPhone" Text="Phone" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbPhone" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davPhone" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbPhone"
				ObjectProperty="Phone" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblCreditCardNumber" Text="Credit card number" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbCreditCardNumber" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davCreditCardNumber" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbCreditCardNumber"
				ObjectProperty="CreditCardNumber" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblWebsite" Text="Website URL" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbWebsite" ValidationGroup="CustomerEdit" runat="server" />
			<dav:DataAnnotationsValidator ID="davWebsite" runat="server" 
				Text="*"
				ValidationGroup="CustomerEdit"
				MetadataSourceID="msCustomer"
				ControlToValidate="tbWebsite"
				ObjectProperty="Website" />
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnCustomerSubmit" Text="Submit" ValidationGroup="CustomerEdit" runat="server" />
			<asp:Button ID="btnCustomerCancel" Text="Cancel" CausesValidation="false" runat="server" />
		</td>
	</tr>
</table>