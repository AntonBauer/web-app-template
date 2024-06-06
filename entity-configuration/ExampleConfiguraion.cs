using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain;
using Template.Domain.Entities.Examples;

namespace Template.Infrastructure.DataAccess.EntityConfigurations;

internal sealed class ExampleEntityConfiguration : IEntityTypeConfiguration<Example>
{
  public void Configure(EntityTypeBuilder<ExampleEntity> builder)
  {
    builder.ToTable("Examples");

    builder.HasKey(example => example.Id);

    builder.Property(example => example.Id)
           .HasConversion(id => id.Value, value => ExampleEntityId.CreateFrom(value));

    builder.Property(example => example.Name)
           .IsRequired()
           .HasConversion(name => name.Value, value => NonEmptyString.Create(value).Value);
  }
}