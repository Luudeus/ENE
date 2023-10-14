using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Evaluacion_ENE
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // Datos de entrada
            Console.Write("Indique la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            Console.Write("Indique la cantidad de horas extras trabajadas: ");
            int horasExtras = int.Parse(Console.ReadLine());

            Console.Write("Introduce tu AFP en mayúsculas: ");
            string tipoAfp = Console.ReadLine();

            Console.Write("Introduce tu servicio de salud en mayúsculas: ");
            string tipoSalud = Console.ReadLine();

            // Calcular y mostrar el sueldo líquido
            double sueldoBruto = CalculadoraSueldo.CalcularSueldoBruto(horasTrabajadas, horasExtras);
            double bonoMarzo = BonoMarzo.CalcularBono(sueldoBruto);
            double descuentoAfp = Descuentos.CalcularDescuentoAFP(tipoAfp, sueldoBruto);
            double descuentoSalud = Descuentos.CalcularDescuentoSalud(tipoSalud, sueldoBruto);
            double sueldoLiquido = sueldoBruto - descuentoAfp - descuentoSalud + bonoMarzo;

            Console.WriteLine("Tu sueldo líquido es de $" + sueldoLiquido + " pesos.");
        }
    }
}
