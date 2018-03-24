<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RangesEdit.ascx.cs" Inherits="DAValidation.Sample.UserControls.RangesEdit" %>
<%@ Import Namespace="DAValidation.Sample.Entities" %>

<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>

<dav:MetadataSource runat="server" ID="msRangesModel" ObjectType="<%$ Code: typeof(RangesModel) %>" />
<table style="max-width: 600px">
	<tr>
		<td>
			<asp:Label runat="server" Text="IntRange"></asp:Label>
		</td>
		<td>
			<asp:TextBox runat="server" ID="tbIntRange"></asp:TextBox>
			<dav:DataAnnotationsValidator runat="server" ID="davIntRange"
				ControlToValidate="tbIntRange"
				MetadataSourceID="msRangesModel"
				ObjectProperty="IntRange" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label runat="server" Text="DoubleRange"></asp:Label>
		</td>
		<td>
			<asp:TextBox runat="server" ID="tbDoubleRange"></asp:TextBox>
			<dav:DataAnnotationsValidator runat="server" ID="davDoubleRange"
				ControlToValidate="tbDoubleRange"
				MetadataSourceID="msRangesModel"
				ObjectProperty="DoubleRange" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label runat="server" Text="DateRange"></asp:Label>
		</td>
		<td>
			<asp:TextBox runat="server" ID="tbDateRange"></asp:TextBox>
			<dav:DataAnnotationsValidator runat="server" ID="davDateRange"
				ControlToValidate="tbDateRange"
				MetadataSourceID="msRangesModel"
				ObjectProperty="DateRange" />
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label runat="server" Text="NullableIntRange"></asp:Label>
		</td>
		<td>
			<asp:TextBox runat="server" ID="tbNullableIntRange"></asp:TextBox>
			<dav:DataAnnotationsValidator runat="server" ID="davNullableIntRange"
				ControlToValidate="tbNullableIntRange"
				MetadataSourceID="msRangesModel"
				ObjectProperty="NullableIntRange" />
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnRangesEditSubmit" Text="Submit" runat="server" />
			<asp:Button ID="btnRangesEditCancel" Text="Cancel" CausesValidation="false" runat="server" />
		</td>
	</tr>
</table>
