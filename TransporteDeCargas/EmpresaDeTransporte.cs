using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteDeCargas
{
    class EmpresaDeTransporte
    {
        const double expreso = 5.25, full = 8.95; //precio por kilo
        private Contenedor[] c = new Contenedor[100]; //vector de objetos
        private int cantidadC = 0;          //contador, indice, ID

        private int[] multas = new int[20]; //guardo el indice donde c[] tiene multas (es 1 forma...) 
        private int indiceMultas = 0;       //contador e indice multas
        private double cobroTotal;
        public int Multas
        { get { return indiceMultas; } }

        public Contenedor AgregarContenedor(string nombre,
                                            bool tipo,
                                            double capacidad,
                                            int a, int b, int c)
        { 
            Contenedor cLocal = new Contenedor (cantidadC+1, nombre, tipo,
                                                      capacidad, a, b, c);
            this.c[cantidadC] = cLocal;
            cantidadC++;
            return cLocal;
        }
        //calcular podria ir en agregar...
        //calcula en la posicion anterior
        //devuelve el forms....podria devolver otra clase...
        public Ticket VerTicket(bool hora, bool noSeTrabaja) 
        {
            double precioBase, recargoPeso, precioHora;
            bool multado = false;

            // (Peso Real) - (Capacidad) = valor en intervalo
            int peso = c[cantidadC - 1].CalcularPesoReal();
            double dif = peso - c[cantidadC - 1].CapacidadMaximaKg;

            // ( -∞,-100] a 10%
            // (-100,-10] b  7%
            // ( -10,  5] c -5%
            // (   5, 50] d 18%
            // (  50,  ∞) e 80% + multa // intervalos a seguir
            if (dif > -100)
            {
                if (dif > -10)
                {
                    if (dif > 5)
                    {
                        if (dif > 50)
                        {
                            dif = 0.80; //e
                            multas[indiceMultas] = cantidadC-1; //guarda indice
                            indiceMultas++; //contador e indice de mi vector
                            multado = true;
                        }
                        else dif = 0.18; //d
                    }
                    else dif = -0.05; //c 
                }
                else dif = 0.07; //b
            }
            else dif = 0.10; //a

            // $ BASE y $ RecargoxPeso
            if (c[cantidadC - 1].Expreso) //ve si expreso es V o F
            {   // expreso (V)
                precioBase = peso * expreso; // PRECIO x EXPRESO
                recargoPeso = peso * expreso * dif;
            }
            else
            {   // full (F)
                precioBase = peso * full; // PRECIO x FULL
                recargoPeso = peso * full * dif; 
            }

            // RECARGO x HORARIO
            string horaPalabra;
            if (hora)
            {
                precioHora = (precioBase + recargoPeso) * -0.05; //de 6:00 a 20:00 (5% bonif)
                horaPalabra = "Bonif. 5%: ";
            }
            else
            {
                precioHora = (precioBase + recargoPeso)* 0.04; //sino (4% recargo)
                horaPalabra = "Recargo 4%: ";
            }

            // RECARGO x DIA
            int feriado = 0;
            if (noSeTrabaja)
                feriado = 1000; //feriados o dom + $1000

            // PRECIO TOTAL
            double precio = precioBase + recargoPeso + precioHora + feriado;
            cobroTotal += precio;
            
            //ventana modal ticket
            Ticket ticket = new Ticket();
            ticket.listBox1.Items.Clear();
            if (multado)
            {
                ticket.listBox1.Items.Add(string.Format("{0,30}", "MULTADO LCDTM"));
                ticket.listBox1.ForeColor = System.Drawing.Color.Red;
            }
            ticket.listBox1.Items.Add(string.Format("Precio Base:        {0,28:C2}", precioBase));
            ticket.listBox1.Items.Add(string.Format("Recargo Peso ({0:P}): {1,21:C2}",dif, recargoPeso));
            ticket.listBox1.Items.Add(string.Format("Horario ({0}):     {1,19:C2}", horaPalabra, precioHora));
            ticket.listBox1.Items.Add(string.Format("Domingo o feriados:{0,27:C2}", feriado));
            ticket.listBox1.Items.Add(string.Format("Total:               {0,28:C2}", precio));

            return ticket;
        }
        public Contenedor VerContenedor(int i)
        {
            return c[i];
        }
        public string[] VerMultas()
        {
            //vector de string (tamaño del contadorMultas)
            string[] cadena = new string[indiceMultas];

            for (int i = 0; i < cadena.Length; i++)
            {
                cadena[i] = "Id: " + c[multas[i]].Id + "  Capacidad: " + c[multas[i]].CalcularPesoReal();
            }
            return cadena;
            //devuelvo la cadena en un vector, este metodo se puede hacer de varias formas:
            //*devolver el vector multas[] y que se maneje el forms
            //*devolver un vector de objetos nuevo, los objetos enteros con multa
        }
        public double CobroTotal()
        { return cobroTotal; }
        public int ContGenerados()
        { return cantidadC; }
        public double CalcularPesoProm()
        {
            double peso=0;
            for (int i = 0; i < cantidadC; i++)
            {
                peso += c[i].CalcularPesoReal();
            }
            peso = peso / cantidadC;
            return peso;
        }
        public string CajaMasUsada()
        {
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < cantidadC; i++)
            {
                a += this.c[i].CantA;
                b += this.c[i].CantB;
                c += this.c[i].CantC;
            }
            string cajaMasUsada="";
            if (!(a > b & a > c))
                if (!(b > a & b > c))
                    if (!(c > a & c > b))
                        cajaMasUsada = "Hay al menos 2 cajas en igual cant.";
                    else
                        cajaMasUsada = "La caja mas utilizada es del tipo C";
                else
                    cajaMasUsada = "La caja mas utilizada es del tipo B";
            else
                cajaMasUsada = "La caja mas utilizada es del tipo A";
            return cajaMasUsada;
        }

    }
}
