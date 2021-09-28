using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularAreaWS
{
    /// <summary>
    /// Descripción breve de Calcular
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcular : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal areacuadrado(decimal lado)
        {
            Calculo c = new Calculo();
            return c.areacuadrado(lado);
        }

        [WebMethod]
        public decimal areatriangulo(decimal basE, decimal heighT)
        {
            Calculo c = new Calculo();
            return c.areatriangulo(basE, heighT);
        }

        public decimal areacirculo(decimal radiO)
        {
            Calculo c = new Calculo();
            return c.areacirculo(radiO);
        }
    }
}
