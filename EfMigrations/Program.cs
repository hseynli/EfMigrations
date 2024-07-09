using EfMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

using ApplicationContext db = new ApplicationContext();
//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();

// Will aplly all non-applied migrations
await db.Database.MigrateAsync();

//User user = new User { Name = "John" };
//db.Users.Add(user);
//db.SaveChanges();

Console.WriteLine("\nDone!");