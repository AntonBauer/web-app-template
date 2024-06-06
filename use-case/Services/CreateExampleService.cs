using Template.Domain.Entities.Examples;
using Template.Infrastructure.DataAccess;
using Template.UseCases.CreateExample.Extensions;
using Template.UseCases.CreateExample.Responses;

namespace Template.UseCases.CreateExample.Services;

internal sealed class CreateExampleService(ExampleContext context)
{
  public async Task<Result<CreatedExampleDto>> Create(string name, CancellationToken cancellationToken)
  {
    ExampleEntity.Create(name)
                 .Tap(example => context.Examples.Add(example))
                 .Tap(example => context.SaveChangesAsync(cancellationToken))
                 .Map(example => example.ToCreatedExampleDto());

    context.Examples.Add(exampleResult);
    await context.SaveChangesAsync(cancellationToken);

    return exampleResult.ToCreatedExampleDto();
  }
}