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
        public double TotalRecaudado { get; private set; }
        public int TotalDePedidos { get; private set; }
        ArrayList listaPedidos = new ArrayList();
        public void AgregarPedido(Pedido p)
        {
            listaPedidos.Add(p);
        }
        public void Ordenar()
        {
            this.QuickSortear(listaPedidos, 0, listaPedidos.Count-1);
        }
        public Pedido VerPedido(int numero)
        {
            return (Pedido)listaPedidos[numero];
        }
        public void QuickSortear(ArrayList arreglito, int izq, int der)
        {
            int j = izq - 1;
            Object aux;
            Object pivote = (Pedido)listaPedidos[der];

            for (int i=0; i < der; i++)
            {
                if (((Pedido)listaPedidos[i]).Precio() < ((Pedido)pivote).Precio())
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
