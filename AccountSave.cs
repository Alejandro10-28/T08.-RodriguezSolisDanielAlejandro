using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
    public class AccountSave:Cuenta
    {
        //se encapsulan los atributos que tendra la clase Accounsave
        public DateTime Vencimiento { get; set; }

        // Se crea metodo ingreso por mes
        public double IngresoPorMes()
        {
            return 0;
        }
    }
}
