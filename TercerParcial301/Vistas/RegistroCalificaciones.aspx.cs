using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TercerParcial301.Vistas
{
    public partial class RegistroCalificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se crea una variable boleana para comparar el Tipo
            bool docente = Session["Tipo"]?.ToString() == "Docente";

            //Si el tipo no es docente entonces redirecciona a UknownPage
            if (!docente)
            {
                Response.Redirect("UknownPage.aspx");
            }
        }
    }
}