Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace CheckboxLegend.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

            Return View()
        End Function

        Public Function ChartPartial() As ActionResult
            Dim model = CreateChartData()
            Return PartialView("_ChartPartial", model)
        End Function

        Private Function CreateChartData() As DataTable

            Dim table As New DataTable("Table1")

            table.Columns.Add("Series", GetType(String))
            table.Columns.Add("Argument", GetType(String))
            table.Columns.Add("Value", GetType(Int32))


            table.Rows.Add(New Object() { "Jan", "Section1", 10 })
            table.Rows.Add(New Object() { "Jan", "Section2", 20 })
            table.Rows.Add(New Object() { "Feb", "Section1", 20 })
            table.Rows.Add(New Object() { "Feb", "Section2", 30 })
            table.Rows.Add(New Object() { "March", "Section1", 15 })
            table.Rows.Add(New Object() { "March", "Section2", 25 })

            Return table
        End Function
    End Class
End Namespace