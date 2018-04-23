Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView
Imports System.Data

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub gvData_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim gridView As ASPxGridView = TryCast(sender, ASPxGridView)

		For Each column As GridViewDataColumn In gridView.Columns
			column.DataItemTemplate = New LinkDataItemTemplate()
		Next column
	End Sub
End Class
