using BeHealthy.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeHealthy.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDataModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WeightDataModel> WeightDatas { get; set; }
        public DbSet<WeightHistoryDataModel> WeightHistoryDatas { get; set;}
    }
}