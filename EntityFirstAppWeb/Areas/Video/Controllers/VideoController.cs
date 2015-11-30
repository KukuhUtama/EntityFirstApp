using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFirstAppWeb.Areas.Video.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video/Video
        public ActionResult Index()
        {
            return View();
        }
    }
}