Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Collections
Imports DevExpress.Xpf.Grid
' ...

Namespace WpfApplication1

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New ArrayList()
			list.Add(New Point() With {.X = 1, .Y = 11})
			list.Add(New Point() With {.X = 2, .Y = 12})
			list.Add(New Point() With {.X = 3, .Y = 13})
			gridControl1.DataSource = list
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.ExpandAllGroups()
		End Sub
		Private Sub button4_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.CollapseAllGroups()
		End Sub
	End Class
End Namespace
