using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class WebIngresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                ddlTipo.DataSource = (Enum.GetValues(typeof(Negocio.Tipo))); 
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}