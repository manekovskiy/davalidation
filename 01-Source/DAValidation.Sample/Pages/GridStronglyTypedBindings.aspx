<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridStronglyTypedBindings.aspx.cs" Inherits="DAValidation.Sample.Pages.GridStronglyTypedBindings" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<%@ Register TagPrefix="dav" Namespace="DAValidation" Assembly="DAValidation" %>

<asp:Content ContentPlaceHolderID="cphRight" runat="server">
	<asp:ValidationSummary runat="server" />
	
	<asp:Label runat="server" ID="lblUpdateState" />
	<asp:GridView runat="server" ID="gvCustomers"
		AutoGenerateEditButton="True"
		AutoGenerateColumns="False"
		SelectMethod="GetProducts"
		UpdateMethod="UpdateProducts"
		OnRowEditing="OnRowEditing"
		OnRowUpdating="OnRowUpdating"
		OnRowCancelingEdit="OnRowCancelingEdit"
		ItemType="DAValidation.Sample.Entities.Product">
			<Columns>
				<asp:TemplateField HeaderText="Code">
					<ItemTemplate>
						<asp:Label runat="server" ID="lblId" Text='<%# Item.Id %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbId" runat="server" Text='<%# BindItem.Id %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davId"
							Text="*"
							ControlToValidate="tbId"
							ObjectProperty="Id"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Product Name" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblName" Text='<%# Item.Name %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbName" runat="server" Text='<%# BindItem.Name %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davName"
							Text="*"
							ControlToValidate="tbName"
							ObjectProperty="Name"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Price" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblPrice" Text='<%# Item.Price.ToString("C") %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbPrice" runat="server" Text='<%# BindItem.Price %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davPrice"
							Text="*"
							ControlToValidate="tbPrice"
							ObjectProperty="Price"/>
					</EditItemTemplate>	
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Amount" >
					<ItemTemplate>
						<asp:Label runat="server" ID="lblAmount" Text='<%# Item.Amount %>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbAmount" runat="server" Text='<%# BindItem.Amount %>'></asp:TextBox>
						<dav:DataAnnotationsValidator runat="server" ID="davAmount"
							Text="*"
							ControlToValidate="tbAmount"
							ObjectProperty="Amount"/>
					</EditItemTemplate>	
				</asp:TemplateField>
			</Columns>
	</asp:GridView>
</asp:Content>