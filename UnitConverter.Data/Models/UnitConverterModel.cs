using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter.DataLibrary.Models
{
    class UnitConverterModel
    {
        public string whatUnit { get; set; }
        public double convertFrom { get; set; }
        public double convertTo { get; set; }
        public double result { get; set; }
        public DateTime ConvertTime { get; set; }
    }
}
