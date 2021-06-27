using System;

namespace UD5E13
{
    class Program
    {
        static void Main(string[] args)
        {
            string sLongitud = "Introduzca la longitud del array";
            int longitud = Convert.ToInt32(sLongitud);
            int[] array = new int[longitud];

            Random aleatorio = new Random();

            for (int i =0; i<longitud;i++)
            {
                array[i] = aleatorio.Next(1, 11);
            }

        }
    }
}
