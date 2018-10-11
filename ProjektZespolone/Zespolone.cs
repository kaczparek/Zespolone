using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Zespolone
    {
        private float real;
        private float imaginary;

        public Zespolone(float real, float imaginary) // przekazywanie argumentów 
        {
            this.real = real; // odwołanie klasy do samej siebie tak jakby Zespolona.real
            this.imaginary = imaginary;
        }
        public float WezReal() // metoda 'getter'
        {
            return real; // zwraca podaną wartość przy obieckie 
        }
        public float WezImaginary()
        {
            return imaginary;
        }
        public Zespolone Dodawanie(Zespolone zespolona) // nazwa zmiennej 
        {
            float sumaReal = real + zespolona.WezReal(); // zespolona- obiekt 
            float sumaImaginary = imaginary + zespolona.WezImaginary();
            Zespolone wynikZespolona = new Zespolone(sumaReal, sumaImaginary); // new tworzy nowy obiekt tej klasy
            return wynikZespolona;
        }
        public Zespolone Odejmowanie(Zespolone zespolona) // zespolona - nazwa obiektu , Zespolone - nazwa klasy
        {
            float odejReal = real - zespolona.WezReal(); // zespolona- obiekt 
            float odejImaginary = imaginary - zespolona.WezImaginary();
            Zespolone wynikZespolona = new Zespolone(odejReal, odejImaginary);
            return wynikZespolona;
        }
        public Zespolone Mnozenie(Zespolone zespolona)
        {
            float mnozReal = real * zespolona.WezReal() -  imaginary * zespolona.WezImaginary();
            float mnozImaginary = imaginary * zespolona.WezImaginary() + imaginary * zespolona.WezReal();
            Zespolone wynikZespolona = new Zespolone(mnozReal, mnozImaginary);
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + ", " + imaginary + "i)";
        }
    }
}
