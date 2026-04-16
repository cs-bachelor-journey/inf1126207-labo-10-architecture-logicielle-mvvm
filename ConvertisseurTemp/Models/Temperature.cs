using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertisseurTemp.Models
{
    public class Temperature
    {
        public static double VerscelsiuS(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        public static double VersFahrenheit(double celsius) => celsius * 9 / 5 + 32;
    }
}
