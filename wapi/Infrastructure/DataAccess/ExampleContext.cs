using Microsoft.EntityFrameworkCore;

namespace Template.Infrastructure.DataAccess;

public sealed class ExampleContext(DbContextOptions<ExampleContext> options) : DbContext(options)
{
  protected override void OnModelCreating(ModelBuilder modelBuilder) =>
  modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleContext).Assembly)
              .HasDefaultSchema("monitor");
}