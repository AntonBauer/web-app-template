using Template.Domain.Entities.Examples;
using Template.Infrastructure.DataAccess;
using Template.UseCases.CreateExample.Extensions;
using Template.UseCases.CreateExample.Responses;

namespace Template.UseCases.CreateExample.Services;

internal sealed class CreateExampleService(ExampleContext context)
{
  public async Task<CreatedExampleDto> Create(string name, CancellationToken cancellationToken)
  {
    var counter = ExampleEntity.Create(name);

    context.Examples.Add(counter);
    await context.SaveChangesAsync(cancellationToken);

    return counter.ToCreatedExampleDto();
  }
}