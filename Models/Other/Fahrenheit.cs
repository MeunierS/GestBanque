﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Other
{
    public class Fahrenheit
    {
        public double Temperature { get; set; }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            Celsius celsius = new Celsius();
            celsius.Temperature = (fahrenheit.Temperature - 32) / 1.8;
            return celsius;
        }
    }
}
