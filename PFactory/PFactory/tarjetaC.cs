using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFactory
{
    public class tarjetaC : PatronF
    {
        public string consultarjetaCredito()
        {
            return "Miguel Ramirez";
        }

        public decimal consultarsaldo()
        {
            return 30.000m;
             
        }
    }
}
