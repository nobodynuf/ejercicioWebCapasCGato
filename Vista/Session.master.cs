using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Vista
{
    public partial class Session : System.Web.UI.MasterPage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Usuario SessionUsuario
        {
            get
            {
                if (Session["usuario"] == null)
                {
                    Session["usuario"] = new Usuario();
                }
                return (Usuario)Session["usuario"];
            }
            set
            {
                Session["usuario"] = value;
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            Response.Write("<script>alert('"+mensaje+"')</script>");
        }
    }
}