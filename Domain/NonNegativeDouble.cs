namespace Template.Domain;

public readonly record struct NonNegativeDouble
{
  public double Value { get; }

  private NonNegativeDouble(double value) => Value = value;

  public static NonNegativeDouble Create(double value) =>
    value >= 0
      ? new(value)
      : throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be non-negative");

  public static implicit operator double(NonNegativeDouble value) => value.Value;
}