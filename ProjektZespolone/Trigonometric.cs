using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolone
{
    class Trigonometric
    {
        private float real;
        private float imaginary;

        public Trigonometric(float real, float imaginary) 
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
       
        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        public String Trygonometryczna()
        {
            double modul = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            double argz = 2 * Math.Atan(imaginary / (real + modul));
            double deg = RadianToDegree(argz);
            return Math.Round (modul,4).ToString() + "(cos" + Math.Round(deg,4) + "+ isin" + Math.Round(deg, 4) + ")";

        }
        
    }
}


