using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Vista
{
    public partial class WebInicio : System.Web.UI.Page
    {
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Negocio.Usuario us = new Negocio.Usuario()
            {
                usuario1 = txtUser.Text,
                contra = txtPass.Text
            };

            if (new NegocioUsuario().Autentificar(us))
            {
                ((Vista.Session)this.Master).SessionUsuario = us;
                Response.Redirect("WebNavegacion.aspx");
            }
            else
            {
                ((Vista.Session)this.Master).MostrarMensaje("No se pudo autentificar, verifique " +
                    "credenciales");
            }

        }
    }
}