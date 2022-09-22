namespace DCCbook3
{
    internal class MaximoSubarreglo
    {
        int[] arreglo;
        int[] indice;
        int[] indiceMaxLocal;
        int[] indiceMaxGlobal;
        int sum;
        int sumMaxGlobal;
        int sumMaxLocal;

        public int Sum
        {
            get
            {
                return sum;
            }
        }


        public MaximoSubarreglo(int tamanio)
        {
            arreglo = new int[tamanio];
            indice = new int[2] { 0, 0 };
            indiceMaxLocal = new int[2] { 0, 0 };
            indiceMaxGlobal = new int[2] { 0, 0 };
            sum = 0;
            sumMaxLocal = 0;
            sumMaxGlobal = 0;
        }

        public void calcularMaximoSubarrglo(int[] arreglito)
        {
            for (int i = 0; i < arreglito.Length; i++)
            {
                this.sumarEnAcumulador();
                if (i >= arreglito.Length - 1)
                {
                    this.finalizador();
                }
                if (arreglito[i] >= 0)
                {

                }
                else
                {
                    
                }
            }
        }

        public void sumarEnAcumulador()
        {
            sum++;
        }
        public void finalizador()
        {
            this.compararMax(sumMaxLocal, sumMaxGlobal);
            this.reseteoInterno(arreglo.Length);
        }
        public void compararMax(int sumLocal, int sumGlobal)
        {
            if (sumLocal < sumGlobal)
            {
                sumGlobal = sumLocal;
                indiceMaxGlobal[0] = indiceMaxLocal[0];
                indiceMaxLocal[1] = indiceMaxLocal[1];
            }
        }
        public void compararSumas(int sumLocal, int sumComun)
        {
            if (sumComun > sumLocal)
            {

            }
        }
        public void reseteoInterno(int indice)
        {
            if (indice > arreglo.Length - 1)
            {
                return;
            }
            else
            {
                this.indice[0] = indice + 1;
                this.indice[1] = indice + 1;
                this.indiceMaxLocal[0] = indice + 1;
                this.indiceMaxLocal[1] = indice + 1;
            }
        }
        public void calcularIndice(int[] arreglito)
        {

        }
        public void reseteoTotal()
        {
            for (int i = 0; i < indice.Length; ++i)
            {
                indice[i] = 0;
                indiceMaxLocal[i] = 0;
                indiceMaxGlobal[i] = 0;
            }
            this.sum = 0;
            this.sumMaxLocal = 0;
            this.sumMaxGlobal = 0;
        }
    }
}
