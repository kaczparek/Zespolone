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
        public float WezReal() // metoda 
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
            float odejReal = real - zespolona.WezReal();
            float odejImaginary = imaginary - zespolona.WezImaginary();
            Zespolone wynikZespolona = new Zespolone(odejReal, odejImaginary);
            return wynikZespolona;
        }
        public Zespolone Mnozenie(Zespolone zespolona)
        {
            float mnozReal = real * zespolona.WezReal() -  imaginary * zespolona.WezImaginary();
            float mnozImaginary = real * zespolona.WezImaginary() + imaginary * zespolona.WezReal();
            Zespolone wynikZespolona = new Zespolone(mnozReal, mnozImaginary);
            return wynikZespolona;
        }
        public Zespolone Dzielenie(Zespolone zespolona)
        {
            Zespolone sprzezenie = new Zespolone(zespolona.WezReal(), zespolona.WezImaginary() * (-1));
            Zespolone wynikLicznik = Mnozenie(sprzezenie);
            Zespolone wynikMianownik = zespolona.Mnozenie(sprzezenie); 
            float dzielReal = wynikLicznik.WezReal() / wynikMianownik.WezReal();
            float dzielImaginary = wynikLicznik.WezImaginary() / wynikMianownik.WezReal();
            Zespolone wynikZespolona = new Zespolone(dzielReal, dzielImaginary);
            return wynikZespolona;
        }
        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        public String Trygonometryczna()
        {
            double modul = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            double argz =2 * Math.Atan(imaginary / (real + modul));
            double deg = RadianToDegree(argz);
            return Math.Round(modul).ToString() + "(cos" + deg + "+ isin" + deg + ")";
            
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
