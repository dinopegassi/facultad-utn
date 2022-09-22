using System;

namespace DCCbook1
{
    internal class ArrayPrefijoSufijo
    {
        ulong[] Arreglo { get; }
        public ulong EnteroPrefijo { get; private set; }
        public ulong EnteroSufijo { get; private set; }
        Random enteros;
        public ArrayPrefijoSufijo(int tamanio)
        {
            Arreglo = new ulong[tamanio];
            EnteroPrefijo = 1;
            EnteroSufijo = 1;
            //foreach (ulong i in Arreglo)
            //{
            //    enteros = new Random(tamanio - (int)i * 10);
            //    Arreglo[i] = (ulong)enteros.Next(1,10);
            //    EnteroSufijo *= Arreglo[i];
            //}
            for (int i = 0; i < tamanio; ++i)
            {
                enteros = new Random(tamanio - (int)i * 10);
                Arreglo[i] = (ulong)enteros.Next(1, 10);
                EnteroSufijo *= Arreglo[i];
            }
        }

        public ulong ModificarPrefijo(int i)
        {
            if (i > 0)
            {
                EnteroPrefijo *= Arreglo[i - 1];
                return EnteroPrefijo;
            }
            else
            {
                return 1;
            }
        }
        public ulong ModificarSufijo(int i)
        {
            if (i < Arreglo.Length)
            {
                Convert.ToUInt64(EnteroSufijo /= Arreglo[i]);
                return EnteroSufijo;
            }
            else
            {
                return 1;
            }
        }

        public ulong CalcularArregloIndice(int i)
        {
            return this.ModificarPrefijo(i) * this.ModificarSufijo(i);
        }

        public void ReiniciarVariables()
        {
            EnteroPrefijo = 1;
            EnteroSufijo = 1;
            foreach (ulong i in Arreglo)
            {
                EnteroSufijo *= Arreglo[i];
            }
        }
        public ulong VerArregloIndice(int i)
        {
            return this.Arreglo[i];
        }
        public int VerArregloLength()
        {
            return Arreglo.Length;
        }






        //public Contenedor[] TodosLosContenedores { get; private set; } = new Contenedor[100];
        //public Contenedor[] Multados { get; private set; } = new Contenedor[20];

        //public ContenedoresGeneral(Contenedor[] containers)
        //{
        //    TodosLosContenedores = containers;
        //}

        //public int 
    }
}
