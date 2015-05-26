using System;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using WorkShop.Models;

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
                .Include(x => x.Skills)
                .Include(x => x.Certifications)
                .Include(x => x.ContactInfo)
                .Include("Skills.Skill")
                .Include("Skills.Skill.User")
                .Where(x => x.UserName == username)
                .Select(UserViewModel.ViewModel)
                .FirstOrDefault();

            if (user == null)
            {
                return this.HttpNotFound("User doesn't exists!");
            }

            return this.View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EndorceUser(int id)
        {
            // TODO: Optimize queries!
            var hasExistingEndorcement =
                this.Data.Endorsments
                    .All()
                    .Any(x => x.UserId == this.UserProfile.Id &&
                              x.UserSkillId == id);
            if (!hasExistingEndorcement)
            {
                this.Data.Endorsments.Add(new Endorsment
                {
                    UserId = this.UserProfile.Id,
                    UserSkillId = id
                });

                this.Data.SaveChanges();
            }
            
            var endorcements =
                this.Data.Endorsments
                    .All()
                    .Where(x => x.UserSkillId == id);
            var endorcementsCount = endorcements.Count();
            var endorcers = endorcements.Select(x => x.User.UserName).ToList();

            return this.Content(String.Format("{0} ({1})", endorcementsCount, string.Join(", ", endorcers)));
        }
    }
}