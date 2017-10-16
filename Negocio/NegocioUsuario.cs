using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioUsuario
    {
        DatosUsuario du;

        public NegocioUsuario()
        {
            du = new DatosUsuario();
        }

        public bool Autentificar(Usuario us)
        {
            Datos.Usuario usuario = new Datos.Usuario()
            {
                contra = us.contra,
                usuario1 = us.usuario1
            };

            return du.Autentificar(usuario);

        }
    }
}
