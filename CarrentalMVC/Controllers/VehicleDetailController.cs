using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarrentalMVC.Controllers
{
    public class VehicleDetailController : Controller
    {
        // GET: VehicleDetail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddVehicle()
        {
            return View();
        }
    }
}