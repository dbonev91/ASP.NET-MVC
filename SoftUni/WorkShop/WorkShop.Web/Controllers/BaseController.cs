using System;
using System.Linq;
using System.Web.Routing;
using Microsoft.Owin.Security.Provider;

namespace WorkShop.Web.Controllers
{
    using System.Web.Mvc;
    using Data;
    using WorkShop.Data.UnitOfWork;
    using WorkShop.Models;

    public abstract class BaseController : Controller
    {
        private IWorkShopData data;
        private User userProfile;

        protected BaseController(IWorkShopData data)
        {
            this.data = data;
        }

        protected BaseController(IWorkShopData data, User userProfile)
            :this(data)
        {
            this.userProfile = userProfile;
        }

        protected IWorkShopData Data
        {
            get { return this.data; }
            private set { this.data = value; }
        }

        protected User UserProfile
        {
            get { return this.userProfile; }
            private set { this.userProfile = value; }
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All().FirstOrDefault(x => x.UserName == username);
                this.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}