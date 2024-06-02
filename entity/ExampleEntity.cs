using GeneralDomain.UtilityTypes;

namespace Template.Domain.Entities.Examples;

public sealed class ExampleEntity
{
  public ExampleEntityId Id { get; }

  public NonEmptyString Name { get; }

  private ExampleEntity(ExampleEntityId id, NonEmptyString name) => (Id, Name) = (id, name);

  public static Validation<string, ExampleEntity> Create(string name)
  {
    var validatedName = NonEmptyString.Create(name);
    return new(ExampleEntityId.CreateNew(), validatedName.);
  }
}