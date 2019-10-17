using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
    public class Cuenta
    {
        //Se encapsulan los atributos que tendran las demas clases
        public int Numero { get; set; }
        public string Titulo { get; set; }

        public decimal Saldo { get; set; }
        public double Interes { get; set; }
                
        //Se crea metodo ingreso,se usa como parametro cuenta ya que ahi contiene el saldo y al ingresar a los atributos
        //de la clase cuenta puedo acceder al saldo del objeto dependiendo del número de cuenta que ingreso el usuario.
        public double Ingreso(Cuenta cuenta)
        {
            //Utilize un if para que si el usuario desea agregar una nueva cantida se realice la operacion
            decimal Rp = 0;
            Console.WriteLine("¿Deseas ingresar una nueva cantidad a tu cuenta?\n1.-Si\n2.-No");
            int R = Convert.ToInt32(Console.ReadLine());
            //En dado caso de ser 1 se realizara la operacion y se actualizara su saldo
            if (R == 1)
            {
                Console.WriteLine("Ingresa cantidad a ingresar");
                decimal NC = Convert.ToDecimal(Console.ReadLine());
                 Rp = cuenta.Saldo + NC;
                Console.WriteLine("Tu nuevo saldo es de:" + Rp);

            }
            //Si no se le dara elegir una nueva opcion
            else
            {
                Console.WriteLine("Elija otra opcion");
                
            }
           
           
            
            return R;

        }
        //Se crea el metodo interespormes el cual mandara el parametro interes ya predeterminado por los objetos
        public double InteresPorMes(double Interes)
        {
            //Se hace la operacion y se guarda en la variable iTotal
            var iTotal = Interes * .16;
            Console.WriteLine("El interes por mes es de: $" + iTotal);
            //se retorna iTotal ala referencia como resultado
            return iTotal;

        }
        //Se usa como parametro la una variable del tipo Cuenta para que pueda acceder a la lista de atributos
        //Que fueron llenados segun el numero de cuenta que ingreso el usuario.
        public void ConsultarSaldo(Cuenta Cuenta)
        {

            Console.WriteLine("Su saldo Actual es de  $" + Cuenta.Saldo);
        }
        //El metodo transferir se usa como parametro cuenta ya que ahi contiene el saldo y al ingresar a los atributos
        //de la clase cuenta puedo acceder al saldo del objeto dependiendo del número de cuenta que ingreso el usuario.
        public void Tranferir(Cuenta cuenta)
        {
            Console.WriteLine("Ingresa cantidad que quieras transferir");

            decimal transferir = Convert.ToDecimal(Console.ReadLine());

            if (transferir < cuenta.Saldo)
            {
                decimal SA =cuenta.Saldo-transferir;
                Console.WriteLine("Tu saldo actual es de :" + SA);
            }
            else
            {
                Console.WriteLine("Sin fondos para transferir");
            }
            
            

        }
    }
}
