using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TercerParcial301.Controladores
{
    public class Metodos
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shado\\source\\repos\\TercerParcial301\\TercerParcial301\\App_Data\\DataBase1.mdf;Integrated Security=True");

        public string InsertarUsuarios(string dat1, string dat2,string dat3, string dat4)
        {
            int result = 0;
            string men = "";
            string Insert1 = "INSERT INTO Usuario(IdU,Usuario, Contraseña, Tipo) Values(@d1, @d2,@d3, @d4)";
            SqlCommand myCommand1 = new SqlCommand(Insert1, conn);
            myCommand1.Parameters.Add("@d1", SqlDbType.Int).Value = dat1;
            myCommand1.Parameters.Add("@d2", SqlDbType.VarChar).Value = dat2;
            string dat5 = EncriptarClave(dat3);
            myCommand1.Parameters.Add("@d3", SqlDbType.VarChar).Value = dat5;
            myCommand1.Parameters.Add("@d4", SqlDbType.VarChar).Value = dat4;
            conn.Open();
            try
            {
                result = myCommand1.ExecuteNonQuery();
            }
            catch(Exception)
            {
                men = "Ha ocurrido un error, verifique los datos";
            }
            if (result != 0)
            {
                men = "Se insertaron los datos del usuario correctamente"; 
            }
            else 
            {
                men = "No se inserto el usuario, verifique los datos";
            }
            conn.Close();
            return men;
        }

        public string EncriptarClave(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash= sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }

        public string[] BuscarUsuario(string dat1, string dat2)
        {
            string[] tipo = new string[3];

            tipo[0] = "Vacio";
            tipo[1] = "vacio";
            tipo[2] = "vacio";

            SqlCommand cmd4 = new SqlCommand("SELECT IdU,Usuario,Tipo FROM Usuario WHERE Usuario= @d1 AND Contraseña = @d2", conn);
            cmd4.Parameters.Add("@d1", SqlDbType.VarChar).Value = dat1;
            string dat3 = EncriptarClave(dat2);
            cmd4.Parameters.Add("@d2", SqlDbType.VarChar).Value = dat3;
            conn.Open();
            SqlDataReader myReader4 = cmd4.ExecuteReader();
            while(myReader4.Read())
            {
                tipo[0] = myReader4[0].ToString();
                tipo[1] = myReader4[1].ToString();
                tipo[2] = myReader4[2].ToString();
            }
            myReader4.Close();
            conn.Close();
            return tipo;

        }


    }
}