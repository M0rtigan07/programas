using System;
using System.Collections.Generic;
using System.Text;

namespace programas
{
    class Tiempo
    {
        public int         horas      { get; set; }
        public int         minuto   { get; set; }
        public int          segundo  { get; set; }
        private string    laHora = DateTime.Now.ToString("hh:mm:ss");

      public string  ModificaHora()
        {
            Console.WriteLine("Introduzca la nueva hora");

            horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca los nuevos minutos");
            minuto = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("Introduzca los nuevos segundos");
            segundo = Convert.ToInt32(Console.ReadLine());

            laHora = Convert.ToString(horas) + " : " + Convert.ToString(minuto) + " : " + Convert.ToString(segundo);

            return   laHora;
        }

        public void  MuestraHora()
        {
                  
            Console.WriteLine(laHora);
        }

    }

    class PruebaTiempo 
    {
    }
}
