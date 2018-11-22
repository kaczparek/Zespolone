using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Add
    {
        
        private float real;
        private float imaginary;

        public Add(float real, float imaginary) // przekazywanie argumentów 
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
        public Add Dodawanie(Add zespolona) // nazwa zmiennej 
        {
            float sumaReal = real + zespolona.WezReal(); // zespolona- obiekt 
            float sumaImaginary = imaginary + zespolona.WezImaginary();
            Add wynikZespolona = new Add(sumaReal, sumaImaginary); // new tworzy nowy obiekt tej klasy
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
