using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Guia7Ej1
{
    public interface IObservable
    {
        void AgregarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void NotificarPosicionATodos();
    }
}
