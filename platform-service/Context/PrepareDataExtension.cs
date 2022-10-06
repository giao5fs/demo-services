using platform_service.Models;

namespace platform_service.Context
{
    public static class PrepareDataExtension
    {
        public static void DataSeed(IApplicationBuilder builder)
        {
            var scope = builder.ApplicationServices.CreateScope();
            using (var db = scope.ServiceProvider.GetRequiredService<AppDbContext>())
            {
                if (!db.Platforms.Any())
                {
                    System.Console.WriteLine("--> Seeding data..");
                    db.Platforms.AddRange(
                        new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                        new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                        new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" });
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Data existing");
                }
                
            }

                
        }
    }
}
