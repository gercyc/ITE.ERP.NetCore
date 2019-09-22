using ITSolution.Framework.Server.Core.BaseClasses.Repository;
using ITSolution.Framework.Server.Core.BaseEnums;
using ITSolution.Framework.Server.Core.BaseInterfaces;
using ITSolution.Framework.Servers.Core.CustomerApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITSolution.Framework.Core.CustomUserAPI.Data
{
    /// <summary>
    /// Customize your context
    /// </summary>
    public class CustomerContext : ITSolutionContext
    {
        public CustomerContext() : base(new ITSDbContextOptions())
        {

        }
        public CustomerContext(ITSDbContextOptions itsDbContextOptions) : base(itsDbContextOptions)
        {
            this.ITSDbContextOptions = itsDbContextOptions;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Customer> EntitySet { get; set; }
        public IITSReporitory<Customer, CustomerContext> CustomerRep { get { return new ITSRepository<Customer, CustomerContext>(this); } }
    }
}
