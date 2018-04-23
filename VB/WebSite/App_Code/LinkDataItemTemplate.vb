Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors
Imports System.Web.UI.WebControls

Public Class LinkDataItemTemplate
	Implements ITemplate
	Private fContainer As Control

	Public Sub New()
	End Sub

	Private ReadOnly Property Container() As GridViewDataItemTemplateContainer
		Get
			Return TryCast(fContainer, GridViewDataItemTemplateContainer)
		End Get
	End Property

	Private Function CreateHyperLink() As Control
		Dim value As Object = DataBinder.Eval(Container.DataItem, Container.Column.FieldName)
		Return New LiteralControl(String.Format("<a id='{1}Alink_{2}_{3}' href='javascript:' onkeydown='LinkKeyPressed(this, event)' style='color: Black; text-decoration: none'>{0}</a>", value, Container.Grid.ID, Container.VisibleIndex, Container.Column.VisibleIndex))
	End Function

	Protected Overridable Sub CreateControls()
		Container.Controls.Add(CreateHyperLink())
	End Sub

	#Region "ITemplate Members"

	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		fContainer = container
		CreateControls()
	End Sub

	#End Region
End Class
