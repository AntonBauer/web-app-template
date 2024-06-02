using Microsoft.AspNetCore.Routing;

namespace Template.UseCases;

public static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddUseCases(this IEndpointRouteBuilder app) =>
    app;
}