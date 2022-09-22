using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Guia7Ej1
{
    internal class Personaje : IObservable
    {

        private int posicionActual;
        public int PosicionActual 
        {
            get
            {
                return posicionActual;
            }
            private set
            {
                if (value != posicionActual)
                {
                    PosicionAnterior = posicionActual;
                    posicionActual = value;
                    NotificarPosicionATodos();
                }
            }
        }
        private int posicionAnterior;

        public int PosicionAnterior
        {
            get
            {
                return posicionAnterior;
            }
            private set
            {
                if (value != posicionAnterior)
                {
                    posicionAnterior = value;
                    NotificarPosicionATodos();
                }
            }
        }

        ArrayList observadores;

        public Personaje()
        {
            observadores = new ArrayList();
            PosicionActual = 0;
            PosicionAnterior = 0;
        }
        public void Desplazar(Juego tablero)
        {
            int i = Juego.Azar.Next(tablero.Renglones);
            int j = Juego.Azar.Next(tablero.Columnas);



            PosicionActual = tablero.ToCeldaIndice(i, j);
        }
        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
            observador.NotificarPosicion(this);
        }
        public void QuitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }
        public void NotificarPosicionATodos()
        {
            foreach (IObservador observ in observadores)
            {
                observ.NotificarPosicion(this);
            }
        }
    }
}
