using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data.UnitOfWork;

namespace Twitter.Web.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(ITwitterUnitOfWork iTwitterUnitOfWork)
            : base(iTwitterUnitOfWork)
        {
        }

        public HomeController()
            : this(new TwitterUnitOfWork())
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}