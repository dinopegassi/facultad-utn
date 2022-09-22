//using BorradLaboratorioTP3Ejercicio2or;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioTP3Ejercicio2
{
    //public class tuvieja
    //{
    //    public static void Main(string[] args)
    //    {
    //        Jugador cosorolo = new Jugador("carlos", 32);
    //        cosorolo.CambiarEstado(true);
    //    }
    //}

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
