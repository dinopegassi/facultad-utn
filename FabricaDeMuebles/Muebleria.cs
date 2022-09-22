using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FabricaDeMuebles
{
    class Muebleria
    {
        ArrayList lista = new ArrayList();
        public string Cliente { get; private set; }
        public string Direccion { get; set; }
        public int CantProductos
        {
            get
            {
                return lista.Count;
            }
        }
        public double CostoTotal { get; private set; }
        public Producto this[int index]
        {   get
            { /* return the specified index here */
                return (Producto)lista[index];    }
            set
            { /* set the specified index to value here */
                lista[index] = value;   }
        }
        public Muebleria(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }
        public void AgregarProducto (Producto prod)
        {
            lista.Add(prod);
        }
        public void Ordenar()
        { lista.Sort(); }
    }
}
