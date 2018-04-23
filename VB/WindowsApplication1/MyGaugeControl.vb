Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGauges.Win

Namespace WindowsApplication1
	Public Class MyGaugeControl
		Inherits WinControlContainer
		Private gauge As New GaugeUserControl()

		Public Sub New()
			MyBase.New()
			Me.WinControl = gauge
			Me.DrawMethod = WinControlDrawMethod.UseWMPaintRecursive

		End Sub

	End Class
End Namespace
