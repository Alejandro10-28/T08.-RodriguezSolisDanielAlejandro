using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
    public class Repobank
    {
        //Se crea una instancia de tipo AccountData la cual contiene los metodos que existen en esa clase
        AccountData ad;
        public Repobank()
        {
            ad = new AccountData();
        }
        //Principal solo es la bienvenida al usuario y el menú 
        internal void Principal()
        {
            Console.WriteLine("==============Bienvenidos A el Banco TecTijuana===============");
            Menu();
            Console.ReadLine();
        }
      
      
        //Se crea el menu que interactua con el usuario 
        private void Menu()
        {
            Console.WriteLine("Ingrese a la Opcion Correcta");
            Console.WriteLine("1.- Cuenta Ahorro \n2.- Pensiones \n3.- Cuenta Corriente");
            //El switch evalua de tipo string las opciones ingresadas por el usuario por ello el 
            //Console.Readline
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    //Se llama al metdo GetDataSave
                    GetDataSave();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    //Se llama al metodo GetDataSave
                    GetDataPension();

                    break;

                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    //Se llama al metodo GetDataSave
                    GetDataCurrent();
                    break;

                default:
                    Console.WriteLine("OPCION NO VALIDA ");
                    break;
            }
            Menu();
        }

        private void GetDataCurrent()
        {
            //Se crea la variable number la cual almacenara el metodo GetData el cual es el que 
            //Pide al usuario su número de cuenta el cual evaluara.
            int number = GetData();
            var lista = ad.CAccounts();
            CurrentAccount C= new CurrentAccount();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero)
                {
                    //Se hace un if donde si number es igual al numero de cuenta que estaba predeterminado al objeto
                    //C sera igual a los datos correspondientes dicha iteracion.

                    C = cuenta;
                }
            }

            Console.WriteLine("Bienvenido " + C.Titulo);
            //Se llama al menú usuario la cual envia como parametro p la cual contiene 
            //los aributos y metodos de la clase cuenta y la clase hija CurrentAccount.
            MenuUsuario(C);
        }

        //Metodo para pensiones , lo que hace es que al momento donde el usuario elije la opcion 
        //Pensiones Pedira su número de cuenta y si es cliente le ofrecera los servicios ya predeterminados

        private void GetDataPension()
        {
            //Se crea la variable number la cual almacenara el metodo GetData el cual es el que 
            //Pide al usuario su número de cuenta el cual evaluara.
            int number = GetData();
            //Se crea la variable lista la cual guardara la lista de los clientes de pensiones. 
            var lista = ad.Pensiones();
            Pensiones p = new Pensiones();
            //Se usa el foreach para  pasar por la lista de la variable y buscar el numero de cuenta que sea
            //el que se ingreso este lo busca dato por dato hasta dar con el que sea identico.
            foreach (var cuenta in lista)
            {
                //Se hace un if donde si number es igual al numero de cuenta que estaba predeterminado al objeto
                //P sera igual a los datos correspondientes dicha iteracion.
                if (number == cuenta.Numero)
                {
                    p = cuenta;
                }
            }

            Console.WriteLine("Bienvenido " + p.Titulo);
            //Se llama al menú usuario la cual envia como parametro p la cual contiene 
            //los aributos y metodos de la clase cuenta y la clase hija pensiones.
            MenuUsuario(p);
        }
        //El MenuUsuario es el cual solo los clientes tienen acceso
        //Se crea la variable p de tipo cuenta para que esta pueda acceder a los atributos y metodos
        //Los cuales se encuentran en esa clase.
        public void MenuUsuario(Cuenta p)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu Cuenta :" + p.Titulo);
            Console.WriteLine("1.- Consultar Saldo \n2.- Transferir \n3.- Interes x Mes \n4.- Ingreso \n5.-Regresar al menú principal");
            Console.WriteLine("Elije una Opcion");
            //El switch evalua de tipo string las opciones ingresadas por el usuario por ello el 
            //Console.Readline
            switch (Console.ReadLine())
            {
                //En cada metodo mando como parametro P ya que es la variable que cuenta con los atributos a evaluar
                //de la clase padre y es el cual se puede evaluar la informacion de donde pertenece el numero de cuenta.
                case "1":
                    p.ConsultarSaldo(p);
                    break;
                case "2":
                    p.Tranferir(p);
                    break;
                case "3":
                    p.InteresPorMes(p.Interes);
                    break;
                case "4":
                    p.Ingreso(p);
                    break;
                case "5":
                    Console.Clear();
                    Menu();

                    break;
                default:
                    Console.WriteLine("NO SE ENCUENTRA OPCION\n INTENTE DE NUEVO");
                    
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            MenuUsuario(p);

        }
        private void GetDataSave()
        {
            //Se crea la variable number la cual almacenara el metodo GetData el cual es el que 
            //Pide al usuario su número de cuenta el cual evaluara.
            int number = GetData();
            var lista = ad.Cguardar();
            AccountSave D = new AccountSave();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero)
                {
                    //Se hace un if donde si number es igual al numero de cuenta que estaba predeterminado al objeto
                    //D sera igual a los datos correspondientes dicha iteracion.
                    D = cuenta;
                }
            }

            Console.WriteLine("Bienvenido " + D.Titulo);
            //Se llama al menú usuario la cual envia como parametro p la cual contiene 
            //los aributos y metodos de la clase cuenta y la clase hija pensiones.
            MenuUsuario(D);
        }
       
       
        // Este metodo solo le pide el número de cuenta al usuario
        private int GetData()
        {

            Console.WriteLine("Ingrese Su Numero de Cuenta");
            //Se crea la variable de tipo string para que evalue lo escrito por el usuario
            string res = Console.ReadLine();
            //Se retorna la respuesta escrita por el usuario y regresa convertida de tipo int32
            return Convert.ToInt32(res);
        }
    }

}
