using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Evaluacion_ENE
{
    public class CalculadoraSueldo
    {
        const double VALOR_HORA = 5000;
        const double VALOR_HORA_EXTRA = 7000;

        public static double CalcularSueldoBruto(int horasTrabajadas, int horasExtras)
        {
            return horasTrabajadas * VALOR_HORA + horasExtras * VALOR_HORA_EXTRA;
        }
    }
}
