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
                .FirstOrDefault(x => x.UserName == username);

            if (user == null)
            {
                return this.HttpNotFound("User doesn't exists!");
            }

            var userViewModel = new UserViewModel()
            {
                FullName = user.FullName,
                Email = user.Email,
                AvatarUrl = user.AvatarUrl,
                Summary = user.Summary,
                Username = user.UserName,
                ContactInfo = user.ContactInfo
            };

            return this.View(userViewModel);
        }
    }
}