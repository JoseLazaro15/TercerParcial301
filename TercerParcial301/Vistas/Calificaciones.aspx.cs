using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TercerParcial301.Vistas
{
    public partial class Calificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se crea una variable boleana para comparar el Tipo
            bool alumno = Session["Tipo"]?.ToString() == "Alumno";

            //Si el tipo no es alumno entonces redirecciona a UknownPage
            if (!alumno)
            {
                Response.Redirect("UknownPage.aspx");
            }
        }
    }
}