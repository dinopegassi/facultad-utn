using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Enteros
    {
        public int cantIntercambiosBS { get; set; }
        public int cantComparacionesBS { get; set; }
        public int cantIntercambiosSS { get; set; }
        public int cantComparacionesSS { get; set; }
        public int cantIntercambiosQS { get; set; }
        public int cantComparacionesQS { get; set; }
        public int cantIntercambiosMS { get; set; }
        public int cantComparacionesMS { get; set; }
        public short[] Crearvector16(int cant)
        {

            short[] datos = new short[cant];
            Random valor = new Random();
            for (int i = 0; i <= datos.Length - 1; i++)
            {
                datos[i] = (short)valor.Next(0, short.MaxValue);
            }
            return datos;
        }

        public long[] Crearvector64(int cant)
        {
            Random rnd = new Random();
            long[] random_array = new long[cant];
            for (int index = 0; index <= cant - 1; index++)
                random_array[index] = (long)(rnd.Next()); //* Int64.MaxValue);
            return random_array;
        }

        public void QuickSort(short[] vector, int inicio, int final)
        {
            int i, j, mitad;
            short pivote;
            i = inicio;
            j = final;
            mitad = (inicio + final) / 2;
            pivote = vector[mitad];
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    short temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                    cantIntercambiosQS++;
                }
            } while (i <= j);

            cantComparacionesQS++;
            if (inicio < j)
            {
                QuickSort(vector, inicio, j);
            }
            cantComparacionesQS++;
            if (i < final)
            {
                QuickSort(vector, i, final);
            }
        }

        public void QuickSort(long[] vector, int inicio, int final)
        {
            int i, j, mitad;
            long pivote;
            i = inicio;
            j = final;
            mitad = (inicio + final) / 2;
            pivote = vector[mitad];
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    long temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                    cantIntercambiosQS++;
                }
            } while (i <= j);

            cantComparacionesQS++;
            if (inicio < j)
            {
                QuickSort(vector, inicio, j);
            }
            cantComparacionesQS++;
            if (i < final)
            {
                QuickSort(vector, i, final);
            }
        }

        public void BubbleSort(long[] my_array)
        {
            long temp = 0;
            for (int i = 0; i < my_array.Length; i++)
            {
                for (int j = 0; j < my_array.Length - 1; j++)
                {
                    cantComparacionesBS++;
                    if (my_array[j] > my_array[j + 1])
                    {
                        cantIntercambiosBS++;
                        temp = my_array[j];
                        my_array[j] = my_array[j + 1];
                        my_array[j + 1] = temp;
                    }
                }
            }
        }

        public void selectionSort(long[] array, int cant)
        {
            long min = 0, temp = 0;
            int minIndex = 0;
            for (int k = 0; k < cant; k++)
            {
                min = array[k];
                minIndex = k;
                for (int j = k + 1; j < cant; j++)
                {
                    cantComparacionesSS++;
                    if (array[j] < min)
                    {
                        cantIntercambiosSS++;
                        min = array[j];
                        minIndex = j;
                    }
                }
                cantComparacionesSS++;
                if (min < array[k])
                {
                    cantIntercambiosSS++;
                    temp = array[k];
                    array[k] = min;
                    array[minIndex] = temp;
                }
            }
        }

        public void selectionSort(short[] array, int cant)
        {
            short min = 0, temp = 0;
            int minIndex = 0;
            for (int k = 0; k < cant; k++)
            {
                min = array[k];
                minIndex = k;
                for (int j = k + 1; j < cant; j++)
                {
                    cantComparacionesSS++;
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                        cantIntercambiosSS++;
                    }
                }
                cantComparacionesSS++;
                if (min < array[k])
                {
                    temp = array[k];
                    array[k] = min;
                    array[minIndex] = temp;
                    cantIntercambiosSS++;
                }
            }
        }
        public void BubbleSort(short[] valores)
        {
            for (int i = 0; i < valores.Length - 1; i++)
            {
                for (int j = i + 1; j < valores.Length; j++)
                {
                    cantComparacionesBS++;
                    if (valores[i] > valores[j])
                    {
                        short aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                        cantIntercambiosBS++;
                    }
                }
            }
            //short temp = 0;
            //for (int i = 0; i < my_array.Length - 1; i++)
            //{
            //    for (int j = i+1; j < my_array.Length; j++)
            //    {
            //        if (my_array[i] > my_array[j])
            //        {
            //            temp = my_array[i];
            //            my_array[i] = my_array[j];
            //            my_array[j] = temp;
            //        }
            //    }
            //}
        }

        public void merge(short[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            short[] L = new short[n1];
            short[] R = new short[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                cantComparacionesMS++;
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                cantIntercambiosMS++;
                k++;
            }
            while (i < n1)
            {
                cantIntercambiosMS++;
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                cantIntercambiosMS++;
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(short[] arr, int p, int r)
        {
            cantComparacionesMS++;
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }
        public void merge(long[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            long[] L = new long[n1];
            long[] R = new long[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                cantComparacionesMS++;
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                cantIntercambiosMS++;
                k++;
            }
            while (i < n1)
            {
                cantIntercambiosMS++;
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                cantIntercambiosMS++;
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(long[] arr, int p, int r)
        {
            cantComparacionesMS++;
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
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
    }



}
