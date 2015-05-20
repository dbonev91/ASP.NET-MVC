using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.Repository;
using Twitter.Model;

namespace Twitter.Data.UnitOfWork
{
    public class TwitterUnitOfWork : ITwitterUnitOfWork
    {
        private readonly DbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        private IUserStore<ApplicationUser> userStore;

        public TwitterUnitOfWork()
            : this(new TwitterDBContext())
        {
        }

        public TwitterUnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<Tweet> Tweets
        {
            get { return this.GetRepository<Tweet>(); }
        }

        public IRepository<Profile> Profiles
        {
            get { return this.GetRepository<Profile>(); }
        }

        public IRepository<Notification> Notifications
        {
            get { return this.GetRepository<Notification>(); }
        }

        public IRepository<Message> Messages
        {
            get { return this.GetRepository<Message>(); }
        }

        public IUserStore<ApplicationUser> UserStore
        {
            get
            {
                if (this.userStore == null)
                {
                    this.userStore = new UserStore<ApplicationUser>(this.dbContext);
                }

                return this.userStore;
            }
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericEfRepository<T>);
                this.repositories.Add(typeof(T), 
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
