using KhumaloCraft.Data;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KhumaloCraftContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KhumaloCraftContext>>()))
            {
                // Look for any user
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }
                context.User.AddRange(
                    new User
                    {
                        Username = "Carey Wilson",
                        Email = "carry@example.com",
                        Password = "Romantic Comedy",
                        Cellnumber = "082 859 2355"
                    },
                    new User
                    {
                        Username = "Sally Man",
                        Email = "sally@example.com",
                        Password = "Comedy",
                        Cellnumber = "082 528 3891"
                    },
                    new User
                    {
                        Username = "Harry Jobs",
                        Email = "harry@example.com",
                        Password = "Jobless",
                        Cellnumber = "082 789 2561"
                    },
                    new User
                    {
                        Username = "Nick Kidd",
                        Email = "nick@example.com",
                        Password = "Number1",
                        Cellnumber = "082 145 5625"
                    }
                );
                //context.SaveChanges();
                // Look for any user
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                    new Product
                    {
                        Name = "Ocean Artwork",
                        Destination = "Hillcrest, KwaZulu-Natal",
                        Price = 25,
                        
                    },
                    new Product
                    {
                        Name = "View Artwork",
                        Destination = "Balito, KwaZulu-Natal",
                        Price = 25,
                    },
                    new Product
                    {
                        Name = "Hand made shoes",
                        Destination = "Durban North, KwaZulu-Natal",
                        Price = 25,
                    },
                    new Product
                    {
                        Name = "Key Chain",
                        Destination = "Pinetown, KwaZulu-Natal",
                        Price = 25,
                    }
                );
                context.SaveChanges();
            }

        }
    }
}