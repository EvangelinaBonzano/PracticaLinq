using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el origen de datos
            List<string> nombres = new List<string> { "Evangelina", "Candela", "Franco", "Nicolas" };

            //Hacemos la creación de la consulta
            IEnumerable<string> nomQuery = from n in nombres
                                           where n == "Candela"
                                           select n;

            //Ejecutamos la consulta
            foreach (string nom in nomQuery)
                Console.WriteLine(nom);

            Console.WriteLine(" -------------- ");

            //Creamos el origen de datos
            List<int> numeros = new List<int> { 5, 9, 6, 8, 3, 4, 7, 2, 0};

            //Hacemos la creación de la consulta
            IEnumerable<int> numQuery = numeros.Where(n => n % 2 == 0).OrderBy(n => n);

            //Ejecutamos la consulta
            foreach (int num in numQuery)

                Console.WriteLine(num + " ");
        }
    }
}
