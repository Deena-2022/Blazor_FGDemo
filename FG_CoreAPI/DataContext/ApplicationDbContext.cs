using FG.DataEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FG_CoreAPI.DataContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<User> tbl_User { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
    }
}
