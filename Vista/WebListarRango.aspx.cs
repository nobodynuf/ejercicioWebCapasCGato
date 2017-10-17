using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class WebListarRango : System.Web.UI.Page
    {
        Negocio.NegocioProducto np;
        protected void Page_Load(object sender, EventArgs e)
        {
            np = new Negocio.NegocioProducto();
            if (!IsPostBack)
            {
                
                gvProductos.DataSource = np.Listar();
                gvProductos.DataBind();
            }
        }

        protected void btnGO_Click(object sender, EventArgs e)
        {
            gvProductos.DataSource = np.Listar(int.Parse(txtRMenor.Text), int.Parse(txtRMayor.Text));
            gvProductos.DataBind();
            
        }
    }
}