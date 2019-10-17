using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
   public class AccountData
    {
        //Se crea el metodo de tipo list el cual contendra todos los objetos que en
        //este caso seran los clientes.
        //Cada uno de los metodos manejara su propia lista de usuarios ya que son de opciones distintas
        //a ingresar
        public List<Pensiones> Pensiones()
        {
            //Se crean los objetos que contendras los datos de los clientes y se agregan a la lista para mas tarde
            //Poder evaluarlos con los datos de quien quiera ingresar, ya que de esta lista se hara un pase
            //para que solo pueda acceder aquel que sepa alguno de los números de cuenta.
            List<Pensiones> pensions = new List<Pensiones>();
            pensions.Add(new Pensiones { Numero = 12345, Saldo = 1134.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Daniel Alejandro Rodriguez Solis", Interes = 2.21, NoCuentaOrigen = 12322, Cotización = 25 });
            pensions.Add(new Pensiones { Numero = 12532, Saldo = 1721.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Alexa Licona olvera", Interes = 2.21, NoCuentaOrigen = 123345, Cotización = 25 });
            pensions.Add(new Pensiones { Numero = 13456, Saldo = 152.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Jose medina", Interes = 2.21, NoCuentaOrigen = 12243, Cotización = 25 });
            pensions.Add(new Pensiones { Numero = 15323, Saldo = 112.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Juase elizalde", Interes = 2.21, NoCuentaOrigen = 1224, Cotización = 25 });
            pensions.Add(new Pensiones { Numero = 16432, Saldo = 123.4M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Pedro alvarado", Interes = 2.21, NoCuentaOrigen = 12245, Cotización = 25 });
            //Se retorna la variable pensions ya que esta es la que contiene la lista con los objetos agregados
            //con los cual se evaluaran los datos que ingrese el usuario en este caso su numero de cuenta.
            return pensions;

        }
        public List<AccountSave> Cguardar()
        {
            //Se crean los objetos que contendras los datos de los clientes y se agregan a la lista para mas tarde
            //Poder evaluarlos con los datos de quien quiera ingresar, ya que de esta lista se hara un pase
            //para que solo pueda acceder aquel que sepa alguno de los números de cuenta.
            List<AccountSave> cguardar = new List<AccountSave>();
            cguardar.Add(new AccountSave { Numero = 123456, Saldo = 1231.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Miguel", Interes = 3.12 });
            cguardar.Add(new AccountSave { Numero = 12532, Saldo = 1721.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Alexa Licona olvera", Interes = 2.21});
            cguardar.Add(new AccountSave { Numero = 13456, Saldo = 152.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Jose medina", Interes = 2.21 });
            cguardar.Add(new AccountSave { Numero = 15323, Saldo = 112.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Juase elizalde", Interes = 2.21 });
            cguardar.Add(new AccountSave { Numero = 16432, Saldo = 123.4M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titulo = "Pedro alvarado", Interes = 2.21 });
            //Se retorna la variable pensions ya que esta es la que contiene la lista con los objetos agregados
            //con los cual se evaluaran los datos que ingrese el usuario en este caso su numero de cuenta.
            return cguardar;

        }
        public List<CurrentAccount> CAccounts()
        {
            //Se crean los objetos que contendras los datos de los clientes y se agregan a la lista para mas tarde
            //Poder evaluarlos con los datos de quien quiera ingresar, ya que de esta lista se hara un pase
            //para que solo pueda acceder aquel que sepa alguno de los números de cuenta.
            List<CurrentAccount> currents = new List<CurrentAccount>();
            currents.Add(new CurrentAccount { Numero = 123, Saldo = 124.35M,  Titulo = "Daniel", Interes = 2.21 });
            currents.Add(new CurrentAccount { Numero = 12532, Saldo = 1721.35M, Titulo = "Alexa Licona olvera", Interes = 2.21 });
            currents.Add(new CurrentAccount { Numero = 13456, Saldo = 152.35M,  Titulo = "Jose medina", Interes = 2.21 });
            currents.Add(new CurrentAccount { Numero = 15323, Saldo = 112.35M, Titulo = "Juase elizalde", Interes = 2.21 });
            currents.Add(new CurrentAccount { Numero = 16432, Saldo = 123.4M, Titulo = "Pedro alvarado", Interes = 2.21 });
            //Se retorna la variable pensions ya que esta es la que contiene la lista con los objetos agregados
            //con los cual se evaluaran los datos que ingrese el usuario en este caso su numero de cuenta.
            return currents;
            

        }
    }
}
