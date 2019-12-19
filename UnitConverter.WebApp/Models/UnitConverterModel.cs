using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitConverter.WebApp.Models
{
    public class UnitConverterModel
    {
        [Display(Name ="Jednostka")]        
        public string whatUnit { get; set; }
        public double convertFrom { get; set; }
        public double convertTo { get; set; }
        public double result { get; set; }
    }
}