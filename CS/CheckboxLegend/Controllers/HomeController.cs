using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace CheckboxLegend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View();
        }

        public ActionResult ChartPartial()
        {
            var model = CreateChartData();
            return PartialView("_ChartPartial", model);
        }

        private DataTable CreateChartData()
        {

            DataTable table = new DataTable("Table1");

            table.Columns.Add("Series", typeof(String));
            table.Columns.Add("Argument", typeof(String));
            table.Columns.Add("Value", typeof(Int32));


            table.Rows.Add(new object[] { "Jan", "Section1", 10 });
            table.Rows.Add(new object[] { "Jan", "Section2", 20 });
            table.Rows.Add(new object[] { "Feb", "Section1", 20 });
            table.Rows.Add(new object[] { "Feb", "Section2", 30 });
            table.Rows.Add(new object[] { "March", "Section1", 15 });
            table.Rows.Add(new object[] { "March", "Section2", 25 });

            return table;
        }
    }
}