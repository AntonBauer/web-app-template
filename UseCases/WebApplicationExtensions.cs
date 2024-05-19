using Microsoft.AspNetCore.Routing;
using Template.UseCases.CreateExample.Extensions;

namespace CounterMonitor.UseCases;

public static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddUseCases(this IEndpointRouteBuilder app) =>
    app.AddCreateExample();
}