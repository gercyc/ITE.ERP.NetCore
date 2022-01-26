using ITSolution.Framework.Server.Core.BaseClasses.Repository;
using ITSolution.Framework.Server.Core.BaseEnums;
using ITSolution.Framework.Server.Core.BaseInterfaces;
using ApiMenu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ITSolution.Framework.Core.Server.BaseClasses.Repository;

namespace ITSolution.Framework.Core.CustomUserAPI.Data
{
    /// <summary>
    /// Customize your context
    /// </summary>
    public class DBAccessContext : ItSolutionBaseContext
    {

        public DBAccessContext(ItsDbContextOptions itsDbContextOptions) : base(itsDbContextOptions)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ItsMenu>()
                        .ToTable("ITS_MENU", "dbo");
        }

        public DbSet<ItsMenu> MenuSet { get; set; }
        public IITSReporitory<ItsMenu, DBAccessContext> MenuRep { get { return new ITSRepository<ItsMenu, DBAccessContext>(this); } }
    }
}
