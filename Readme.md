<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572410/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T504189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/CheckboxLegend/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/CheckboxLegend/Controllers/HomeController.vb))
* [_ChartPartial.cshtml](./CS/CheckboxLegend/Views/Home/_ChartPartial.cshtml)
<!-- default file list end -->
# How to preserve the Legend checkbox item state in an ASP.NET MVC application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t504189/)**
<!-- run online end -->


<strong>NOTE. </strong>Starting with v17.1, you can optionally save legend checkbox state for the chart's Series collection on callbacks. To activate this feature, enable the <strong>SaveStateOnCallbacks</strong> option and configure the [ChartControlSettings.CallbackRouteValues](https://docs.devexpress.com/AspNet/DevExpress.Web.Mvc.ChartControlSettings.CallbackRouteValues) property.

*Applicable to v16.2 and earlier versions*<br>Chart extension does not cache information about the Series item state when the Legend checkbox feature is enabled. In this situation, it is required to handle the [ChartControlSettings.BoundDataChanged](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.ChartControlSettings.BoundDataChanged) event to restore the [Legend item checkbox state](https://docs.devexpress.com/AspNet/15999/components/chart-control/concepts/chart-elements/legend/legend-overview#legend-items). This example illustrates how to save the Legend state into a Session variable using the [ChartControlSettings.LegendItemChecked](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.ChartControlSettings.LegendItemChecked) event and then restore it on subsequent page requests.
