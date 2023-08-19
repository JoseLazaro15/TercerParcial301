using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TercerParcial301.Controladores;

namespace TercerParcial301.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        Metodos met = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] tipo;

            if ((TextBox1.Text == "") & (TextBox2.Text == ""))
            {
                Label3.Text = "Proporcione correctamente los datos";
            }
            else
            {
                try
                {
                    tipo = met.BuscarUsuario(TextBox1.Text, TextBox2.Text);

                    if (tipo[2] != "vacio")
                    {
                        Session["IdU"] = tipo[0];
                        Session["Usuario"] = tipo[1];
                        Session["Tipo"] = tipo[2];
                        Response.Redirect("Principal.aspx");
                    }
                    else
                    {
                        Label3.Text = "El usuario no esta registrado";
                    }
                }
                catch (Exception)
                {
                    Label3.Text = "Ha ocurrido un error, verifique los datos";
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
  