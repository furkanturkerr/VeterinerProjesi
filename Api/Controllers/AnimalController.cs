using Api.Dtos.AnimalDtos;
using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAnimalService _animalService;
        
        public AnimalController(IMapper mapper, IAnimalService animalService)
        {
            _mapper = mapper;
            _animalService = animalService;
        }

        [HttpGet]
        public IActionResult AnimalList()
        {
            var values = _animalService.TGetListAll();
            return Ok(_mapper.Map<List<ResultAnimalDto>>(values));
        }

        [HttpPost]
        public IActionResult CreateAnimal(CreateAnimalDto createAnimalDto)
        {
            var value = _mapper.Map<Animal>(createAnimalDto);
            _animalService.TAdd(value);
            return Ok("Hayvan eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var value = _animalService.TGetById(id);
            _animalService.TDelete(value);
            return Ok("Hayvan silindi");
        }
    
        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            var value = _animalService.TGetById(id);
            var dto = _mapper.Map<UpdateAnimalDto>(value);
            return Ok(dto);   
        }


        [HttpPut]
        public IActionResult UpdateAnimal(UpdateAnimalDto updateAnimalDto)
        {
            var value = _mapper.Map<Animal>(updateAnimalDto);
            _animalService.TUpdate(value);
            return Ok("Hayvan bilgisi güncellendi");
        }
    }
}
