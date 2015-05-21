using WorkShop.Data.Repositories;
using WorkShop.Models;

namespace WorkShop.Data.UnitOfWork
{
    public interface IWorkShopData
    {
        IRepository<User> Users { get; }

        IRepository<Certification> Certifications { get; }

        IRepository<Discussion> Discussions { get; }

        IRepository<Experience> Experiences { get; }

        IRepository<Group> Groups { get; }

        // IRepository<UserLanguage> Languages { get; }

        IRepository<Project> Projects { get; }

        IRepository<Skill> Skills { get; }

        IRepository<Endorsment> Endorsments { get; }

        IRepository<AdministrationLog> AdministrationLogs { get; }

        int SaveChanges();
    }
}
