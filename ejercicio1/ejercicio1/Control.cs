using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{
    class Control
    {
        int[] tiempos;
        int vueltas, menorVuelta, menorTiempo, vueltasMayores;
        double promedio=0;
        public Control(int totalVueltas)
        {
          vueltas = 0;
          tiempos = new int[totalVueltas]; 
          vueltasMayores=0;
        }
        public void AgregarTiempo(int seg)
        {
          if (vueltas < tiempos.Length)
          {
              tiempos[vueltas] = seg;
              
              if (vueltas == 0)
              {
                 menorTiempo = seg;
                 menorVuelta = 0;
              }
              else
                 if (seg < menorTiempo)
                 {
                     menorTiempo = seg;
                     menorVuelta = vueltas;
                 }
              vueltas++;
           }
            
        }
        public double VerPromedio()
        {
          if (vueltas == tiempos.Length)
          {
              for (int i=0; i< vueltas;i++)
                    promedio+=tiempos[i];
              promedio /=vueltas;
          }
        return promedio;
        }
        public int VueltaMenor
        {
            get {return menorVuelta+1;}
        }
        public void ContarVueltasMayores()
        {
            for (int i = 0; i < Vueltas; i++)
                if (tiempos[i] < promedio)
                    VueltasMayor++;
        }
        public int VueltasMayor
        {
           set {vueltasMayores=value;}
           get {return vueltasMayores;} 
        }
        public int Vueltas
        {
            get { return vueltas; }
        }
    }
}
