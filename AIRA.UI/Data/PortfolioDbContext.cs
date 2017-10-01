using AIRA.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Data
{
    public class PortfolioDbContext : DbContext, IPortfolioDbContext
    {
        public PortfolioDbContext() : base()
        {

        }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioReview> Reviews { get; set; }
        //public DbSet<Equity> Equities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.HasDefaultSchema("Portfolio");
        }
        

        void IPortfolioDbContext.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }

        IQueryable<T> IPortfolioDbContext.Query<T>()
        {
            return Set<T>();
        }

        void IPortfolioDbContext.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }

        void IPortfolioDbContext.SaveChanges()
        {
            SaveChanges();
        }

        void IPortfolioDbContext.Update<T>(T entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }

    internal interface IPortfolioDbContext : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        void SaveChanges();
    }
}
