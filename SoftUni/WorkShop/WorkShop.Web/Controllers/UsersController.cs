namespace WorkShop.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using WorkShop.Data.UnitOfWork;
    using WorkShop.Web.ViewModels;

    [Authorize]
    public class UsersController : BaseController
    {
        public UsersController(IWorkShopData data)
            : base(data)
        {
        }

        public ActionResult Index(string username)
        {
            var user = this.Data.Users
                .All()
                .Where(x => x.UserName == username)
                .Select(UserViewModel.ViewModel)
                .FirstOrDefault();

            if (user == null)
            {
                return this.HttpNotFound("User doesn't exists!");
            }

            return this.View(user);
        }
    }
}