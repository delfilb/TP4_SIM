using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Clases
{
    class Decimales
    {
        public static double truncarA4Decimales(double d)
        {
            return Math.Truncate(d * 10000) / 10000;
        }
    }
}
