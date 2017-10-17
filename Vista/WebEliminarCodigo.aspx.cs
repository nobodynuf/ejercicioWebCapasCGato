using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class WebEliminarCodigo : System.Web.UI.Page
    {
        Negocio.NegocioProducto np;
        TiendaElectronica m;

        protected void Page_Load(object sender, EventArgs e)
        {
            np = new Negocio.NegocioProducto();
            m = ((TiendaElectronica)this.Master);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (np.EliminarPorCodigo(int.Parse(txtId.Text)))
            {
                m.MostrarMensaje("Se ha eliminado correctamente");
            }
            else
            {
                m.MostrarMensaje("No se ha encontrado ese codigo de producto " +
                    "ergo, no han ocurrido cambios");
            }
        }
    }
}