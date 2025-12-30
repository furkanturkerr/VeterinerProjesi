using System.Text;
using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.AppointmentDtos;
using DTOLayer.TreatmentDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class TreatmentController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    
    public TreatmentController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5132/api/Treatment");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTreatmentDto>>(jsonData);
            return View(values);
        }
        return View(new List<ResultTreatmentDto>());
    }

    [HttpGet]
    public async Task<IActionResult> CreateTreatment()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5132/api/Treatment/AppointmentList");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAppointmentDto>>(jsonData);
            ViewBag.Appointments = values.Select(x => new SelectListItem
            {
                Value = x.AppointmentId.ToString(),
                Text = $"{x.Date:dd MMM yyyy}, {x.Time} - {x.AnimalName} ({x.AnimalSpecies})"
            }).ToList();
        }   
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTreatment(CreateTreatmentDto treatment)
    {
        var client = _httpClientFactory.CreateClient();
        var JsonData = JsonConvert.SerializeObject(treatment);
        StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
        var responsemessage = await client.PostAsync("http://localhost:5132/api/Treatment", stringContent);
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    public async Task<IActionResult> DeleteTreatment(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responsemessage = await client.DeleteAsync($"http://localhost:5132/api/Treatment/{id}");
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> UpdateTreatment(int id)
    {
        var client = _httpClientFactory.CreateClient();
        
        var response = await client.GetAsync("http://localhost:5132/api/Treatment/AppointmentList");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAppointmentDto>>(jsonData);
            ViewBag.Appointments = values.Select(x => new SelectListItem
            {
                Value = x.AppointmentId.ToString(),
                Text = $"{x.Date:dd MMM yyyy}, {x.Time} - {x.AnimalName} ({x.AnimalSpecies})"
            }).ToList();
        }   
        
        var responsemessage = await client.GetAsync($"http://localhost:5132/api/Treatment/{id}");
        if (responsemessage.IsSuccessStatusCode)
        {
            var JsonData = await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateTreatmentDto>(JsonData);
            return View(values);
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateTreatment(UpdateTreatmentDto treatment)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(treatment);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responsemessage = await client.PutAsync($"http://localhost:5132/api/Treatment/", stringContent);
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}