using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TallerInformatica1_WebService
{
    /// <summary>
    /// WebService que recibe como parametros dos numeros y retorna el valor de la sumatoria de dichos numeros ingresados.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebService_SumaNumeros : System.Web.Services.WebService
    {

        [WebMethod]
        //Creacion del WebMethod llamado sumaNumeros
        //el cual tiene como parametros de entrada dos atributos de tipo int
        //llamados primerNumero y segundoNUmero
        public int sumaNumeros(int primerNumero, int segundoNumero)
        {
            //una vez recibidos los parametros, retorna el valor de la sumatoria de los mismos
            return primerNumero + segundoNumero;
        }
    }
}
