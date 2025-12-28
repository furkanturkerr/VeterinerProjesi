using System.Text;
using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DTOLayer.AnimalDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VeterinerProjesi.Areas.Admin.Controllers;

[Area("Admin")]
public class AnimalController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AnimalController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responsemessage = await client.GetAsync("http://localhost:5132/api/Animal");
        if (responsemessage.IsSuccessStatusCode)
        {
            var jsonData = await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAnimalDto>>(jsonData);
            return View(values);
        }

        return View(new List<ResultAnimalDto>());
    }
    
    [HttpGet]
    public IActionResult CreateAnimal()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAnimal(CreateAnimalDto createAnimalDto)
    {
        var client = _httpClientFactory.CreateClient();
        var JsonData = JsonConvert.SerializeObject(createAnimalDto);
        StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
        var responsemessage = await client.PostAsync("http://localhost:5132/api/Animal", stringContent);
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> DeleteAnimal(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responsemessage = await client.DeleteAsync($"http://localhost:5132/api/Animal/{id}");
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> UpdateAnimal(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responsemessage = await client.GetAsync($"http://localhost:5132/api/Animal/{id}");
        if (responsemessage.IsSuccessStatusCode)
        {
            var JsonData = await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateAnimalDto>(JsonData);
            return View(values);
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateAnimal(UpdateAnimalDto updateAnimalDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateAnimalDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responsemessage = await client.PutAsync($"http://localhost:5132/api/Animal/", stringContent);
        if (responsemessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}