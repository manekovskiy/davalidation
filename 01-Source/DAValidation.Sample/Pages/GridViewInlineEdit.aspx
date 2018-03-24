<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewInlineEdit.aspx.cs" Inherits="DAValidation.Sample.Pages.GridViewInlineEdit" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>
<%@ Import Namespace="DAValidation.Sample.Entities" %>


<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<dav:MetadataSource runat="server" ID="mdsProduct" ObjectType="<%$ Code: typeof(Product) %>" />
	
	<asp:ValidationSummary runat="server" />
	
	<asp:Label runat="server" ID="lblUpdateState" />
	<asp:GridView runat="server" ID="gvCustomers" 
		AutoGenerateEditButton="True"
		AutoGenerateColumns="False"
		OnRowEditing="OnRowEditing"
		OnRowUpdating="OnRowUpdating"
		OnRowCancelingEdit="OnRowCancelingEdit">
			<Columns>
				<asp:TemplateField HeaderText="Code">
					<ItemTemplate>
						<asp:Label runat="server" ID="lblId" Text='<%# Eval("Id") %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbId" runat="server" Text='<%# Bind("Id") %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davId"
							Text="*"
							ControlToValidate="tbId"
							MetadataSourceID="mdsProduct"
							ObjectProperty="Id"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Product Name" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblName" Text='<%# Eval("Name") %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davName"
							Text="*"
							ControlToValidate="tbName"
							MetadataSourceID="mdsProduct"
							ObjectProperty="Name"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Price" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblPrice" Text='<%# Eval("Price", "$ {0}") %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbPrice" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davPrice"
							Text="*"
							ControlToValidate="tbPrice"
							MetadataSourceID="mdsProduct"
							ObjectProperty="Price"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Amount" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblAmount" Text='<%# Eval("Amount") %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbAmount" runat="server" Text='<%# Bind("Amount") %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davAmount"
							Text="*"
							ControlToValidate="tbAmount"
							MetadataSourceID="mdsProduct"
							ObjectProperty="Amount"/>
					</EditItemTemplate>	
				</asp:TemplateField>
			</Columns>
	</asp:GridView>
</asp:Content>