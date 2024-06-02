namespace Template.UseCases.CreateExample.Responses;

internal readonly record struct CreatedExampleDto
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}