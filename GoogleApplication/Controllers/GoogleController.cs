using GoogleApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoogleApplication.Controllers
{
    public class GoogleController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:44360/api/Map");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<LocationViewModel>>(jsonString);
            //jsondan .net e deserializable
            return View(values);
        }
    }
}
