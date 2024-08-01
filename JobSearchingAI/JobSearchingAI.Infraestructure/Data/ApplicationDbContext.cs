using JobSearchingAI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobSearchingAI.Infraestructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    DbSet<Company> Companies { get; set; }
    DbSet<Job> Jobs { get; set; }
    DbSet<Recommendation> Recommendations { get; set; }
}