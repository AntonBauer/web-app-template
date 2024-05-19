using Microsoft.EntityFrameworkCore;
using Template.Domain.Entities.Examples;

namespace Template.Infrastructure.DataAccess;

public sealed class ExampleContext(DbContextOptions<ExampleContext> options) : DbContext(options)
{
  public DbSet<ExampleEntity> Examples => Set<ExampleEntity>();

  protected override void OnModelCreating(ModelBuilder modelBuilder) =>
  modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleContext).Assembly)
              .HasDefaultSchema("monitor");
}