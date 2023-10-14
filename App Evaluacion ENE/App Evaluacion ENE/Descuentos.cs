using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Evaluacion_ENE
{

    public class Descuentos
    {
        public static double CalcularDescuentoAFP(string tipoAfp, double sueldoBruto)
        {
            var afpDescuentos = new Dictionary<string, double>
        {
            { "CUPRUM", 0.07 },
            { "MODELO", 0.09 },
            { "CAPITAL", 0.12 },
            { "PROVIDA", 0.13 }
        };
            return sueldoBruto * (afpDescuentos.ContainsKey(tipoAfp) ? afpDescuentos[tipoAfp] : 0);
        }

        public static double CalcularDescuentoSalud(string tipoSalud, double sueldoBruto)
        {
            var saludDescuentos = new Dictionary<string, double>
        {
            { "FONASA", 0.12 },
            { "CONSALUD", 0.13 },
            { "MASVIDA", 0.14 },
            { "BANMEDICA", 0.15 }
        };
            return sueldoBruto * (saludDescuentos.ContainsKey(tipoSalud) ? saludDescuentos[tipoSalud] : 0);
        }
    }

}
