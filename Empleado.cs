using System;
using System.Collections.Generic;
using System.Text;

namespace programas
{
    class Empleado
    {
        public Empleado(string DNI)
        {
            dNI = DNI;
            //Console.WriteLine("El DNI es {0}", dNI);
        }
        private string dNI;
        private string nombreEmpleado;
        private const int valorHora = 30;
        private int horasTrabajadas;
        public int HorasTrabajadas
        {
            get
            {
                return horasTrabajadas;
            }
            set
            {
                if (value > 0)
                    horasTrabajadas = value;
                else
                    horasTrabajadas = 0;
            }
        }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string DNI
        {

            get
            {
                return dNI;
            }
            private set { }
        }

        public void ImprimirMensaje()
        { Console.WriteLine("Calculando Pago..."); }
        public int CalcularPago()
        {
            ImprimirMensaje();
            int pagaEmpleado;
            pagaEmpleado = valorHora * horasTrabajadas;
            if (horasTrabajadas > 0)
                return pagaEmpleado;
            else
                return 0;
        }

        public int CalcularPago(int bonus, int presentismo)
        {
            ImprimirMensaje();

            if (horasTrabajadas > 0)
                return (valorHora * horasTrabajadas) + bonus + presentismo;
            else
                return 0;
        }

        static public int ValorHora()
        {
            return valorHora;
        }


    }
}
