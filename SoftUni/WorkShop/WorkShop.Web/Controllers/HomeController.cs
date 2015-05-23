namespace WorkShop.Web.Controllers
{
    using System.Web.Mvc;
    using WorkShop.Data.UnitOfWork;
    using System.Web.Mvc.Expressions;

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

            return this.RedirectToAction(x => x.Contact());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}