using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Multiply
    {

        private float real;
        private float imaginary;

        public Multiply(float real, float imaginary)
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
        public Multiply Mnozenie(Multiply zespolona)
        {
            float mnozReal = real * zespolona.WezReal() - imaginary * zespolona.WezImaginary();
            float mnozImaginary = real * zespolona.WezImaginary() + imaginary * zespolona.WezReal();
            Multiply wynikZespolona = new Multiply(mnozReal, mnozImaginary);
            return wynikZespolona;
        }
        public string Wynik()
        {
            return "(" + real + "; " + imaginary + "i)";
        }
    }
}
