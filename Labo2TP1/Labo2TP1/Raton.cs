using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class Raton:Animal
    {
        int contador;
        public bool Sexo { get; private set; }
        public bool Embarazada { get; private set; }
        public bool Satisfecho { get; private set; }
        public Raton(int[] posicion, bool sexo) : base(posicion)
        {
            this.Embarazada = false;
            this.Sexo = sexo;
            this.Satisfecho = false;
            contador = 0;
        }
        public void Reproducir(Raton raton)
        {
            if (this.Sexo != raton.Sexo && !this.Sexo && !this.Embarazada)
            {
                this.Embarazada = true;
            }
            contador = 2;
        }
        public override void Comer()
        {
            throw new NotImplementedException();
        }
        public override void Mover()
        {
            if (this.Embarazada) { contador--; }
        }
        public override void Vivir()
        {
            throw new NotImplementedException();
        }
    }
}
