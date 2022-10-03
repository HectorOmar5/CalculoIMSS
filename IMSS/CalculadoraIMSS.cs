using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        public static Aportaciones Calcular(decimal sbc, decimal uma, int Tipousuario)
        {
            Aportaciones aportaciones = new Aportaciones();
            if (Tipousuario == 0)
            {
                aportaciones.EnfermedadMaternidad = sbc -((3 * uma) * Convert.ToDecimal(1.1 / 100));
                aportaciones.InvalidezVida = sbc * Convert.ToDecimal(1.75 / 100);
                aportaciones.Retiro = sbc * Convert.ToDecimal(2 / 100);
                aportaciones.Cesantia = sbc * Convert.ToDecimal(3.150 / 100);
                aportaciones.Infonavit = sbc* Convert.ToDecimal(5 / 100);
            }
            else if (Tipousuario == 1)
            {
                aportaciones.EnfermedadMaternidad = sbc - (3 * uma) * Convert.ToDecimal(0.04 / 100);
                aportaciones.InvalidezVida = sbc * Convert.ToDecimal(0.625 / 100);
                aportaciones.Retiro = sbc * Convert.ToDecimal(0 / 100);
                aportaciones.Cesantia = sbc * Convert.ToDecimal(1.125 / 100);
                aportaciones.Infonavit = sbc * Convert.ToDecimal(0 / 100);
            }
            return aportaciones;
        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingrese Salario Base de Cotizacion (SBC): ");
            decimal sbc = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Unidad de Medida y Actualizacion (UMA): ");
            decimal uma = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione el usuario: ");
            Console.WriteLine("\t0.- Patron");
            Console.WriteLine("\t1.- Trabajador");
            int Tipousuario = int.Parse(Console.ReadLine());

            Aportaciones aportaciones = Calcular(sbc, uma, Tipousuario);
            Console.WriteLine(aportaciones.EnfermedadMaternidad);
            Console.WriteLine(aportaciones.InvalidezVida);

        }
    }
}
