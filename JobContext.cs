using Microsoft.EntityFrameworkCore;
using ProjectEF.Models;

namespace ProjectEF;

public class JobContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Job> Jobs { get; set; }

    public JobContext(DbContextOptions<JobContext> options) : base(options) { }
}
