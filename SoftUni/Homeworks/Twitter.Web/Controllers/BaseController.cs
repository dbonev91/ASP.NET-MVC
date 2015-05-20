using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data.UnitOfWork;

namespace Twitter.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ITwitterUnitOfWork data;

        public BaseController(ITwitterUnitOfWork data)
        {
            this.data = data;
        }

        public BaseController()
        {
            new BaseController();
        }

        protected ITwitterUnitOfWork Data
        {
            get
            {
                return this.data;
            }
        }
    }
}