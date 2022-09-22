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
        double distancia;
        public Delivery(int num, string cliente, double distEnKm):base(cliente, num)
        { distancia = distEnKm; }
        public override double VerPrecio()
        {
            precio = 0;
            for(int i=0;i<menu.Count;i++)
            {
                precio+=((ItemMenu)menu[i]).Precio;
            }      
            return precio+150+(precio*distancia*0.08);
        }
    }
}
