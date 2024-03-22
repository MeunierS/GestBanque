using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Celsius
    {
        public double Temperature;

        public static implicit operator Fahrenheit (Celsius celsius)
        {
            return celsius.Temperature*1.8 +32;
        }
    }
}
