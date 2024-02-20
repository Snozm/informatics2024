using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{
    internal class Converter
    {
        public Converter() { }
        public double BGNtoEUR(double bgn)
        {
            double output = bgn / 1.96;
            output -= output % 0.01;
            return output;
        }
        public double EURtoBGN(double eur)
        {
            double output = eur / 0.51;
            output -= output % 0.01;
            return output;
        }
    }
}
