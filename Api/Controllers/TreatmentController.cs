using Api.Dtos.AppointmentDtos;
using Api.Dtos.TreatmentDtos;
using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatmentService _treatmentService;
        private readonly IMapper _mapper;
        private readonly IAppointmentService _appointmentService;

        public TreatmentController(ITreatmentService treatmentService, IMapper mapper,  IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            _treatmentService = treatmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TreatmentList()
        {
            var value = _treatmentService.TGetListAll();
            return Ok(_mapper.Map<List<ResultTreatmentDto>>(value));
        }
        
        [HttpGet("AppointmentList")]
        public IActionResult AppointmentList()
        {
            var value = _appointmentService.TListAnimal();
            return Ok(_mapper.Map<List<ResultAppointmentDto>>(value));
        }
        
        [HttpGet("GetTreatmentsWithDetails")]
        public IActionResult GetTreatmentsWithDetails()
        {
            var value = _treatmentService.TGetTreatmentsWithDetails();
            return Ok(_mapper.Map<List<ResultTreatmentDto>>(value));
        }

        [HttpPost]
        public IActionResult CreateTreatment(CreateTreatmentDto treatmentDto)
        {
            var value = _mapper.Map<Treatment>(treatmentDto);
            value.TreatmentDate = DateOnly.FromDateTime(DateTime.Now);
            var now = TimeOnly.FromDateTime(DateTime.Now);
            value.TreatmentTime = new TimeOnly(now.Hour, now.Minute);
            _treatmentService.TAdd(value);
            return Ok("Tedavi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTreatment(int id)
        {
            var value = _treatmentService.TGetById(id);
            _treatmentService.TDelete(value);
            return Ok("Tedavi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTreatmentById(int id)
        {
            var value = _treatmentService.TGetById(id);
            var dto = _mapper.Map<ResultTreatmentDto>(value);
            return Ok(dto);
        }

        [HttpPut]
        public IActionResult UpdateTreatment(UpdateTreatmentDto updateTreatmentDto)
        {
            var value = _mapper.Map<Treatment>(updateTreatmentDto);
            _treatmentService.TUpdate(value);
            return Ok("Tedavi Güncellendi");
        }
    }
}
