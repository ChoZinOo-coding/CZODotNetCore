using CZODotNetCore.MvcChartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CZODotNetCore.MvcChartApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            PieChartModel model = new PieChartModel();
            model.Lables = new List<string>() { "Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int> { 44, 55, 13, 43, 22 };

            return View(model);
        }


        public IActionResult RadialBarCustomAngleCircleChart()
        {
            RadialBarCustomAngleCircleChartModel model = new RadialBarCustomAngleCircleChartModel();
            model.RadialBarSeries = new List<int> { 76, 67, 61, 90 };
            model.RadialBarLabels = new List<string> { "Vimeo", "Messenger", "Facebook", "LinkedIn" };
            model.RadialBarColors = new List<string> { "#1ab7ea", "#0084ff", "#39539E", "#0077B5" };

            return View(model);
        }
    }
}