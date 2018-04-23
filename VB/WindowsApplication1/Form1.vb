Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
Imports System.Drawing.Design

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new End-User Designer.
			Dim designForm As New XRDesignFormEx()

			' Handle the event when the report is loaded into the End-User Designer.
			AddHandler designForm.DesignPanel.DesignerHostLoaded, AddressOf OnDesignerLoaded

			' Load the report into the designer. 
			designForm.OpenReport(New SampleReport())

			' Show the End-User Designer window.
			designForm.ShowDialog()

		End Sub

		Private Sub OnDesignerLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			Dim ts As IToolboxService = CType(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)

			' Add a custom control.
			ts.AddToolboxItem(New ToolboxItem(GetType(MyGaugeControl)))
		End Sub

	End Class
End Namespace