using Microsoft.EntityFrameworkCore;
using TryProject.Data;
using TryProject.Models;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace TryProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TryProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TryProjectContext>>()))
            {
                // Look for any movies.
                if (context.Job.Any())
                {
                    return;   // DB has been seeded
                }
                context.Job.AddRange(
                    new Job
                    {
                        Name = "Job1"
                    },
                    new Job
                    {
                        Name="job2"
                    },
                    new Job
                    {
                        Name="job3"
                });
            }
        }
    }
}
