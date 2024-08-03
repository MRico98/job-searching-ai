using JobSearchingAI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobSearchingAI.Infraestructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Recommendation> Recommendations { get; set; }
}