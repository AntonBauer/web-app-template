namespace Template.Domain.Entities.Examples;

public sealed class ExampleEntity
{
  public ExampleEntityId Id { get; }

  public NonEmptyString Name { get; }

  private ExampleEntity(ExampleEntityId id, NonEmptyString name) => (Id, Name) = (id, name);

  public static ExampleEntity Create(string name) =>
    new(ExampleEntityId.Create(), NonEmptyString.CreateFrom(name));
}