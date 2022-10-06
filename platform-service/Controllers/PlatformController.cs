using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using platform_service.Context;
using platform_service.Dtos;
using platform_service.Models;
using platform_service.SyncData;

namespace platform_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private IPlatformRepo _platformRepo;
        private IMapper _mapper;
        private ISendDataToCommand _datacommand;

        public PlatformController(IPlatformRepo platformRepo, IMapper mapper, ISendDataToCommand datacommand)
        {
            _platformRepo = platformRepo;
            _mapper = mapper;
            _datacommand = datacommand;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatform()
        {
            var res = _platformRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(res));
        }
        [HttpGet("{Id}", Name = "GetPlatformById")]
        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        {
            var res = _platformRepo.GetPlatformById(id);
            return Ok(_mapper.Map<PlatformReadDto>(res));
        }

        public async Task<ActionResult<PlatformReadDto>> CreatePlatform(PlatformCreateDto plat)
        {
            //Create obj
            var dataModel = _mapper.Map<Platform>(plat); 
            var res = _platformRepo.CreatePlatform(dataModel);
            var platformReadDto = _mapper.Map<PlatformReadDto>(res);
            // return Ok();

            //Sync data
            try
            {
                await _datacommand.SendHttpToCommand(platformReadDto);
                
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine($"--> Could not sync data {ex.Message}");
            }

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Cost}, platformReadDto);
        }
    }
}
