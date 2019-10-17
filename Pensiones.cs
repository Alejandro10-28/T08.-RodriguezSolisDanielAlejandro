using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
   public class Pensiones:Cuenta
    {
        //Se encapsulan los atributos que tendra la clase pensiones
        public DateTime Vencimiento { get; set; }
        public int Cotización { get; set; }
        public int NoCuentaOrigen { get; set; }
        
    }
}
