using GeneralDomain.Entities;

namespace Template.Domain.Entities.Examples;

public readonly record struct ExampleEntityId : Id<Guid>
{
    private ExampleEntityId(Guid value) : base(value);

    public static ExampleEntityId CreateNew() => new(Guid.NewGuid());

    public static ExampleEntityId CreateFrom(Guid value) => new(value);
}