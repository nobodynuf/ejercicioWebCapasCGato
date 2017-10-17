using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioProducto
    {
        Datos.DatosProducto dp;

        public NegocioProducto()
        {
            dp = new Datos.DatosProducto();
        }
        /// <summary>
        /// Agrega un producto a la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Si tuvo exito en la operacion</returns>
        public bool Crear(Negocio.Producto producto)
        {
            Datos.Producto pro = new Datos.Producto()
            {
                codigo = producto.codigo,
                marca = producto.marca,
                modelo = producto.modelo,
                precio = producto.precio,
                tipo = producto.tipo.ToString(),

            };
            return dp.Crear(pro);
        }
        /// <summary>
        /// Lista todos los productos, sin criterio
        /// <seealso cref="Listar(int, int)">Vea</seealso>
        /// </summary>
        /// <returns>Lista de productos</returns>
        public List<Producto> Listar()
        {

            List<Negocio.Producto> lista = new List<Producto>();
            Negocio.Producto producto;

            foreach (var item in dp.Listar())
            {
                producto = new Producto()
                {
                    codigo = item.codigo,
                    marca = item.marca,
                    modelo = item.modelo,
                    precio = item.precio,
                    tipo = (Tipo)Enum.Parse(typeof(Tipo), item.tipo)
                };
                lista.Add(producto);
            }
            return lista;
        }

        /// <summary>
        /// Lista por rangos de precios 
        /// </summary>
        /// <param name="menor">limite inferior del rango</param>
        /// <param name="mayor">limite superior del rango</param>
        /// <returns>Lista de productos</returns>
        public List<Producto> Listar(int menor, int mayor)
        {
            List<Producto> lista = new List<Producto>();
            Negocio.Producto producto;

            foreach (Datos.Producto item in dp.Listar(menor, mayor))
            {
                producto = new Producto()
                {
                    codigo = item.codigo,
                    marca = item.marca,
                    modelo = item.modelo,
                    precio = item.precio,
                    tipo = (Tipo)Enum.Parse(typeof(Tipo), item.tipo)
                };
                lista.Add(producto);
            }
            return lista;
        }

        /// <summary>
        /// Elimina un producto por su codigo en la base de datos
        /// </summary>
        /// <param name="codigo">el codigo a eliminar</param>
        /// <returns>retorna si tuvo exito</returns>
        public bool EliminarPorCodigo(int codigo)
        {
            return dp.EliminarPorCodigo(codigo);
        }
    }
}
