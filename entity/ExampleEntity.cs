using Generaldomain.Entities;
using GeneralDomain.UtilityTypes;

namespace Template.Domain.Entities.Examples;

public sealed class ExampleEntity : Entity<ExampleEntityId, Guid>
{
  public NonEmptyString Name { get; }

  private ExampleEntity(ExampleEntityId id, NonEmptyString name):base(id) =>
    Name = name;

  public static Result<ExampleEntity> Create(string name) =>
    NonEmptyString.Create(name)
                  .Map(validatedName => new(ExampleEntityId.CreateNew(), validatedName));
}