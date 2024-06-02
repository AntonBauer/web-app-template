using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Template.Infrastructure.DataAccess;

public static class ServiceCollectionExtensions
{
  internal const string ConnectionStringName = "ExampleConnection";

  public static IServiceCollection AddDataAccess(this IServiceCollection services,
                                                 IConfiguration configuration) =>
    services.AddDbContext<ExampleContext>(options =>
      options.UseNpgsql(configuration.GetConnectionString(ConnectionStringName),
                        options => options.MigrationsHistoryTable("ExampleMigrations", "example")));

}