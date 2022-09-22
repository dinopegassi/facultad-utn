using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{

        class Strings
        {
            public string[] CrearVector8(int cant)
            {
                string[] datos = new string[cant];
                Random valor = new Random();
                for (int i = 0; i <= datos.Length - 1; i++)
                {
                    datos[i] = (valor.Next(10000000, 99999999)).ToString();
                }
                return datos;
            }

            public string[] CrearVector32(int cant)
            {

                int length = 32;
                StringBuilder str_build = new StringBuilder();
                Random random = new Random();
                string[] datos = new string[cant];
                char numero;
                for (int j = 0; j <= cant - 1; j++)
                {
                    for (int i = 0; i < length; i++)
                    {
                        double flt = random.NextDouble();
                        int shift = Convert.ToInt32(Math.Floor(10 * flt));
                        numero = Convert.ToChar(shift + 48);
                        str_build.Append(numero);
                    }
                    datos[j] = str_build.ToString(j, length);
                }
                return datos;
            }

            public void QuickSort(string[] vector, int inicio, int final)
            {
                int i, j, mitad;
                string pivote;
                i = inicio;
                j = final;
                mitad = (inicio + final) / 2;
                pivote = vector[mitad];
                do
                {
                    while (i < final && string.Compare(vector[i], pivote) < 0) i++;
                    while (j > inicio && string.Compare(vector[j], pivote) > 0) j--;
                    if (i <= j)
                    {
                        string temp;
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

            public void BubbleSort(string[] my_array)
            {
                string temp;
                for (int i = 0; i < my_array.Length; i++)
                {
                    for (int j = 0; j < my_array.Length - 1; j++)
                    {
                        if (string.Compare(my_array[j], my_array[j + 1]) > 0)
                        {
                            temp = my_array[j];
                            my_array[j] = my_array[j + 1];
                            my_array[j + 1] = temp;
                        }
                    }
                }
            }

            public void selectionSort(string[] array, int cant)
            {
                string min, temp;
                int minIndex = 0;
                for (int k = 0; k < cant; k++)
                {
                    min = array[k];
                    minIndex = k;
                    for (int j = k + 1; j < cant; j++)
                    {
                        if (string.Compare(array[j], min) < 0)
                        {
                            min = array[j];
                            minIndex = j;
                        }
                    }
                    if (string.Compare(array[k], min) > 0)
                    {
                        temp = array[k];
                        array[k] = min;
                        array[minIndex] = temp;
                    }
                }
            }

            public void merge(string[] arr, int p, int q, int r)
            {
                int i, j, k;
                int n1 = q - p + 1;
                int n2 = r - q;
                string[] L = new string[n1];
                string[] R = new string[n2];
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
                    if (string.Compare(L[i], R[j]) <= 0)
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
            public void mergeSort(string[] arr, int p, int r)
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

