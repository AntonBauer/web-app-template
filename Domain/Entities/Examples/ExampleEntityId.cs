namespace Template.Domain.Entities.Examples;

public readonly record struct ExampleEntityId
{
    public Guid Value { get; }

    public static ExampleEntityId Empty { get; } = new(Guid.Empty);

    private ExampleEntityId(Guid value) => Value = value;

    public static ExampleEntityId Create() => new(Guid.NewGuid());

    public static ExampleEntityId CreateFrom(Guid value) => new(value);

    public static implicit operator Guid(ExampleEntityId id) => id.Value;

    override public string ToString() => Value.ToString();
}