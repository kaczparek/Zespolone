using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Divide
    {

        private float real;
        private float imaginary;

        public Divide(float real, float imaginary) 
        {
            this.real = real; 
            this.imaginary = imaginary;
        }
        public float WezReal()
        {
            return real; 
        }
        public float WezImaginary()
        {
            return imaginary;
        }
        public Divide Mnozeniedosprzez(Divide zespolona)
        {
            float mnozReal = real * zespolona.WezReal() - imaginary * zespolona.WezImaginary();
            float mnozImaginary = real * zespolona.WezImaginary() + imaginary * zespolona.WezReal();
            Divide wynikZespolona = new Divide(mnozReal, mnozImaginary);
            return wynikZespolona;
        }
        public Divide Dzielenie(Divide zespolona)
        {
            Divide sprzezenie = new Divide(zespolona.WezReal(), zespolona.WezImaginary() * (-1));
            Divide wynikLicznik = Mnozeniedosprzez(sprzezenie);
            Divide wynikMianownik =zespolona.Mnozeniedosprzez(sprzezenie);
            float dzielReal = wynikLicznik.WezReal() / wynikMianownik.WezReal();
            float dzielImaginary = wynikLicznik.WezImaginary() / wynikMianownik.WezReal();
            Divide wynikZespolona = new Divide(dzielReal, dzielImaginary);
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
