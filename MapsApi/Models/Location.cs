using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApi.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
