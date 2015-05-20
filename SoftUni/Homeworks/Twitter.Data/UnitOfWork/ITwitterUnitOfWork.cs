using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.Repository;
using Twitter.Model;

namespace Twitter.Data.UnitOfWork
{
    public interface ITwitterUnitOfWork
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Tweet> Tweets { get; }

        IRepository<Profile> Profiles { get; }

        IRepository<Notification> Notifications { get; }

        IRepository<Message> Messages { get; }

        void SaveChanges();
    }
}
