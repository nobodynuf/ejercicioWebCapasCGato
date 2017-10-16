using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosVentas
    {
        TiendaElectronicaEntities1 te;
        public DatosVentas()
        {
            te = new TiendaElectronicaEntities1();
        }

        public List<Venta> Listar()
        {
            return (from a in te.Venta select a).ToList();
        }

    }
}
