using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer4()
        {
            int cantVentas = 0, i;
            decimal bono, totalVentas = 0, venta;
            Console.WriteLine("Bienvenido al sistema de ventas, ingrese sus ventas, ingrese -1 para finalizar");
            do
            {
                do
                {
                    venta = Convert.ToDecimal(Console.ReadLine());
                } while (venta <= -1 && venta == 0); 
                if (venta > 0)
                {
                    cantVentas = cantVentas + 1;
                    totalVentas = totalVentas + venta;
                }
            } while (venta != -1);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("El total de dinero fué de {0} en {1} ventas.", totalVentas.ToString("c2"), cantVentas);
            bono = totalVentas * 0.05m;
            Console.WriteLine("Su bono es de {0}", bono.ToString("c2"));
            Console.ReadKey();
            
        }
    }
}
