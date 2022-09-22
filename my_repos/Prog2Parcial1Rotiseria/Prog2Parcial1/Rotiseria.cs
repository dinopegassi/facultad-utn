using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1
{
    internal class Rotiseria
    {
        public double TotalRecaudado
        {
            get
            {
                double total=0;
                for(int i=0;i<TotalDePedidos;i++)
                {
                    total += ((Pedido)listaPedidos[i]).VerPrecio();
                }
                return total;
            }
        }
        public int TotalDePedidos { get { return listaPedidos.Count; } }
        public ArrayList listaPedidos { get; private set; }
        public Rotiseria()
        { listaPedidos = new ArrayList(); }
        public void AgregarPedido(Pedido p)
        {
            listaPedidos.Add(p);
        }
        public void Ordenar()
        {
            //this.QuickSortear(listaPedidos, 0, listaPedidos.Count-1);
            //Metodo.QS(listaPedidos, 0, listaPedidos.Count - 1);
        }
        public Pedido VerPedido(int numero)
        {
            return (Pedido)listaPedidos[numero-1];
        }
        public void QuickSortear(ArrayList arreglito, int izq, int der)
        {
            int j = izq - 1;
            Object aux;
            Object pivote = (Pedido)listaPedidos[der];

            for (int i=0; i < der; i++)
            {
                if (((Pedido)listaPedidos[i]).VerPrecio() < ((Pedido)pivote).VerPrecio())
                {
                    j++;
                    aux = listaPedidos[i];
                    listaPedidos[i] = listaPedidos[j];
                    listaPedidos[j] = aux;
                }
            }

            /* probemos a ver si esto es correcto...
             * caso contrario se escribe
             * 
             * Collections.Swap(listaPedidos, ...)
             */
            listaPedidos[der] = listaPedidos[j + 1];
            listaPedidos[j + 1] = pivote;

            if (izq < j)
            {
                QuickSortear(arreglito, izq, j);
            }
            if (j+2 < der)
            {
                QuickSortear(arreglito, j+2, der);
            }
        }
    }
}
