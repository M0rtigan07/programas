using System;
using System.Collections.Generic;

namespace programas
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora miCalculadora = new Calculadora();
            miCalculadora.numero1 = 87;
            miCalculadora.numero2 = 13;

            Console.WriteLine("***********CLASE  CALCULADORA*********************");

            miCalculadora.calcularSuma();
            miCalculadora.calcularResta();
            miCalculadora.calcularMultilicacion();
         
            miCalculadora.calcularFactorial(5);
          ;
            Console.WriteLine(  " Calculo  {0}  / {1}   =  " +  miCalculadora.calcularDivision(), miCalculadora.numero1, miCalculadora.numero2 );

            Console.WriteLine( "Calculo de potencia   " + miCalculadora.calcularPotencia(8, 5));


            

            int x;

            List<int> miLista = new List<int>();


            Empleado unEmpleado = new Empleado("123456789P");
            Empleado pepe = new Empleado("123456788J");

            unEmpleado.HorasTrabajadas = 20;
            x = unEmpleado.HorasTrabajadas;
            Console.WriteLine(unEmpleado.HorasTrabajadas);

            pepe.HorasTrabajadas = 40;
            Console.WriteLine(pepe.HorasTrabajadas);

            //int sueldoPepe=pepe.CalcularPago();
            int sueldoPepe = pepe.CalcularPago(100, 100);
            Console.WriteLine(sueldoPepe);

            Console.WriteLine(Empleado.ValorHora());

            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i < 5; i++)
            {
                //string xdni = Console.ReadLine();
                Empleado otroEmpleado = new Empleado("1234567" + i + "J");

                //los datos del empleado
                empleados.Add(otroEmpleado);
            }
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado.DNI);
            }

            Console.WriteLine("***********CLASES    COCHES*********************");

       //     PruebaCoche miprueba = new PruebaCoche();
       //     miprueba.probar();

            Console.WriteLine("***********CLASE   TIEMPO*********************");

            Tiempo miHora = new Tiempo();

            miHora.MuestraHora();
            miHora.ModificaHora();
            miHora.MuestraHora();
        }
    }
}
