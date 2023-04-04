namespace backend.Models;
public sealed class ApplicationContext: DbContext
{
    public DbSet<Analys> Analyses { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}