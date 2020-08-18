<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>

	<script type="text/javascript">
		function LinkKeyPressed(s, e) {
			var nameParams = s.id.split('_');
			var idBase = nameParams[0];
			var rowIndex = parseInt(nameParams[1]);
			var colIndex = parseInt(nameParams[2]);
			if (e.keyCode == 38) //Up arrow
				rowIndex--;
			if (e.keyCode == 40) //Down arrow
				rowIndex++;
			if (e.keyCode == 37) //Left arrow
				colIndex--;
			if (e.keyCode == 39) //Right arrow
				colIndex++;

			var nextLink = document.getElementById(idBase + "_" + rowIndex + "_" + colIndex);
			if (nextLink != null)
				nextLink.focus();
		}
	</script>

</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxGridView ID="gvData" runat="server" AccessibilityCompliant="True" AutoGenerateColumns="False"
			DataSourceID="dsProducts" KeyFieldName="ProductID" KeyboardSupport="True" OnDataBound="gvData_DataBound">
			<Columns>
				<dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0">
					<EditFormSettings Visible="False" />
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="CategoryID" VisibleIndex="2">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="3">
				</dx:GridViewDataTextColumn>
			</Columns>
		</dx:ASPxGridView>
		<asp:AccessDataSource ID="dsProducts" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT [ProductID], [ProductName], [CategoryID], [UnitPrice] FROM [Products]">
		</asp:AccessDataSource>
	</div>
	</form>
</body>
</html>