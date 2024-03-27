using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Other
{
    public class Celsius
    {
        public double Temperature { get; set; }

        public static implicit operator Fahrenheit(Celsius celsius)
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.Temperature = celsius.Temperature * 1.8 + 32;
            return fahrenheit;
        }
    }
}
