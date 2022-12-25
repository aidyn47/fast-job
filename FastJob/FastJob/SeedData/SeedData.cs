using Microsoft.EntityFrameworkCore;
using FastJob.Data;

namespace FastJob.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FastJobContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FastJobContext>>()))
            {
                // Look for any movies.
                if (context.Tasks.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tasks.AddRange(
                    new Tasks
                    {
                        Title = "When Harry Met Sally",
                        DeadLine = DateTime.Parse("1989-2-12"),
                        Description = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Tasks
                    {
                        Title = "Ghostbusters ",
                        DeadLine = DateTime.Parse("1984-3-13"),
                        Description = "Comedy",
                        Price = 8.99M
                    },

                    new Tasks
                    {
                        Title = "Ghostbusters 2",
                        DeadLine = DateTime.Parse("1986-2-23"),
                        Description = "Comedy",
                        Price = 9.99M
                    },

                    new Tasks
                    {
                        Title = "Rio Bravo",
                        DeadLine = DateTime.Parse("1959-4-15"),
                        Description = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}