using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Template.UseCases;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddUseCases(this IServiceCollection services,
                                               IConfiguration configuration) =>
    services.AddDataAccess(configuration);
}