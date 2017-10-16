using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioVentas
    {
        Datos.DatosVentas dv;

        public NegocioVentas()
        {
            dv = new Datos.DatosVentas();
        }

        public List<Venta> Listar()
        {
            Negocio.Venta nv;

            var lista = dv.Listar();

            List<Venta> retorno = new List<Venta>();

            foreach (Datos.Venta item in lista)
            {
                nv = new Venta()
                {
                    cantidad = item.cantidad,
                    codigo = item.codigo,
                    cod_producto = item.cod_producto,
                    fecha = item.fecha,
                    usr_venta = item.usr_venta,
                    Producto = new Negocio.Producto()
                    {
                        codigo = item.Producto.codigo,
                        marca = item.Producto.marca,
                        modelo = item.Producto.modelo,
                        precio = item.Producto.precio,
                        tipo = item.Producto.tipo
                    },
                    Usuario = new Negocio.Usuario()
                    {
                        contra = item.Usuario.contra,
                        usuario1 = item.Usuario.usuario1
                    }
                };
                retorno.Add(nv);                
            }
            return retorno;
        }
    }
}
