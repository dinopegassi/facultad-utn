using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora3D
{
    class Impresion3D
    {
        public ArrayList figuras { get; private set; }
        double precio, tiempo; // precioTotal; no era necesario
        public Cliente Empresa { get; private set; }
        public Impresion3D(double precioBase, string nombre, long cuit)
        {
            precio = precioBase;
            Empresa = new Cliente(nombre, cuit);
        }
        public void AgregarFigura(Figura pieza)
        { figuras.Add(pieza); }
        public double PrecioEstimado()
        {
            double precioTotal = 0;
            for(int i=0;i<figuras.Count;i++)
            { precioTotal += ((Figura)figuras[i]).Volumen() * (0.0035 * precio); }
            return precioTotal;
        }
        public int Tiempo()
        {
            tiempo = 0;
            for (int i = 0; i < figuras.Count; i++)
            { tiempo += ((Figura)figuras[i]).Perimetro() * 1.75; }
            return (int)tiempo;
        }
    }
}
