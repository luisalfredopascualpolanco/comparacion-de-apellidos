using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string apellido1, apellido2;

                Console.Write("Introduce un apellido: ");
                apellido1 = Console.ReadLine().ToLower();

                Console.Write("Introduce otro apellido: ");
                apellido2 = Console.ReadLine().ToLower();

                if (apellido1 == apellido2)
                {
                    Console.WriteLine("Los apellidos son iguales.");
                }
                else
                {
                    Console.WriteLine("Los apellidos son distintos.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
