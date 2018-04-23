Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace ColumnHeaderImage
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = New ProductList()
		End Sub
	End Class
End Namespace
