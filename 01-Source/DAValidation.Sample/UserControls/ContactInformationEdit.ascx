<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactInformationEdit.ascx.cs" Inherits="DAValidation.Sample.UserControls.ContactInformationEdit" %>
<%@ Import Namespace="DAValidation.Sample.Entities" %>
<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>

<dav:MetadataSource runat="server" ID="msContactInformation" ObjectType="<%$ Code: typeof(ContactInformation) %>" />
<table style="max-width: 600px">
	<tr>
		<td colspan="2">
			<asp:ValidationSummary runat="server" ID="vsContactInformation" DisplayMode="BulletList" HeaderText="Contact Information Validation Summary" ValidationGroup="ContactInformation" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblFirstName" AssociatedControlID="tbFirstName" Text="First Name" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbFirstName" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davFirstName" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbFirstName"
				ObjectProperty="FirstName" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblMiddleInitial" AssociatedControlID="tbMiddleInitial" Text="Middle Name" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbMiddleInitial" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davMiddleName" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbMiddleInitial"
				ObjectProperty="MiddleInitial" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblLastName" AssociatedControlID="tbLastName" Text="Last Name" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbLastName" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davLastName" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbLastName"
				ObjectProperty="LastName" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblCompanyName" AssociatedControlID="tbCompanyName" Text="Company Name" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbCompanyName" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davCompanyName" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbCompanyName"
				ObjectProperty="CompanyName" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblEmailAddress" AssociatedControlID="tbEmailAddress" Text="Email Address" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbEmailAddress" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davEmailAddress" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbEmailAddress"
				ObjectProperty="EmailAddress" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblContactPhone" AssociatedControlID="tbContactPhone" Text="Contact Phone" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbContactPhone" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davContactPhone" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbContactPhone"
				ObjectProperty="ContactPhone" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblStreetAddress" AssociatedControlID="tbStreetAddress" Text="Street Address" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbStreetAddress" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davStreetAddress" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbStreetAddress"
				ObjectProperty="StreetAddress" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblApartament" AssociatedControlID="tbApartament" Text="Apartament" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbApartament" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davApartament" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbApartament"
				ObjectProperty="Apartament" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblCity" AssociatedControlID="tbCity" Text="City" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbCity" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davCity" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbCity"
				ObjectProperty="City" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblState" AssociatedControlID="tbState" Text="State" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbState" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davState" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbState"
				ObjectProperty="State" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblZip" AssociatedControlID="tbZip" Text="Zip" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbZip" ValidationGroup="ContactInformation" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davZip" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbZip"
				ObjectProperty="Zip" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblComments" AssociatedControlID="tbComments" Text="Comments" runat="server" />
		</td>
		<td>
			<asp:TextBox ID="tbComments" ValidationGroup="ContactInformation" TextMode="MultiLine" runat="server" />
			<dav:DataAnnotationsValidator runat="server" ID="davComments" 
				ValidationGroup="ContactInformation"
				MetadataSourceID="msContactInformation"
				ControlToValidate="tbComments"
				ObjectProperty="Comments" />
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnContactInfoSubmit" Text="Submit" ValidationGroup="ContactInformation" runat="server" />
			<asp:Button ID="btnContactInfoCancel" Text="Cancel" CausesValidation="false" runat="server" />
		</td>
	</tr>
</table>
