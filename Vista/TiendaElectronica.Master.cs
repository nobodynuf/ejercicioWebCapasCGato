using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class TiendaElectronica : System.Web.UI.MasterPage
    {
        public Negocio.Usuario SessionUsuario
        {
            get
            {
                if (Session["usuario"] == null)
                {
                    Session["usuario"] = new Negocio.Usuario();
                }
                return (Negocio.Usuario)Session["usuario"];
            }
            set
            {
                Session["usuario"] = value;
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            Response.Write("<script>alert('" + mensaje + "')</script>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}