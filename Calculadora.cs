using System;
using System.Collections.Generic;
using System.Text;

namespace programas
{
    class Calculadora
    {
        
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        private int resultadoSUma;
        private int resultadoResta;
        private int resultadoMultiplicacion;
        private int resultadoDivision;
       



        public int calcularSuma()
        {
            resultadoSUma = numero1 + numero2;
             return resultadoSUma;

        }

        public int calcularResta()
        {
            resultadoResta = numero1 - numero2;
             return resultadoResta;
        }

        public int calcularMultilicacion()
        {
            resultadoMultiplicacion = numero1 * numero2;
              return resultadoMultiplicacion;
        }

        public int calcularDivision()
        {
            resultadoDivision = numero1 / numero2;
            return resultadoDivision;
        }

        public int calcularFactorial(int numero1)
        {

            if (numero1 == 0) return 1;
            else
              return  numero1 * calcularFactorial(numero1 - 1) ;
        }



        public int calcularPotencia(int x, int y)
        {
            if (y == 0) return 1;
            else
              return x * calcularPotencia(x, y - 1);
        }

    }
}

