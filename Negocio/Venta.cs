using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Venta
    {
        public string codigo { get; set; }
        public int cod_producto { get; set; }
        public string usr_venta { get; set; }
        public int cantidad { get; set; }
        public System.DateTime fecha { get; set; }
        public int? total { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Usuario Usuario { get; set; }

        public Venta()
        {

        }
    }
}
