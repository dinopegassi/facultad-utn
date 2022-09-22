using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2GuiaEj1
{
    internal class Ordenar
    {

        public void QuickSortRec(ulong[] a, int l, int r)
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
        public void QuickSortRec(ushort[] a, int l, int r)
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
        public void QuickSortRec(string[] a, int l, int r)
        {
            //partición
            string p = a[l];
            int m = l + 1;
            int n = r;
            string aux = "";
            
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
        public void QuickSortIter()
        {

        }
        public void Merge()
        {

        }
        public void Seleccion()
        {

        }
        public void Burbuja()
        {

        }
        public static void QuickSort(int[] a, int l, int r)
        {
            //partición
            int p = a[l];
            int m = l + 1;
            int n = r;
            int aux = 0;

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
                    quickSort(a, l, n - 1);
                if (n + 1 <= r) //agregado
                    quickSort(a, n + 1, r);
            }
        }

    }
}
