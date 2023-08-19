using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TercerParcial301.Controladores;

namespace TercerParcial301.Vistas
{
    public partial class Registro : System.Web.UI.Page
    {
        Metodos met = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                string[] roles = { "Alumno", "Docente", "Administrativo" };

                foreach (string role in roles)
                {
                    RadioButtonList1.Items.Add(new ListItem(role, role));
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Contra;
            if (TextBox2.Text == "") 
            {
                Label6.Text = "Ingresa una contraseña";
            }
            else
            {
                try
                {
                    Contra = met.EncriptarClave(TextBox2.Text);

                    TextBox4.Text = Contra;
    
                } catch (Exception)
                {
                    Label6.Text ="Ha ocurrido un error";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label6.Text = met.InsertarUsuarios(TextBox5.Text, TextBox1.Text, TextBox2.Text, RadioButtonList1.Text);
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}