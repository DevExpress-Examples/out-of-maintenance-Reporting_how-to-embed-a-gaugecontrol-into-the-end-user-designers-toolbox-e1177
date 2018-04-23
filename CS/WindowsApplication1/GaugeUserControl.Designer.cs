namespace WindowsApplication1 {
    partial class GaugeUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(259, 249);
            this.gaugeControl1.TabIndex = 0;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 247, 237);
            this.circularGauge1.Name = "cGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1,
            this.arcScaleComponent2});
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -5F;
            this.arcScaleComponent1.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F);
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -17F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -2.5F;
            this.arcScaleComponent1.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F);
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.RadiusX = 107F;
            this.arcScaleComponent1.RadiusY = 107F;
            this.arcScaleComponent1.StartAngle = -240F;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent2.EndAngle = -30F;
            this.arcScaleComponent2.MajorTickCount = 8;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2;
            this.arcScaleComponent2.MajorTickmark.TextOffset = -15F;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 700F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1;
            this.arcScaleComponent2.Name = "scale2";
            this.arcScaleComponent2.RadiusX = 70F;
            this.arcScaleComponent2.RadiusY = 70F;
            this.arcScaleComponent2.StartAngle = -240F;
            this.arcScaleComponent2.ZOrder = -1;
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg1";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 5F;
            this.arcScaleNeedleComponent1.Name = "needle1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11;
            this.arcScaleNeedleComponent1.StartOffset = -9.5F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // GaugeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gaugeControl1);
            this.Name = "GaugeUserControl";
            this.Size = new System.Drawing.Size(259, 249);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
    }
}
