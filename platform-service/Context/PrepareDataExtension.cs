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
                    Console.WriteLine("Seed data..");

                    var plat1 = new Platform { PlatformName = "CASA", Cost = "Free" };
                    var plat2 = new Platform { PlatformName = "BASA", Cost = "Free" };
                    var plat3 = new Platform { PlatformName = "DASA", Cost = "Free" };

                    db.Platforms.Add(plat1);
                    db.Platforms.Add(plat2);
                    db.Platforms.Add(plat3);
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
