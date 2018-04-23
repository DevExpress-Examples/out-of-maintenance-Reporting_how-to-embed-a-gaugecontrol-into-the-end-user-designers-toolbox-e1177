using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGauges.Win;

namespace WindowsApplication1 {
    public class MyGaugeControl: WinControlContainer {
        GaugeUserControl gauge = new GaugeUserControl();

        public MyGaugeControl() : base() {
            this.WinControl = gauge;
            this.DrawMethod = WinControlDrawMethod.UseWMPaintRecursive;
        }
    }
}
