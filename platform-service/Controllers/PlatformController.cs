using Microsoft.AspNetCore.Mvc;
using platform_service.Models;

namespace platform_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController: ControllerBase
    {
        private readonly IPlatformRepo platform;

        public PlatformController(IPlatformRepo platform)
        {
            this.platform = platform;
        }
        [HttpGet]
        public IActionResult GetAllPlatform()
        {
            var res =  platform.GetAll();
            return Ok(res); 
        }
        [HttpGet]
        [Route("/{Id}")]
        public IActionResult GetById(int id)
        {
            var res = platform.GetPlatformById(id);
            return Ok(res);
        }
    }
}
