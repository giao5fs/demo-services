using platform_service.Models;

namespace platform_service.Context
{
    public static class PrepareDataExtension
    {
        public static void DataSeed(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            using (var db = app.Services.CreateScope().ServiceProvider.GetService<AppDbContext>())
            {
                if (!db.Platforms.Any())
                {
                    Console.WriteLine("Seed data..");

                    var plat1 = new Platform { Age = 1, Name = "A" };
                    var plat2 = new Platform { Age = 2, Name = "B" };
                    var plat3 = new Platform { Age = 3, Name = "C" };

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
