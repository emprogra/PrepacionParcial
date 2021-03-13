using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class Country
    {   
        [Key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<double> LatIng { get; set; }
        public List<string> TimeZones { get; set; }
        public List<Currency> Curriences { get; set; }
        public string FLag { get; set; }




    }
}