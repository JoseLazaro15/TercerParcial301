using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TercerParcial301.Vistas
{
    public partial class RegistroAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se crea una variable boleana para comparar el Tipo
            bool administrativo = Session["Tipo"]?.ToString() == "Administrativo";

            //Si el tipo no es administrativo entonces redirecciona a UknownPage
            if (!administrativo)
            {
                Response.Redirect("UknownPage.aspx");
            }
        }
    }
}