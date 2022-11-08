using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carmen_bracho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //American Gas
            //Variables
            string tituloAplicacion = "American Gas";
            string galonesDespachados;
            Double precioDeGasolina = 22.90;
            float costoTotal;
            


            //Personalizar la consola
            Console.Title = tituloAplicacion;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(90, 30);
            Console.Clear();
            Console.WriteLine("\t {0}", tituloAplicacion.ToUpper());


            //FUNCION DEL PROGRAMA
            Console.WriteLine(tituloAplicacion);
            Console.WriteLine(galonesDespachados);
            Console.WriteLine(costoTotal);
            costoTotal = Console.ReadLine();


        }
    }
}
