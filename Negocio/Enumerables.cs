using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public enum Tipo
    {
        No_determinado,
        Tablet,
        Notebook,
        [Display(Name="Equipo Musical")]
        Equipo_musical,
        Audifonos,
        Parlantes
    } 
}
