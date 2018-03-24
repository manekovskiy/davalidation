<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodeViewer.ascx.cs" Inherits="DAValidation.Sample.UserControls.CodeViewer" %>
<%@ Import Namespace="DAValidation.Sample.UserControls" %>

<ul>
	<asp:Repeater runat="server" ID="rpCodeFilesTabs">
		<ItemTemplate>
			<li>
				<a href="#tab-<%# CodeViewerHelper.GetFileNameWithoutExtension(Convert.ToString(Container.DataItem)) %>">
					<%# CodeViewerHelper.GetFileName(Convert.ToString(Container.DataItem)) %>
				</a>
			</li>
		</ItemTemplate>
	</asp:Repeater>
</ul>
<asp:Repeater runat="server" ID="rpCodeFilesContent">
	<ItemTemplate>
		<div id="tab-<%# CodeViewerHelper.GetFileNameWithoutExtension(Convert.ToString(Container.DataItem)) %>">
			<pre class="brush: <%# CodeViewerHelper.GetBrushNameForFile(Convert.ToString(Container.DataItem)) %>; ruler: true;"><%# CodeViewerHelper.RenderFileContents(Convert.ToString(Container.DataItem)) %></pre>
		</div>
	</ItemTemplate>
</asp:Repeater>