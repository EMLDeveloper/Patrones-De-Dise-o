using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFactory
{
    public static void Main(string[] args)
    {
        TarjetaF tarjeta = new TarjetaF();
        tarjeta.consultarInfo(tipoTarjeta.Credito);
        Console.WriteLine("-----------------------------------");
        tarjeta.consultarInfo(tipoTarjeta.Debito);

    }
}
