using System;
using System.Collections;

namespace Prog2Guia6Ej1
{
    internal class SistemaCredito
    {
        public int CantCreditos { get; }
        public int CantClientes { get; }

        ArrayList clientes = new ArrayList();
        ArrayList creditos = new ArrayList();
        public Cliente this[int pos]
        {
            get
            {
                return (Cliente)clientes[pos];
            }
        }
        //credito[] arregloCreditos = new credito[100];

        //public credito this[int i]
        //{
        //    get { return arregloCreditos[i]; }
        //    set { arregloCreditos[i] = value; }
        //}

        public Credito OtorgarCredito(Cliente cliente, int monto, int cantCuotas, float interes, DateTime fecha)
        {

        }

        //        public int credito this[int i]{
        //            get{return arregloCreditos[i];}
        //    set{arregloCreditos[i]=value;}}
        //}

    }
}
