﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =1,ErrorMessage ="Ingrese entre 1 a 5 caracteres")]
        public string Symbol { get; set; }
    }
}