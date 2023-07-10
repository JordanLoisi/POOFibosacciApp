using PooFibonacci.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFibosacciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci(2);
            Termino termino = new Termino(4);
            Termino termino1 = new Termino(5);

           



            if (fib+termino && fib+termino1)
            {
                Console.WriteLine(fib.getCantidadTerminos());
            fib.GenerarSerie();
            fib.MostrarSerie();
            fib.MostrarSerieDecreciente();

                       int posicion;
            if (fib.NumeroEnSerie(2, out posicion))
                Console.WriteLine("El número 4 está en la posición {0} de la serie.", posicion);
            else
                Console.WriteLine("El número 8 no está en la serie.");

                int suma = fib;
                Console.WriteLine("La suma de los términos de la serie es: {0}", suma);

                double promedio = fib;
                Console.WriteLine("El promedio de los términos de la serie es: {0}", promedio); 

                
            }



            Console.ReadLine();
        }
    }
}
