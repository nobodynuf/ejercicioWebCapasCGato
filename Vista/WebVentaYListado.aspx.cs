using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vista
{
    public partial class WebVentaYListado : System.Web.UI.Page
    {
        Negocio.NegocioVentas nv;
        protected void Page_Load(object sender, EventArgs e)
        {
            nv = new Negocio.NegocioVentas();


            if (!IsPostBack)
            {
                gvVentas.DataSource = nv.ListarConTotal();
                gvVentas.DataBind();

            }
        }
    }
}