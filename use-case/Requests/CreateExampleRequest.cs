namespace Template.UseCases.CreateExample.Requests;

internal readonly record struct CreateExampleRequest
{
  public required string Name { get; init; }
}