using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Odejmowanie
    {
        private float real;
        private float imaginary;

        public Odejmowanie(float real, float imaginary) // przekazywanie argumentów 
        {
            this.real = real; // odwołanie klasy do samej siebie tak jakby Zespolona.real
            this.imaginary = imaginary;
        }
        public float WezReal() // metoda 
        {
            return real; // zwraca podaną wartość przy obieckie 
        }
        public float WezImaginary()
        {
            return imaginary;
        }

        public Odejmowanie Odejm(Odejmowanie zespolona) // zespolona - nazwa obiektu , Zespolone - nazwa klasy
        {
            float odejReal = real - zespolona.WezReal();
            float odejImaginary = imaginary - zespolona.WezImaginary();
            Odejmowanie wynikZespolona = new Odejmowanie (odejReal, odejImaginary);
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
