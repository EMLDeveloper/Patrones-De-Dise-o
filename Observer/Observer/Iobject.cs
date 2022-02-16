using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface Iobject
    {
       void registrar (Iobserver obs);
       void eliminar (Iobserver obs);
       void notificar (string text);
    }
}
