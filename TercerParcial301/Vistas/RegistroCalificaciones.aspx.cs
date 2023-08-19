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
            bool docente = Session["Tipo"]?.ToString() == "Docente";

            if (!docente)
            {
                Response.Redirect("UknownPage.aspx");
            }
        }
    }
}