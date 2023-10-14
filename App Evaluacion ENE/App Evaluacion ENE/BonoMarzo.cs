using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Evaluacion_ENE
{
    public class BonoMarzo
    {
        public static double CalcularBono(double sueldoBruto)
        {
            return sueldoBruto > 200000 ? sueldoBruto * 0.2 : sueldoBruto * 0.15;
        }
    }

}
