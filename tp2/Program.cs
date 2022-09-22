using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{                                                                 /*myTODOlist:

                                                                 Day A. -+-remake menu from pancho's template
                                                                       -+-remember console characters get
                                                                          replaced with any other written on top
                                                                       -+-setWinSize + showCursor +
                                                                           setCursorPos

                                                                 Day B. -+-check functionality.
                                                                       -+-one menu for each stage of this code
                                                                       +(OPTIONAL) mix both templates
                                                                          "cursor"&"ejemploColores" into one

                                                                 Day C. + Bug hunt.

                                                                 (Optional). -+-If time's on your side, develop V2.0
                                                                 w/classes*/
    class Program
    {
        static void Main(string[] args)
        {
            Marco marquito=new Marco();
			marquito.Menu();
            /* Variables para menús: */
            int menu, opcion;
            bool repetir = true, feriado = true;
            //
            const int k1 = 1500, k2 = 1200, k3 = 750, k4 = 150; // precios boletos
            int personas, edad; //personas= cant personas x grupo(pasaporte o individual)
            int edadAcumulador = 0; // Acumulador para promediar edades
            /* Ingreso con Pasaporte:*/

            // Variables finales: //
            int gruposPasaportes = 0, gruposIndividuales = 0;
            double entre10y15years = 0;
            int contadorPersonasIndividual = 0, contadorPersonasxPasaporte = 0;
            double recaudacionPasaportes = 0;

            Console.SetCursorPosition(30, 0);
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Buen dia {0} !", nombre);
                Console.WriteLine("Hoy es dia feriado? \n\n1- Si\n2- No\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        feriado = true;
                        repetir = false;
                        break;
                    case 2:
                        feriado = false;
                        repetir = false;
                        break;
                }
            }
            while (repetir);
            repetir = true;
            // Feriados = true o false
            
            // 1er menu principal- si salis cierra el dia (solo con el 2do menu que confirma)
            do
            {
                Console.Clear();
                Console.WriteLine("Que operacion desea?\n");
                Console.WriteLine("1- Ticket/s individual/es   (Deben ser mayores a 16)\n" +
                    "2- Pasaportes   (Pueden ingresar menores*)\nOtro- Salir\n");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    // inicia caso tickets individuales
                    case 1:
                        Console.Clear();
                        Console.Write("\t\t\tTicket Individual\nCantidad de tickets que desean: ");
                        personas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nValor de la entrada: $ {0}. Confirmar?\n\n1- Si\nOtro- Cancelar operacion\n", personas * k1);
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            //inicia caso confirmar
                            case 1:
                                Console.Clear();
                                Console.Write("\t\t\tTicket Individual\nEdad de la/s persona/s: ");
                                for (int i = 0; i < personas; i++)
                                {
                                    do
                                    {
                                        edad = Convert.ToInt32(Console.ReadLine());
                                        if (edad < 16)
                                        {
                                            Console.Clear();
                                            Console.Write("\t\t\tTicket Individual\nError ! La edad del es insuficiente para acceder." +
                                                "\nReingrese edad: ");
                                        }
                                        // if es menor de 16
                                        else
                                        {
                                            Console.Clear();
                                            Console.Write("\t\t\tTicket Individual\nEdad anterior cargada exitosamente" +
                                                "\nFaltan {0} mas\nIngrese siguiente edad: ", personas - 1 - i);
                                            contadorPersonasIndividual++;
                                            edadAcumulador = edadAcumulador + edad;
                                        }
                                        // if no es menor de 16 + contador personas y acumulador de edad
                                    }
                                    while (edad < 16);
                                    //validador de edad correcta (+16 años)
                                }
                                // for para la cant de personas en 1 ticket individual
                                gruposIndividuales++;
                                Console.Clear();
                                Console.WriteLine("Completado.\nGrupos Individuales ingresados por ahora: {0}\nPresione una tecla", gruposIndividuales);
                                Console.ReadKey();
                                break;
                            //termina caso confirmar (cuenta personas y acumula edades)

                            //cancelar (no cuenta ni acumula nada)
                            default:
                                Console.Clear();
                                Console.WriteLine("Cancelado.\nPresione una tecla");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    // termina caso individuales

                    //inicia caso pasaportes (esta con 2 variables temporales en caso de querer cancelar)
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t\t\tTicket Pasaporte\n* Un adulto mayor a 21 por cada 5 menores de 16\n");
                        Console.Write("Ingrese la cantidad de personas para el pasaporte: ");
                        personas = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            /*tipo1 = mayor a 21 años; tipo2 = entre 20 y 16; tipo3 = entre 15 y 11; tipo4 = entre 10 y 4
                            tipo5 = entre 3 y 0 ; grupo = la suma de ellos  */
                            int tipo1 = 0, tipo2 = 0, tipo3 = 0, tipo4 = 0, tipo5 = 0;
                            int edadAcumuladorTemp = 0;// temporal
                            int entre10y15yearsTemp = 0; //variable temporal
                            for (int i = 0; i < personas; i++)
                            {
                                Console.Clear();
                                Console.Write("\t\t\tTicket Pasaporte\nFaltan {0}\nIngrese sus edades: ", personas - i);
                                edad = Convert.ToInt32(Console.ReadLine());
                                if (edad < 21)
                                {
                                    if (edad < 16)
                                    {
                                        if (edad < 11)
                                        {
                                            if (edad < 4)
                                            { tipo5++; }
                                            else tipo4++;
                                        }
                                        else tipo3++;
                                    }
                                    else tipo2++;
                                }
                                else tipo1++;
                                /* Hasta aca cuenta los tipos*/
                                if (edad >9 & edad < 16)
                                { entre10y15yearsTemp++; }
                                edadAcumuladorTemp = edadAcumuladorTemp + edad;
                                //acumula temporalmente edades y contador10-15.
                            }
                            /*aca termina el for*/

                            int grupoMenores = tipo3 + tipo4 + tipo5;
                            if (tipo1 * 5 < grupoMenores)
                            {
                                edadAcumuladorTemp = 0;  //reset de la variable temporal
                                entre10y15yearsTemp = 0; //reset var. temporal
                                int masMayores = 0; /*Contador de mayores de 21 necesarios respecto de menores*/
                                while ((tipo1 + masMayores) * 5 < grupoMenores)
                                {
                                    masMayores++;
                                }
                                Console.Clear();
                                Console.WriteLine("\t\t\tTicket Pasaporte\n\nError!\tSe necesita {0} mas," +
                                    " mayores de 21 para este grupo\nDebe reingresar.\nPresione una tecla", masMayores);
                                Console.ReadKey();
                            }
                            /* If yes valida que no hay suficientes mayores*/
                            else
                            {
                                int grupo = tipo1 + tipo2 + tipo3 + tipo4 + tipo5;
                                double desc;
                                if ((grupo > 3) & (grupo < 11) & (grupoMenores >= 2))
                                    desc = 0.15;
                                else
                                {
                                    if (grupoMenores == 0)
                                    { desc = 0.10; }
                                    else
                                        desc = 0;
                                }
                                if (feriado)
                                {
                                        desc = desc * 2;
                                }
                                //desc = 1 - desc;
                                double descontar = (tipo1 * k1 + tipo2 * k1 + tipo3 * k2 + tipo4 * k3) * desc;
                                double precioPasaporte = (tipo1*k1+tipo2*k1+tipo3*k2+tipo4*k3)+ (tipo5 * k4) - descontar;
                                /*el tipo 5 no tiene desc de pasaportes*/
                                Console.Clear();
                                Console.WriteLine("\t\t\tTicket Pasaporte\nMonto a cobrar: $ {0}\nDescuento: {1:P}\n1- Confirmar\n" +
                                    "Otro- Cancelar operacion\n", precioPasaporte, desc);
                                opcion = Convert.ToInt32(Console.ReadLine());
                                switch (opcion)
                                {
                                    case 1:
                                        gruposPasaportes++;
                                        recaudacionPasaportes += precioPasaporte;
                                        edadAcumulador += edadAcumuladorTemp;
                                        entre10y15years += entre10y15yearsTemp;
                                        contadorPersonasxPasaporte = contadorPersonasxPasaporte + grupo;
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tTicket Pasaporte\n\nCOMPLETADO\nPresione una Tecla");
                                        Console.ReadKey();
                                        repetir = false;
                                        break;
                                        /*confirma y sale*/

                                    default:
                                        edadAcumuladorTemp = 0;
                                        entre10y15yearsTemp = 0;
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tTicket Pasaporte\n\nCANCELADO\nPresione una tecla.");
                                        Console.ReadKey();
                                        repetir = false;
                                        break;
                                        /*cancela y vuelve al for*/
                                }
                            }
                        }
                        while (repetir);
                        repetir = true;
                        break;
                    // termina caso pasaportes
                }
                //termina menu 1 y comienza el menu 2
                Console.Clear();
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("\n1- Nuevo ticket\nOtro- Cerrar dia y ver resumen\n");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        repetir = true;
                        break;
                    default:
                        repetir = false;
                        break;
                }
                //termina menu 2 (vuelve al 1 o cierra el dia)

            }
            while (repetir);
            // termina el menu 1

            int gruposTotales = gruposPasaportes + gruposIndividuales;
            int personasEnTotal = contadorPersonasIndividual + contadorPersonasxPasaporte;
            double promedioEdades;
            // el if es para que no haya division por 0 y de error.
            {
                if (contadorPersonasIndividual + contadorPersonasxPasaporte == 0)
                    promedioEdades = 0;
                else
                    promedioEdades = edadAcumulador / (contadorPersonasIndividual + contadorPersonasxPasaporte);
            }







            int recaudacionIndividual = contadorPersonasIndividual * k1;
            double recaudacionTotal = (recaudacionPasaportes + recaudacionIndividual);

            Console.Clear();
            Console.WriteLine("Grupos Totales:          {0}", gruposTotales);
            Console.WriteLine("Personas Individuales:   {0}", contadorPersonasIndividual);
            Console.WriteLine("Personas Pasaporte:      {0}", contadorPersonasxPasaporte);
            Console.WriteLine("Entre 10 y 15 años:      {0}", entre10y15years);
            Console.WriteLine("Personas en total:       {0}", personasEnTotal);
            Console.WriteLine("Promedio edades:         {0}", promedioEdades);

            Console.WriteLine("Rec. individual:         {0}", recaudacionIndividual);
            Console.WriteLine("Rec. pasaportes:         {0}", recaudacionPasaportes);
            Console.WriteLine("Rec. total:              {0}", recaudacionTotal);

            // Resultados finales
            Console.ReadKey();
        }
    }
}