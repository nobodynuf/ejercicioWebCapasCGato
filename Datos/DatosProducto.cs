using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProducto
    {
        // CRD
        TiendaElectronicaEntities2 te;

        public DatosProducto()
        {
            te = new TiendaElectronicaEntities2();
        }

        public bool Crear(Producto producto)
        {
            var lista = (from a in te.Producto select a);

            foreach (Producto item in lista)
            {
                if (item.codigo == producto.codigo)
                {
                    return false;
                }
            }
            te.Producto.Add(producto);
            te.SaveChanges();
            return true;
        }

        public List<Producto> Listar()
        {
            return (from a in te.Producto select a).ToList();
        }

        public bool EliminarPorCodigo(int codigo)
        {
            List<Producto> lista = (from a in te.Producto select a).ToList();

            foreach (Producto item in lista)
            {
                if (item.codigo == codigo)
                {
                    te.Producto.Remove(item);
                    te.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public List<Producto> Listar(int precioMenor, int precioMayor)
        {
            var lista = (from a in te.Producto

                         select a).ToList();
            lista = lista.Where(a => a.precio > precioMenor & a.precio < precioMayor).ToList();
            return lista;
        }
    }
}
