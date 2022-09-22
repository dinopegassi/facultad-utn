using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Reales
    {
        public float[] Crearvector32(int cant)
        {
            float[] datos = new float[cant];
            Random valor = new Random();
            for (int i = 0; i <= datos.Length - 1; i++)
            {
                datos[i] = (float)(valor.Next() % float.MaxValue);
            }
            return datos;
        }

        public decimal[] Crearvector128(int cant)
        {
            Random rnd = new Random();
            decimal[] random_array = new decimal[cant];
            for (int index = 0; index < cant; index++)
                random_array[index] = Convert.ToDecimal(rnd.NextDouble());
            return random_array;
        }

        public void QuickSort(decimal[] vector, int inicio, int final)
        {
            int i, j, mitad;
            decimal pivote;
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
                    decimal temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicio < j)
            {
                QuickSort(vector, inicio, j);
            }
            if (i < final)
            {
                QuickSort(vector, i, final);
            }
        }

        public void QuickSort(float[] vector, int inicio, int final)
        {
            int i, j, mitad;
            float pivote;
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
                    float temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicio < j)
            {
                QuickSort(vector, inicio, j);
            }
            if (i < final)
            {
                QuickSort(vector, i, final);
            }
        }

        public void BubbleSort(decimal[] my_array)
        {
            decimal temp = 0;
            for (int i = 0; i < my_array.Length; i++)
            {
                for (int j = 0; j < my_array.Length - 1; j++)
                {
                    if (my_array[j] > my_array[j + 1])
                    {
                        temp = my_array[j];
                        my_array[j] = my_array[j + 1];
                        my_array[j + 1] = temp;
                    }
                }
            }
        }

        public void selectionSort(float[] array, int cant)
        {
            float min = 0, temp = 0;
            int minIndex = 0;
            for (int k = 0; k < cant; k++)
            {
                min = array[k];
                minIndex = k;
                for (int j = k + 1; j < cant; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }
                if (min < array[k])
                {
                    temp = array[k];
                    array[k] = min;
                    array[minIndex] = temp;
                }
            }
        }

        public void selectionSort(decimal[] array, int cant)
        {
            decimal min = 0, temp = 0;
            int minIndex = 0;
            for (int k = 0; k < cant; k++)
            {
                min = array[k];
                minIndex = k;
                for (int j = k + 1; j < cant; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }
                if (min < array[k])
                {
                    temp = array[k];
                    array[k] = min;
                    array[minIndex] = temp;
                }
            }
        }

        public void BubbleSort(float[] my_array)
        {
            float temp = 0;
            for (int i = 0; i < my_array.Length; i++)
            {
                for (int j = 0; j < my_array.Length - 1; j++)
                {
                    if (my_array[j] > my_array[j + 1])
                    {
                        temp = my_array[j];
                        my_array[j] = my_array[j + 1];
                        my_array[j + 1] = temp;
                    }
                }
            }
        }

        public void merge(float[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            float[] L = new float[n1];
            float[] R = new float[n2];
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
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(float[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }
        public void merge(decimal[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            decimal[] L = new decimal[n1];
            decimal[] R = new decimal[n2];
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
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(decimal[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }
    }
}
