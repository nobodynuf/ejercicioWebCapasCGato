using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public int codigo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public Tipo tipo { get; set; }
        public int precio { get; set; }

        public Producto()
        {

        }
    }
}
