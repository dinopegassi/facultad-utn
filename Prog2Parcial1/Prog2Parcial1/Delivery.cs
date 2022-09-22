using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Parcial1
{
    internal class Delivery : Pedido
    {
        ArrayList menu = new ArrayList();
        double distancia;
        public Delivery(int num, string cliente, double distEnKm):base(cliente, num)
        {
            distancia = distEnKm;
        }
        public override double Precio()
        {
            this.precio = 0;
            foreach (ItemMenu elemento in menu)
            {
                this.precio+=elemento.Precio;
            }
            this.precio += (distancia * 0.08);
            this.precio += 150;            
            return this.precio;
        }
    }
}
