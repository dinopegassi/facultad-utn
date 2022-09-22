using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Labo2TP1
{
    internal class Isla
    {
        protected static Random seed = new Random();
        protected int Dias { get; private set; }
        protected int Pasos { get; private set; }
        protected int[] Grilla { get; private set; }
        protected List<Raton> Ratones { get; private set; }
        protected List<Queso> Quesos { get; private set; }

        public Isla(int cantRatones, int cantQueso, int[] grilla):this(cantRatones / 2,
                                                                       (cantRatones / 2),
                                                                       cantQueso,
                                                                       grilla)
        { 
        }
        public Isla(int cantMachos, int cantHembras,int cantQueso, int[] grilla)
        {
            Grilla = grilla;
            Ratones = new List<Raton>();
            Quesos = new List<Queso>();
            for (int i = 0; i < cantMachos; i++)
            {
                Random rand = new Random(seed.Next());
                int renglon = rand.Next(1, grilla[0]);
                int columna = rand.Next(1, grilla[1]);
                Ratones.Add(new Raton(renglon, columna, true));
            }
            for (int i = 0; i < cantHembras; i++)
            {
                Random rand = new Random(seed.Next());
                Ratones.Add(new Raton(rand.Next(1, grilla[0]), rand.Next(1, grilla[1]), false));
            }
            for (int i = 0; i < cantQueso; i++)
            {
                Random rand = new Random(seed.Next());
                Quesos.Add(new Queso(rand.Next(1, grilla[0]), rand.Next(1, grilla[1])));
            }
        }
        virtual public ArrayList HacerUnPaso()
        {
            ArrayList informe = new ArrayList();
            Ratones.Sort();
            for (int i = 0; i < Ratones.Count; i++)
            {
                //int observador = 0; //paso referencia(asi se q paso)
                if (Ratones[i].Mover()) // if logro moverse
                {
                    bool encontroQueso = false;
                    int j = 0;
                    while(!encontroQueso && j<Quesos.Count) //busqueda (implementar binaria)
                    {
                        if (Ratones[i].Posicion[0] == Quesos[j].Posicion[0] &&
                            Ratones[i].Posicion[1] == Quesos[j].Posicion[1]) //*/// si encuentra come
                        //int pos = Quesos.BinarySearch(Ratones[i].Posicion[0]); //como pingo se usa binary aca
                        {
                            informe.Add(Ratones[i].Comer(Quesos[j]));
                            if (Quesos[j].Porcion == 0)
                                Quesos.RemoveAt(j);
                            encontroQueso = true;
                        }
                        else j++;
                    }
                    if (!encontroQueso && Ratones[i].PasosSinComer==4)
                    {
                        informe.Add(Ratones[i].ToString() + " murio de hambre");
                        Ratones.RemoveAt(i);
                    }
                }
                else
                {   informe.Add(Ratones[i].ToString() + " murio ahogado");
                    Ratones.RemoveAt(i);
                }
            }
            if (Quesos.Count == 0)
                informe.Add("No hay mas Quesos");
            if (Ratones.Count == 0)
                informe.Add("No hay mas Ratones");
            return informe;
        }
        public void DistribuirAlimento(int cant)
        {
            // q pingo hace
            // no se, pero esta re hdp este problema...
            // no es dificil, pero me rompe soberanamente la tocha
        }
        public void AgregarRatones(Raton rata)
        { 
            Ratones.Add(rata); 
        }
    }
}
