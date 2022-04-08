using MapsApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : Controller
    {   
            [HttpGet]
            public IList<Location> Get()
            {
            IList<Location> locations = new List<Location>()
                {
                    new Location { Id=1, CompanyName = "Zara",  PhoneNumber = "+902161111111", Latitude = 40.98867000000007f, Longitude = 29.02732000000003f },
                   new Location { Id=2, CompanyName = "Bershka",PhoneNumber = "+902162222222", Latitude = 39.768669f, Longitude = 30.507332f },
                    new Location { Id=3, CompanyName = "Pull And Bear",  PhoneNumber = "+902163333333", Latitude = 39.779669f, Longitude = 30.507332f },
                   new Location { Id=4, CompanyName = "Stradivarius",  PhoneNumber = "+902164444444", Latitude = 39.782669f, Longitude = 30.507332f }
                };
            return locations;
            }
        }
}
