using System;

namespace Prog2GuiaEj1
{
    internal class Ordenar
    {
        public static void QuickSortRec(ulong[] a, int l, int r)
        {
            //partición
            ulong p = a[l];
            int m = l + 1;
            int n = r;
            ulong aux = 0;

            while (m <= n)//hasta que se crucen
            {
                while (m <= r && p >= a[m]) m++;
                while (n > l && p <= a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[l] = a[n];
            a[n] = p;
            //fin partición

            //if (l < r) //no tiene sentido
            {
                if (l <= n - 1) //agregado
                    QuickSortRec(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    QuickSortRec(a, n + 1, r);
            }
        }
        public static void QuickSortRec(ushort[] a, int l, int r)
        {
            //partición
            ushort p = a[l];
            int m = l + 1;
            int n = r;
            ushort aux = 0;

            while (m <= n)//hasta que se crucen
            {
                while (m <= r && p >= a[m]) m++;
                while (n > l && p <= a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[l] = a[n];
            a[n] = p;
            //fin partición

            //if (l < r) //no tiene sentido
            {
                if (l <= n - 1) //agregado
                    QuickSortRec(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    QuickSortRec(a, n + 1, r);
            }
        }
        public static void QuickSortRec(string[] a, int l, int r)
        {
            //partición
            float p = Convert.ToSingle(a[l]);
            int m = l + 1;
            int n = r;
            string aux = "";

            while (m <= n)//hasta que se crucen
            {
                while (m <= r && p >= Convert.ToSingle(a[m])) m++;
                while (n > l && p >= Convert.ToSingle(a[n])) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[l] = a[n];
            a[n] = p.ToString();
            //fin partición

            //if (l < r) //no tiene sentido
            {
                if (l <= n - 1) //agregado
                    QuickSortRec(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    QuickSortRec(a, n + 1, r);
            }
        }
        public static void QuickSortRec(float[] a, int l, int r)
        {
            //partición
            float p = a[l];
            int m = l + 1;
            int n = r;
            float aux = 0;

            while (m <= n)//hasta que se crucen
            {
                while (m <= r && a[m].CompareTo(p) <= 0) m++;
                while (n > l && a[n].CompareTo(p) <= 0) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[l] = a[n];
            a[n] = p;
            //fin partición

            //if (l < r) //no tiene sentido
            {
                if (l <= n - 1) //agregado
                    QuickSortRec(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    QuickSortRec(a, n + 1, r);
            }
        }
        public static void QuickSortRec(decimal[] a, int l, int r)
        {
            //partición
            decimal p = a[l];
            int m = l + 1;
            int n = r;
            decimal aux = 0;

            while (m <= n)//hasta que se crucen
            {
                while (m <= r && p >= a[m]) m++;
                while (n > l && p >= a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[l] = a[n];
            a[n] = p;
            //fin partición

            //if (l < r) //no tiene sentido
            {
                if (l <= n - 1) //agregado
                    QuickSortRec(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    QuickSortRec(a, n + 1, r);
            }
        }

        public static void QuickSortIter(ulong[] a, int l, int r)
        {
            int[] pila = new int[r - l + 1];
            int topeDePila = -1;
            pila[++topeDePila] = l;
            pila[++topeDePila] = r;

            while (topeDePila >= 0)
            {
                r = pila[topeDePila--];
                l = pila[topeDePila--];

                ulong aux;
                ulong pivote = a[a.Length - 1];

                int i = l - 1;
                for (int j = l; j <= r - 1; j++)
                {
                    if (a[j] <= pivote)
                    {
                        i++;
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
                aux = a[i + 1];
                a[i + 1] = a[r];
                a[r] = aux;

                int p = i + 1;

                if (p - 1 > l)
                {
                    pila[++topeDePila] = l;
                    pila[++topeDePila] = p - 1;
                }

                if (p - 1 < r)
                {
                    pila[++topeDePila] = p + 1;
                    pila[++topeDePila] = r;
                }
            }
        }
        public static void QuickSortIter(string[] a, int l, int r)
        {
            int[] pila = new int[r - l + 1];
            int topeDePila = -1;
            pila[++topeDePila] = l;
            pila[++topeDePila] = r;

            while (topeDePila >= 0)
            {
                r = pila[topeDePila--];
                l = pila[topeDePila--];

                string aux;
                string pivote = a[a.Length - 1];

                int i = l - 1;
                for (int j = l; j <= r - 1; j++)
                {
                    if (a[j].CompareTo(pivote) <= 0)
                    {
                        i++;
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
                aux = a[i + 1];
                a[i + 1] = a[r];
                a[r] = aux;

                int p = i + 1;

                if (p - 1 > l)
                {
                    pila[++topeDePila] = l;
                    pila[++topeDePila] = p - 1;
                }

                if (p - 1 < r)
                {
                    pila[++topeDePila] = p + 1;
                    pila[++topeDePila] = r;
                }
            }
        }
        public static void QuickSortIter(short[] a, int l, int r)
        {
            int[] pila = new int[r - l + 1];
            int topeDePila = -1;
            pila[++topeDePila] = l;
            pila[++topeDePila] = r;

            while (topeDePila >= 0)
            {
                r = pila[topeDePila--];
                l = pila[topeDePila--];

                short aux;
                short pivote = a[a.Length - 1];

                int i = l - 1;
                for (int j = l; j <= r - 1; j++)
                {
                    if (a[j] <= pivote)
                    {
                        i++;
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
                aux = a[i + 1];
                a[i + 1] = a[r];
                a[r] = aux;

                int p = i + 1;

                if (p - 1 > l)
                {
                    pila[++topeDePila] = l;
                    pila[++topeDePila] = p - 1;
                }

                if (p - 1 < r)
                {
                    pila[++topeDePila] = p + 1;
                    pila[++topeDePila] = r;
                }
            }
        }
        public static void QuickSortIter(float[] a, int l, int r)
        {
            int[] pila = new int[r - l + 1];
            int topeDePila = -1;
            pila[++topeDePila] = l;
            pila[++topeDePila] = r;

            while (topeDePila >= 0)
            {
                r = pila[topeDePila--];
                l = pila[topeDePila--];

                float aux;
                float pivote = a[a.Length - 1];

                int i = l - 1;
                for (int j = l; j <= r - 1; j++)
                {
                    if (a[j] <= pivote)
                    {
                        i++;
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
                aux = a[i + 1];
                a[i + 1] = a[r];
                a[r] = aux;

                int p = i + 1;

                if (p - 1 > l)
                {
                    pila[++topeDePila] = l;
                    pila[++topeDePila] = p - 1;
                }

                if (p - 1 < r)
                {
                    pila[++topeDePila] = p + 1;
                    pila[++topeDePila] = r;
                }
            }
        }
        public static void QuickSortIter(decimal[] a, int l, int r)
        {
            int[] pila = new int[r - l + 1];
            int topeDePila = -1;
            pila[++topeDePila] = l;
            pila[++topeDePila] = r;

            while (topeDePila >= 0)
            {
                r = pila[topeDePila--];
                l = pila[topeDePila--];

                decimal aux;
                decimal pivote = a[a.Length - 1];

                int i = l - 1;
                for (int j = l; j <= r - 1; j++)
                {
                    if (a[j] <= pivote)
                    {
                        i++;
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
                aux = a[i + 1];
                a[i + 1] = a[r];
                a[r] = aux;

                int p = i + 1;

                if (p - 1 > l)
                {
                    pila[++topeDePila] = l;
                    pila[++topeDePila] = p - 1;
                }

                if (p - 1 < r)
                {
                    pila[++topeDePila] = p + 1;
                    pila[++topeDePila] = r;
                }
            }
        }
        public static void Seleccion(ushort[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[j] < arreglo[minimo])
                        minimo = j;

                ushort aux = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = aux;
            }
        }
        public static void Seleccion(ulong[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[j] < arreglo[minimo])
                        minimo = j;

                ulong aux = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = aux;
            }
        }
        public static void Seleccion(float[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[j] < arreglo[minimo])
                        minimo = j;

                float aux = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = aux;
            }
        }
        public static void Seleccion(decimal[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[j] < arreglo[minimo])
                        minimo = j;

                decimal aux = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = aux;
            }
        }
        public static void Seleccion(string[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[i].CompareTo(arreglo[j]) > 0)
                        minimo = j;

                string aux = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = aux;
            }
        }
        public static void Burbuja(ushort[] valores)
        {
            //ALGORITMO BURBUJA(El mejor de su tipo*):
            int i, j;
            ushort aux;
            for (i = 0; i < valores.Length - 1; i++)
            {
                for (j = i + 1; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
        public static void Burbuja(ulong[] valores)
        {
            //ALGORITMO BURBUJA(El mejor de su tipo*):
            int i, j;
            ulong aux;
            for (i = 0; i < valores.Length - 1; i++)
            {
                for (j = i + 1; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
        public static void Burbuja(float[] valores)
        {
            //ALGORITMO BURBUJA(El mejor de su tipo*):
            int i, j;
            float aux;
            for (i = 0; i < valores.Length - 1; i++)
            {
                for (j = i + 1; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
        public static void Burbuja(decimal[] valores)
        {
            //ALGORITMO BURBUJA(El mejor de su tipo*):
            int i, j;
            decimal aux;
            for (i = 0; i < valores.Length - 1; i++)
            {
                for (j = i + 1; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
        public static void Burbuja(string[] valores)
        {
            //ALGORITMO BURBUJA(El mejor de su tipo*):
            int i, j;
            uint aux;
            for (i = 0; i < valores.Length - 1; i++)
            {
                for (j = i + 1; j < valores.Length; j++)
                {
                    if (valores[i].CompareTo(valores[j]) < 0)
                    {
                        aux = Convert.ToUInt32(valores[i]);
                        valores[i] = valores[j];
                        valores[j] = Convert.ToString(aux);
                    }
                }
            }
        }
        //public static void MergeSort(ushort[] arreglo, int izquierda, int derecha)
        //{
        //    int medio = Convert.ToInt32((derecha - izquierda) / 2);
            


        //    Merge(arreglo, medio, derecha);

        //}
    }
}
