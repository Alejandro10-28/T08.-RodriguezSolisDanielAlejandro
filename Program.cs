using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Se instancia Repobank para mandar a llamar principal que es el metodo donde se encuentra  la 
            //Bienvenida y el menu.
            Repobank M = new Repobank();
            M.Principal();
        }


    }
}
