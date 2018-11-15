<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [MyGaugeControl.cs](./CS/WindowsApplication1/MyGaugeControl.cs) (VB: [MyGaugeControl.vb](./VB/WindowsApplication1/MyGaugeControl.vb))
<!-- default file list end -->
# How to embed a GaugeControl into the End-User Designer's toolbox


<p>In v2008 vol 3 of the Suite, there's no native XRGauge control available. So, there's no direct method to add the GaugeControl to the EUD Toolbox. This example illustrates the capability to display an UserControl that contains a GaugeControl via the WinControlContainer's descendant control. The custom XRControl can be embedded into the EUD toolbox using the IToolboxService.AddToolboxItem method.</p>

<br/>


