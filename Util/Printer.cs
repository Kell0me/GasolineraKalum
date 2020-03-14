using System;
using static System.Console; //para no escribir console a cada rato

namespace GasolineraKalum.Util
{
    public static  class Printer
    {
        public static void Beep(int hz = 3000, int tiempo = 500, int cantidad  = 1)
        {
            while(cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
                cantidad--;
            }
        }

        public static void WriteTitle(string title)
        {
            var tamaño = title.Length * 3;
            DrawLine (tamaño);
            WriteLine($"|{title}|"); //esto se llama interpolacion
            DrawLine(tamaño);
        }

        public static void DrawLine(int size = 10)
        {
            WriteLine(" ".PadLeft(size,'=')); //concatenar a la izquierda PadLeft
        }

        public static void  PresionarEnter()
        {
            WriteLine("Presione Enter para continuar");
            ReadKey();
        }

    }
}