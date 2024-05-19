using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Template.UseCases.CreateExample.Requests;
using Template.UseCases.CreateExample.Services;

namespace Template.UseCases.CreateExample.Extensions;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddCreateExample(this IEndpointRouteBuilder app)
  {
    app.MapPost("api/examples",
                async ([FromBody] CreateExampleRequest request,
                       [FromServices] CreateExampleService service,
                       CancellationToken cancellationToken) => await service.Create(request.Name, cancellationToken));

    return app;
  }
}