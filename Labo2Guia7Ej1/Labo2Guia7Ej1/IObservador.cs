using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Guia7Ej1
{
    //public class IObservador
    //{
    //    internal void NotificarPosicion(IObservable sender)
    //    {

    //    }
    //}

    public interface IObservador
    {
        void NotificarPosicion(IObservable sender);
    }
}
