<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1177)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [MyGaugeControl.cs](./CS/WindowsApplication1/MyGaugeControl.cs) (VB: [MyGaugeControl.vb](./VB/WindowsApplication1/MyGaugeControl.vb))
<!-- default file list end -->
# How to embed a GaugeControl into the End-User Designer's toolbox


<p>In v2008 vol 3 of the Suite, there's no native XRGauge control available. So, there's no direct method to add the GaugeControl to the EUD Toolbox. This example illustrates the capability to display an UserControl that contains a GaugeControl via the WinControlContainer's descendant control. The custom XRControl can be embedded into the EUD toolbox using the IToolboxService.AddToolboxItem method.</p>

<br/>


