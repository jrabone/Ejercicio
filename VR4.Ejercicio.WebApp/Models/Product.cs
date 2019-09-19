using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VR4.Ejercicio.WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime Timestamp { get; set; }     
    }
}