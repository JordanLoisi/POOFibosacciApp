using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooFibonacci.Entidades
{
    public class Fibonacci
    {
        private int _cantidadTerminos;
        private Termino[] _terminos;

        public int CantidadTerminos
        {
            get { return _cantidadTerminos; }
        }

        public Fibonacci(int cantidadTerminos = 5)
        {
            if (cantidadTerminos > 0 && cantidadTerminos <= 20)
                _cantidadTerminos = cantidadTerminos;
            else
                _cantidadTerminos = 5;

            _terminos = new Termino[_cantidadTerminos];
        }
        public int getCantidadTerminos() => _cantidadTerminos;
        private bool EstaVacio()
        {
            foreach (Termino termino in _terminos)
            {
                if (termino != null)
                    return false;
            }
            return true;
        }

        private bool EstaLleno()
        {
            foreach (Termino termino in _terminos)
            {
                if (termino == null)
                    return false;
            }
            return true;
        }

        public static bool operator +(Fibonacci fib, Termino term)
        {


            if (!(fib == term))
            {
                for (int i = 0; i < fib._terminos.Length; i++)
                {
                    if (fib._terminos[i] is null)
                    {
                        fib._terminos[i] = term;
                        return true;
                    }
                } 
            }

            return false;
        }

        public static bool operator ==(Fibonacci fib, Termino term)
        {
            foreach (Termino termino in fib._terminos)
            {
                if (termino == term)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Fibonacci fib, Termino term)
        {
            return !(fib==term);
            //foreach (Termino termino in fib._terminos)
            //{
            //    if (termino == term)
            //        return false;
            //}
            //return true;
        }

        public void GenerarSerie()
        {
            if (EstaVacio())
            {
                _terminos[0] = new Termino(0);
                if (_cantidadTerminos > 1)
                    _terminos[1] = new Termino(1);

                for (int i = 2; i < _cantidadTerminos; i++)
                {
                    _terminos[i] = new Termino(_terminos[i - 1] + _terminos[i - 2]);
                }

            }
        }
        public Termino ObtenerTermino(int posicion)
        {
            if (posicion >= 0 && posicion < _cantidadTerminos)
            {
                return _terminos[posicion];
            }
            else
            {
                Console.WriteLine("Posición inválida.");
                return null;
            }
        }

        public void MostrarSerie()
        {
            Console.WriteLine("Serie de Fibonacci:");
            foreach (Termino termino in _terminos)
            {
                Console.Write(termino + " ");
            }
            Console.WriteLine();
        }

        public void MostrarSerieDecreciente()
        {
            Console.WriteLine("Serie de Fibonacci (decreciente):");
            for (int i = _cantidadTerminos - 1; i >= 0; i--)
            {
                Console.Write(_terminos[i] + " ");
            }
            Console.WriteLine();
        }

        public bool NumeroEnSerie(int numero, out int posicion)
        {
            posicion = -1;

            for (int i = 0; i < _cantidadTerminos; i++)
            {
                if (_terminos[i].ToString() == numero.ToString())
                {
                    posicion = i;
                    return true;
                }
            }

            return false;
        }

        public static implicit operator int(Fibonacci fib)
        {
            int suma = 0;
            foreach (Termino termino in fib._terminos)
            {
                suma += (int)termino;
            }
            return suma;
        }

        public static implicit operator double(Fibonacci fib)
        {
            double suma = 0;
            foreach (Termino termino in fib._terminos)
            {
                suma += (double)termino;
            }
            return suma / fib._cantidadTerminos;
        }


    }
}
