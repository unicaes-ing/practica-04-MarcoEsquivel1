using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio5
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer5()
        {
            string contraseña = "holaquetal", contra;
            int i = 0;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Pista: {0}", contraseña.Substring(0, i));
                }
                Console.WriteLine("Ingrese la contraseña: intento {0}", i + 1);
                contra = Console.ReadLine();
                i = i + 1;
                Console.Clear();   
            } while (contra != contraseña && i < 3);
    
        }
    }
}
