using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using platform_service.Dtos;
using platform_service.Models;

namespace platform_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepo platform;
        private readonly IMapper mapper;

        public PlatformController(IPlatformRepo platform, IMapper mapper)
        {
            this.platform = platform;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatform()
        {
            var res = platform.GetAll();
            return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(res));
        }
        [HttpGet]
        [Route("{Id}")]
        public ActionResult<PlatformReadDto> GetById(int id)
        {
            var res = platform.GetPlatformById(id);
            return Ok(mapper.Map<PlatformReadDto>(res));
        }

        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto plat)
        {
            var data = mapper.Map<Platform>(plat); 
            var res = platform.CreatePlatform(data);
            return Ok(mapper.Map<PlatformReadDto>(res));

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Id}, platformReadDto);
        }
    }
}
