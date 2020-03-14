using System;
using GasolineraKalum.Controllers;
using GasolineraKalum.Entities;
using GasolineraKalum.Menu;
using static  GasolineraKalum.Util.Printer;


namespace GasolineraKalum
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            WriteTitle("Gasolinera Kalum");
            new MenuPrincipal().MostrarMenu();
            //string salida = "GasolineraKalum.Entities.Super";
            
                     
            //Console.WriteLine($"split {salida.Split(".")[2]}");
            
            //Console.WriteLine(salida.LastIndexOf(".") + 1);

            //Console.WriteLine(salida.Substring(salida.LastIndexOf(".") + 1));

            //for (int i = salida.Length -1; i >=0; i--)
            {
              //  if(salida.Substring(i,1).Equals(".")){
                //    Console.WriteLine(salida.Substring(i + 1,salida.Length - (i + 1)));
                  //  break;
                }

            //}
            PresionarEnter();
                    

        }
    }
}
