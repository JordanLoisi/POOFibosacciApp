using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooFibonacci.Entidades
{
    public class Termino
    {
        private int _numero;
        private int _posicion;

        public int Posicion
        {
            get { return _posicion; }
        }

        public Termino(int numero)
        {
            _numero = numero;
        }

        public static bool operator ==(Termino term1, Termino term2)
        {
            if (!(term1 is null) && !(term2 is null))
            {
               return term1._numero == term2._numero;
            }
            return false;
            
        }

        public static bool operator !=(Termino term1, Termino term2)
        {
            if (term1 == null && term2 == null)
            {
             return !(term1._numero == term2._numero);
            }
            return false;
        }

        public static int operator +(Termino term1, Termino term2)
        {
            if (!(term1 is null) && !(term2 is null))
            {
                return term1._numero + term2._numero; 
            }
            return 0;
        }

        public static explicit operator int(Termino v)
        {
            return v._numero;
        }

        public override string ToString()
        {
            return _numero.ToString();
        }
    }
}
