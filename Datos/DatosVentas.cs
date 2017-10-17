using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosVentas
    {
       TiendaElectronicaEntities2 te;
        public DatosVentas()
        {
            te = new TiendaElectronicaEntities2();
        }

        public List<Venta> Listar()
        {
            return (from a in te.Venta select a).ToList();
        }

        public int TotalVenta(Venta venta)
        {
            var lista = (from a in te.Venta where a.cod_producto == venta.cod_producto select a).ToList();
            int suma = 0;

            foreach (var item in lista)
            {
                suma += item.Producto.precio * item.cantidad;
            }

            return suma;
        }
    }
}
