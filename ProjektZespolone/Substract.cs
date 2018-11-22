using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Substract
    {

        private float real;
        private float imaginary;

        public Substract(float real, float imaginary) 
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
        public Substract Odejmowanie(Substract zespolona) 
        {
            float odejReal = real - zespolona.WezReal();
            float odejImaginary = imaginary - zespolona.WezImaginary();
            Substract wynikZespolona = new Substract(odejReal, odejImaginary);
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
