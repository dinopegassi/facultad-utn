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
        string cliente;
        public int Numero { get; }
        protected double precio;
        ArrayList menu = new ArrayList();

        public Pedido(string cliente, int numero)
        {
            this.cliente = cliente;
            Numero = numero;
            //menu = new ArrayList();
            //AgregarItem(itemdemenu, 1)         //como dice "1..*" flashe que el objeto arranca con AL MENOS un pedido,
                                                 //pero no tengo un objeto ((ItemMenu)itemdemenu) como argumento del constructor
        }
        public virtual double Precio()
        {
            this.precio = 0;
            foreach (ItemMenu elemento in menu)
            {
                this.precio+=elemento.Precio;
            }
            if (this.precio > 2000)
            {
                this.precio *= 0.95;
            }
            return this.precio;
        }


        public void AgregarItem(ItemMenu menu, int cantidad)
        {
            for (int i=0; i<cantidad; i++)
            {
                this.menu.Add(menu);
            }            
        }
    }
}
