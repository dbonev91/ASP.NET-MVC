using System;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkShop.Data.Repositories;
using WorkShop.Models;

namespace WorkShop.Data.UnitOfWork
{
    public class WorkShopData : IWorkShopData
    {
        private readonly IWorkShopDbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        public WorkShopData(IWorkShopDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Certification> Certifications
        {
            get { return this.GetRepository<Certification>(); }
        }

        public IRepository<Discussion> Discussions
        {
            get { return this.GetRepository<Discussion>(); }
        }

        public IRepository<Experience> Experiences
        {
            get { return this.GetRepository<Experience>(); }
        }

        public IRepository<Group> Groups
        {
            get { return this.GetRepository<Group>(); }
        }

        public IRepository<Project> Projects
        {
            get { return this.GetRepository<Project>(); }
        }

        public IRepository<Skill> Skills
        {
            get { return this.GetRepository<Skill>(); }
        }

        public IRepository<Endorsment> Endorsments
        {
            get { return this.GetRepository<Endorsment>(); }
        }

        public IRepository<AdministrationLog> AdministrationLogs
        {
            get { return this.GetRepository<AdministrationLog>(); }
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof (T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);



                var repository = Activator.CreateInstance(typeOfRepository, this.dbContext);
                this.repositories.Add(typeof(T), repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}