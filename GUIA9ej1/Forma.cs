using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA9ej1
{
    class Forma
    {
        public int Calcular(int a)
        {
            return 4 * a;
        }
        public double Calcular(double a)
        {
            return a * a;
        }
        public int Calcular(int a,int b)
        {
            return 2 * a + 2 * b;
        }
        public double Calcular(double a,double b)
        {
            return a * b;
        }
        public int Calcular(int a,int b, int c)
        {
            return a + b + c;
        }
        public double Calcular(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return t;
        }
    }
}
