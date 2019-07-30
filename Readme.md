<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/CheckboxLegend/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/CheckboxLegend/Controllers/HomeController.vb))
* [_ChartPartial.cshtml](./CS/CheckboxLegend/Views/Home/_ChartPartial.cshtml)
<!-- default file list end -->
# How to preserve the Legend checkbox item state in an ASP.NET MVC application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t504189/)**
<!-- run online end -->


<strong>NOTE. </strong>Starting with v17.1, you can optionally save legend checkbox state for the chart's Series collection on callbacks. To activate this feature, enable the <strong>SaveStateOnCallbacks</strong> option.<br><br>Chart extension does not cache information about the Series item state when the Legend checkbox feature is enabled. In this situation, it is required to handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcChartControlSettings_BoundDataChangedtopic">ChartControlSettings.BoundDataChanged</a> event to restore the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument16242">Legend item checkbox state</a>. This example illustrates how to save the Legend state into a Session variable using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcChartControlSettings_LegendItemCheckedtopic">ChartControlSettings.LegendItemChecked</a> event and then restore it on subsequent page requests.<br><br>See also:<br><br><a href="https://www.devexpress.com/Support/Center/p/T470764">How to preserve the Legend checkbox item state when the Series collection is initialized programmatically</a>;<br><a href="https://www.devexpress.com/Support/Center/p/T470781">How to preserve the Legend checkbox item state when the Series Template approach is used to generate the Series collection</a>.

<br/>


