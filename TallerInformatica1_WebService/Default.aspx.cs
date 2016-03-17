using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerInformatica1_WebService
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculoSuma_Click(object sender, EventArgs e)
        {
            ServiceReferencesumaNumeros.WebService_SumaNumerosSoapClient SumatoriaNumeros = new ServiceReferencesumaNumeros.WebService_SumaNumerosSoapClient();
            try
            {
                LblResultado.Text = SumatoriaNumeros.sumaNumeros(Convert.ToInt32(TxtPrimerNumero.Text), Convert.ToInt32(TxtSegundoNUmero.Text)).ToString();
            }
            catch (SystemException)
            {
                LblResultado.Text = "Error al calcular la sumatoria de la informacion ingresada, verifique los numeros a sumar e intente de nuevo";
            }
        }
    }
}