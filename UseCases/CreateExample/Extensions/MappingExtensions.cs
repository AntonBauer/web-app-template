using Template.Domain.Entities.Examples;
using Template.UseCases.CreateExample.Responses;

namespace Template.UseCases.CreateExample.Extensions;

internal static class MappingExtensions
{
  public static CreatedExampleDto ToCreatedExampleDto(this ExampleEntity counter) =>
    new()
    {
      Id = counter.Id,
      Name = counter.Name
    };
}