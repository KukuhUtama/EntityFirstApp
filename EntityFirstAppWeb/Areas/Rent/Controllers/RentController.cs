using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFirstAppWeb.Areas.Rent.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent/Rent
        public ActionResult Index()
        {
            return View();
        }
    }
}