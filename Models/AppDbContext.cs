using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_MVC_RateBoard.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<RateModelSql> rateModels { get; set; }
        public DbSet<BackScreenRateSql> backScreenRates { get; set; }
        public DbSet<RefreshStatusModel> refreshStausObj { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {

        modelBuilder.Seed();
        }


    }
}
