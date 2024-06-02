using Microsoft.EntityFrameworkCore;
using Template.Infrastructure.DataAccess;

namespace Template.Api;

internal static class WebApplicationExtensions
{
  public static async Task MigrateDatabase(this WebApplication webApplication)
  {
    using var scope = webApplication.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<ExampleContext>();

    await db.Database.MigrateAsync();
  }
}