using AzureDeployment.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AzureDeployment.Data;

public class MediumDbContext : DbContext
{
    public MediumDbContext()
    {

    }
    public MediumDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer("");
}
