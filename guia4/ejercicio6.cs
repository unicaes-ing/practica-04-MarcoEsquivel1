using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4
{
    class ejercicio6
    {
        //Marco René Esquivel Juárez
        //14-Agosto
        public void ejer6()
        {
            decimal venta, totalSucursal = 0, promSucursal, totalGlobal = 0, promGlobal = 0;
            int sucursales, j=0, k = 0;
            decimal[] sucur;
            decimal[] promSucur;
            do
            {
                Console.WriteLine("Ingrese la cantidad de sucursales");
                sucursales = Convert.ToInt32(Console.ReadLine());
            } while (sucursales <= 0);
            sucur = new decimal[sucursales];
            promSucur = new decimal[sucursales];
            Console.Clear();
            for (int i = 0; i < sucursales; i++)
            {
                Console.WriteLine("Ingrese las ventas de la sucursal {0} ingrese \"0\" para dejar de ingresar las ventas de esta sucursal", i + 1);
                do
                {
                    venta = Convert.ToDecimal(Console.ReadLine());
                    totalSucursal = totalSucursal + venta;
                    k = k + 1;
                    j = j + 1;

                } while (venta != 0);
                promSucursal = totalSucursal / (j - 1);
                promSucur[i] = promSucursal;
                sucur[i] = totalSucursal;
                totalGlobal = totalGlobal + totalSucursal;
                promGlobal = totalGlobal / (k - sucursales);
                totalSucursal = 0;
                j = 0;
                Console.Clear();
            }
            for (int i = 0; i < sucursales; i++)
            {
                Console.WriteLine("Total de la sucursal {0} es de {1}", i+1, sucur[i].ToString("c2"));
                Console.WriteLine("El promedio de la sucursal {0} es de {1}", i+1, promSucur[i].ToString("c2"));
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
            Console.WriteLine("El total global es de {0}", totalGlobal.ToString("c2"));
            Console.WriteLine("El promedio global es de {0}", promGlobal.ToString("c2"));
            Console.ReadKey();
        }
    }
}
