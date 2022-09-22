using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteDeCargas
{
    class Contenedor
    {
        public int Id { get; private set; } // asignado x contador
        public string EmpresaDespachante { get; private set; } // nombre (dato)
        public bool Expreso { get; private set; } // V expreso - F full (dato)
        public double CapacidadMaximaKg { get; private set; }//(dato)
        public int CantA { get; private set; } // 5k
        public int CantB { get; private set; }// 15kg
        public int CantC { get; private set; } // 25kg
        //private double Precio { get; private set; }
        public Contenedor(int id, string nombre, bool expreso, double capacidad, int a, int b, int c)
        {
            this.Id = id;
            this.EmpresaDespachante = nombre;
            this.Expreso = expreso;
            this.CapacidadMaximaKg = capacidad;
            this.CantA = a;
            this.CantB = b;
            this.CantC = c;
        }
        public int CalcularPesoReal()
        {
            return CantA * 5 + CantB * 15 + CantC * 25;
        }
    }
}
