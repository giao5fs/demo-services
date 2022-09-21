namespace platform_service.Models
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext context;

        public PlatformRepo(AppDbContext context)
        {
            this.context = context;
        }
        public Platform CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                return null;
            }
            context.Platforms.Add(platform);
            context.SaveChanges();
            return platform;
        }

        public IEnumerable<Platform> GetAll()
        {
            return context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return context.Platforms.FirstOrDefault(p => p.Id == id);
        }
    }   
}
