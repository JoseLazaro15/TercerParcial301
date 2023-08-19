using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TercerParcial301.Vistas
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Tipo"] == null)
            {
                // Si no hay sesión de usuario, redirigir al formulario de inicio de sesión
                Response.Redirect("Login.aspx");
            }
            else
            {
                string tipoUsuario = Session["Tipo"].ToString();
                // desactiva todo los Link Button
                LinkButton1.Enabled = false;
                LinkButton2.Enabled = false;
                LinkButton3.Enabled = false;

                switch (tipoUsuario)
                {
                    case "Alumno":
                        LinkButton1.Enabled = true;
                        break;
                    case "Docente":
                        LinkButton2.Enabled = true;
                        break;
                    case "Administrativo":
                        LinkButton3.Enabled = true;
                        break;
                    default:
                        Response.Redirect("UknownPage.aspx");
                        break;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}