using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class WebNavegacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("BIEWNVEIO " + ((Vista.TiendaElectronica)this.Master).SessionUsuario.usuario1);
            }
        }
    }
}