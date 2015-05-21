namespace WorkShop.Web.Controllers
{
    using System.Web.Mvc;
    using WorkShop.Data.UnitOfWork;

    public class HomeController : BaseController
    {
        public HomeController(IWorkShopData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
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