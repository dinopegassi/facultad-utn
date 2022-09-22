using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class IslaConGatos : Isla
    {
        public List<Gato> Gatos { get; private set; }
        public IslaConGatos(int cantRatones, int cantGatos, int[] grilla) : base(cantRatones, (int)(cantRatones*0.5), grilla)
        { 
            Gatos = new List<Gato>();
            for (int i = 0; i < cantGatos; i++)
            {
                Random rand = new Random(seed.Next());
                Gatos.Add(new Gato(rand.Next(1, grilla[0]), rand.Next(1, grilla[1])));
            }
        }
        public IslaConGatos(int machos, int hembras, int cantGatos, int[] grilla) : base(machos, hembras, 
                                                                                        (int)((machos+hembras)* 0.5), 
                                                                                        grilla)
        { 
            Gatos = new List<Gato>();
            for (int i = 0; i < cantGatos; i++)
            {
                Random rand = new Random(seed.Next());
                Gatos.Add(new Gato(rand.Next(1, grilla[0]), rand.Next(1, grilla[1])));
            }
        }
        //public void AgregarGato(Gato gato) //se crean y pasan desde el forms nomas
        //{ 
        //    Gatos.Add(gato); 
        //}
        override public ArrayList HacerUnPaso()
        {
            ArrayList informe = base.HacerUnPaso();
            for (int i = 0; i < Gatos.Count; i++)
            {
                Gatos[i].Mover();

                bool encontroRaton = false;
                int j = 0;
                while (!encontroRaton && j < Ratones.Count) //busqueda (implementar binaria)
                {
                    //if (Gatos[i].Posicion == Ratones[j].Posicion) // si encuentra come
                    if (Gatos[i].Posicion[0] == Ratones[j].Posicion[0] &&
                            Gatos[i].Posicion[1] == Ratones[j].Posicion[1])
                    {
                        informe.Add(Gatos[i].Comer(Ratones[j]));
                        Ratones.RemoveAt(j);
                        encontroRaton = true;
                    }
                    else j++;
                }
                if (!encontroRaton && Gatos[i].DiasSinComer == 4)
                {
                    informe.Add(Gatos[i].ToString() + " murio de hambre");
                    Gatos.RemoveAt(i);
                }
            }
            return informe;
        }
    }
}
