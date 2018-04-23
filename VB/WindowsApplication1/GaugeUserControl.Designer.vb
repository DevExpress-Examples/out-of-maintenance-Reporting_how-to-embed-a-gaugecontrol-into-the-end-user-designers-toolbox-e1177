Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class GaugeUserControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(259, 249)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 247, 237)
			Me.circularGauge1.Name = "cGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1, Me.arcScaleComponent2})
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 12F)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -5F
			Me.arcScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -17F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -2.5F
			Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
			Me.arcScaleComponent1.Name = "scale1"
			Me.arcScaleComponent1.RadiusX = 107F
			Me.arcScaleComponent1.RadiusY = 107F
			Me.arcScaleComponent1.StartAngle = -240F
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold)
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent2.EndAngle = -30F
			Me.arcScaleComponent2.MajorTickCount = 8
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2
			Me.arcScaleComponent2.MajorTickmark.TextOffset = -15F
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 700F
			Me.arcScaleComponent2.MinorTickCount = 4
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1
			Me.arcScaleComponent2.Name = "scale2"
			Me.arcScaleComponent2.RadiusX = 70F
			Me.arcScaleComponent2.RadiusY = 70F
			Me.arcScaleComponent2.StartAngle = -240F
			Me.arcScaleComponent2.ZOrder = -1
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg1"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = 5F
			Me.arcScaleNeedleComponent1.Name = "needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
			Me.arcScaleNeedleComponent1.StartOffset = -9.5F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' GaugeUserControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "GaugeUserControl"
			Me.Size = New System.Drawing.Size(259, 249)
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
	End Class
End Namespace
