using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer1()
        {
            decimal salario, total = 0, promedio;
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el salario del empleado {0}", i+1);
                    salario = Convert.ToDecimal(Console.ReadLine());
                } while (salario <= 0);
                total = total + salario;

            }
            promedio = total / 20;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Total: {0}", total.ToString("c"));
            Console.WriteLine("Promedio de sueldos: {0}", promedio.ToString("c2"));
            Console.ReadKey();
        }
    }
}
