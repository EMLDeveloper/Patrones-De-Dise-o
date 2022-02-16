using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class changestring : Iobject

    {
        private List<Iobserver> observes;

        public changestring()
        { 
            observes = new List<Iobserver>();
        
        }


        public void eliminar(Iobserver obs)
        {
           observes.Remove(obs);
        }

        public void notificar(string text)
        {
            foreach (var obs in observes) 
            {

                obs.update(text);

            }
        }
         
        public void registrar(Iobserver obs)
        {
            observes.Add(obs);
        }
    }
}
