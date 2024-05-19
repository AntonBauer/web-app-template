using Microsoft.Extensions.DependencyInjection;
using Template.UseCases.CreateExample.Services;

namespace Template.UseCases.CreateExample.Extensions;

internal static class ServiceCollectionExtensions
{
  public static IServiceCollection AddCreateExample(this IServiceCollection services) =>
    services.AddScoped<CreateExampleService>();
}