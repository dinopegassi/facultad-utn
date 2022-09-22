using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2EjemploCrearExcepcion
{
    internal class Excepcion:ApplicationException
    {
        public Excepcion():base()
        {
            
        }
        public Excepcion(string msg):base(msg)
        {
            
        }
        public Excepcion(string msg, ApplicationException inner):base(msg, inner)
        {

        }
    }



    public class ProbandoTarjetaDeCredito
    {
        readonly long _coso;
        public long Coso
        {
            get { return _coso; }
        }

        public ProbandoTarjetaDeCredito(long @int)
        {
            _coso = @int;
            if (@int.ToString().Length != 16)
            {
                throw new Excepcion("error 404: las tarjetas de cred tienen 16 caracteres, no menos ni mas");
            }
        }
    }
}
