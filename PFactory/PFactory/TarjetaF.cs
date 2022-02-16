using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFactory
{
    public class TarjetaF
    {
        PatronF tarjeta;
        public void consultarInfo(tipoTarjeta tipo)
        {
            switch(tipo) 
            {

                case tipoTarjeta.Credito:
                    tarjeta = new tarjetaC();
                    break;
                case tipoTarjeta.Debito:
                    tarjeta = new Debito();
                    break;

            
            }
            Console.WriteLine(tarjeta.consultarjetaCredito());
            Console.WriteLine(tarjeta.consultarsaldo());



        }
    }
}
