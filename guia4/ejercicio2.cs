using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer2()
        {
            int aprobados = 0, reprobados = 0, n;
            decimal calificacion, asistencia;
            do
            {
                Console.WriteLine("Ingrese la cantidad de alumnos que desea ingresar");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese la calificacion del alumno {0} (0-10)", i + 1);
                    calificacion = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingrese el porcentaje de asistencia sin el simbolo \"%\"");
                    asistencia = Convert.ToDecimal(Console.ReadLine());
                } while ((calificacion<0 || calificacion > 10) || (asistencia<0 || asistencia >100)); 
                
                if (calificacion>7 && asistencia>75)
                {
                    Console.WriteLine("Alumno aprobado");
                    aprobados = aprobados + 1;
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    Console.WriteLine("Alumno reprobado");
                    reprobados = reprobados + 1;
                    Console.WriteLine("--------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
