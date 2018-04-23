using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;
using System.Drawing.Design;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new End-User Designer.
            XRDesignFormEx designForm = new XRDesignFormEx();

            // Handle the event when the report is loaded into the End-User Designer.
            designForm.DesignPanel.DesignerHostLoaded += new DesignerLoadedEventHandler(OnDesignerLoaded);

            // Load the report into the designer. 
            designForm.OpenReport(new SampleReport());

            // Show the End-User Designer window.
            designForm.ShowDialog();

        }

        private void OnDesignerLoaded(object sender, DesignerLoadedEventArgs e) {
            IToolboxService ts = (IToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));

            // Add a custom control.
            ts.AddToolboxItem(new ToolboxItem(typeof(MyGaugeControl)));
        }

    }
}