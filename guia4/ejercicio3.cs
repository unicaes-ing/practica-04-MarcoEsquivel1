using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer3()
        {
            string nombre;
            int vocales, i = 0, minusculas = 0, mayusculas = 0, tildadas = 0;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            while (i < nombre.Length)
            {
                if (nombre.Substring(i,1)=="a" || nombre.Substring(i,1)=="e" || nombre.Substring(i, 1) == "i" || nombre.Substring(i, 1) == "o" || nombre.Substring(i, 1) == "u" || nombre.Substring(i, 1) == "á" || nombre.Substring(i, 1) == "é" || nombre.Substring(i, 1) == "í" || nombre.Substring(i, 1) == "ó" || nombre.Substring(i, 1) == "ú")
                {
                    minusculas = minusculas + 1;
                   
                    if (nombre.Substring(i, 1) == "á" || nombre.Substring(i, 1) == "é" || nombre.Substring(i, 1) == "í" || nombre.Substring(i, 1) == "ó" || nombre.Substring(i, 1) == "ú")
                    {
                        tildadas = tildadas + 1;
                    }
                }
                else
                {
                    if (nombre.Substring(i, 1) == "A" || nombre.Substring(i, 1) == "E" || nombre.Substring(i, 1) == "I" || nombre.Substring(i, 1) == "O" || nombre.Substring(i, 1) == "U" || nombre.Substring(i, 1) == "Á" || nombre.Substring(i, 1) == "É" || nombre.Substring(i, 1) == "Í" || nombre.Substring(i, 1) == "Ó" || nombre.Substring(i, 1) == "Ú" )
                    {
                        mayusculas = mayusculas + 1;
                       
                        if (nombre.Substring(i, 1) == "Á" || nombre.Substring(i, 1) == "É" || nombre.Substring(i, 1) == "Í" || nombre.Substring(i, 1) == "Ó" || nombre.Substring(i, 1) == "Ú")
                        {
                            tildadas = tildadas + 1;
                        }
                    }
                }
                i = i + 1;
            }
            vocales = minusculas + mayusculas;
            Console.WriteLine("Total de vocales: {0}", vocales);
            Console.WriteLine("Vocales minusculas: {0}", minusculas);
            Console.WriteLine("Vocales mayusculas: {0}", mayusculas);
            Console.WriteLine("Vocales tildadas: {0}", tildadas);
            Console.ReadKey();
        }
    }
}
