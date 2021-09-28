using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreaWS
{
    public class Calculo
    {
        public decimal basE { get; set; }
        public decimal heighT { get; set; }
        public decimal radiO { get; set; }



        public decimal areacuadrado(decimal basE)
        {
            return basE * basE;
        }

        public decimal areatriangulo(decimal basE, decimal heighT)
        {
            var resultado = (basE * heighT) / 2;
            return resultado;
        }

        public decimal areacirculo(decimal radiO)
        {
            var resultado = Math.PI * Math.Pow(Convert.ToDouble(radiO), 2);
            return Convert.ToDecimal(resultado);
        }
    }
}