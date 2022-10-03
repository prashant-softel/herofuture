using herofuture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace herofuture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        // DGR File Uploads
        public IActionResult DGRFileUpload()
        {
            return View("Uploads/DGRFileUpload");
        }
        // views wind
        public IActionResult WindGenView()
        {
            return View();
        }
        public IActionResult WindDailyTargetKPI()
        {
            return View();
        }
        public IActionResult WindMonthlyTargetKPI()
        {
            return View();
        }
        public IActionResult WindMonthlyLineloss()
        {
            return View();
        }
        public IActionResult WindJMR()
        {
            return View();
        }
        public IActionResult WindDailyLoadShedding()
        {
            return View();
        }
        // view solar
        public IActionResult SolarGenView()
        {
            return View();
        }
        public IActionResult SolarDailyTargetKPI()
        {
            return View();
        }
        public IActionResult SolarMonthlyTargetKPI()
        {
            return View();
        }
        public IActionResult SolarMonthlyLineLoss()
        {
            return View();
        }
        public IActionResult SolarJMR()
        {
            return View();
        }
        public IActionResult Solar_AC_DC_Capacity()
        {
            return View();
        }
        public IActionResult SolarDailyLoadShedding()
        {
            return View();
        }
        // Reports WInd 
        public IActionResult WindReport()
        {
            return View();
        }
        public IActionResult WindBDReport()
        {
            return View();
        }
        public IActionResult WindPRReport()
        {
            return View();
        }
        //Solar Report 
        public IActionResult SolarReport()
        {
            return View();
        }
        public IActionResult SolarBDReport()
        {
            return View();
        }
        public IActionResult SolarPRReport()
        {
            return View();
        }
        // Adminitration
        public IActionResult WindSiteMaster()
        {
            return View("Admin/WindSiteMaster");
        }
        public IActionResult WindLocationMaster()
        {
            return View("Admin/WindLocationMaster");
        }
        public IActionResult SolarSiteMaster()
        {
            return View("Admin/SolarSiteMaster");
        }
        public IActionResult SolarLocationMaster()
        {
            return View();
        }
        public IActionResult WindFileUpload()
        {
            return View("Admin/WindFileUpload");
        }
        public IActionResult SolarFileUpload()
        {
            return View("Admin/SolarFileUpload");
        }
        public IActionResult WindSiteUserMaster()
        {
            return View("Admin/WindSiteUserMaster");
        }
        public IActionResult SolarSiteUserMaster()
        {
            return View("Admin/SolarSiteUserMaster");
        }
        public IActionResult WindDataApproval()
        {
            return View("Admin/WindDataApproval");
        }
        public IActionResult SolarDataApproval()
        {
            return View("Admin/SolarDataApproval");
        }
        public IActionResult WindWeeklyPFReport()
        {
            return View("Admin/WindWeeklyPFReport");
        }
        public IActionResult SolarWeeklyPFReport()
        {
            return View("Admin/SolarWeeklyPFReport");
        }
        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult DataTable()
        {
            return View();
        }
        public IActionResult ChartJS()
        {
            return View();
        }
        public IActionResult FlotCharts()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
