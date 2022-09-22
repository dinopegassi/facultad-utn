using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1
{
    internal class Pedido
    {
        protected string cliente;
        public int Numero { get; private set; }
        protected double precio;
        protected ArrayList menu = new ArrayList();

        public Pedido(string cliente, int numero)
        {
            this.cliente = cliente;
            Numero = numero;
            //menu = new ArrayList();
            //AgregarItem(itemdemenu, 1)         //como dice "1..*" flashe que el objeto arranca con AL MENOS un pedido,
                                                 //pero no tengo un objeto ((ItemMenu)itemdemenu) como argumento del constructor
        }
        virtual public double VerPrecio()
        {
            precio = 0;
            for(int i=0; i<menu.Count;i++)
            {
                precio+=((ItemMenu)menu[i]).Precio;
            }
            if (precio > 2000)
            {
                precio *= 0.95;
            }
            return precio;
        }
        public void AgregarItem(ItemMenu menu, int cantidad)
        {
            for (int i=0; i<cantidad; i++)
            {
                this.menu.Add(menu);
            }            
        }
        public string ToString()
        { return cliente; }
    }
}
