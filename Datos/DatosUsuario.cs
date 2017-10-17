﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosUsuario
    {
        private TiendaElectronicaEntities2 tee;
        public DatosUsuario() {
            tee = new TiendaElectronicaEntities2();
        }
        // R
        public bool Autentificar(Usuario usuario)
        {
            var resultados = tee.Usuario.FirstOrDefault(
                a => a.usuario1.Equals(usuario.usuario1));
            if (resultados != null)
            {
                return resultados.contra.Equals(usuario.contra);
            }
            else
            {
                return false;
            }

        }
    }
}
