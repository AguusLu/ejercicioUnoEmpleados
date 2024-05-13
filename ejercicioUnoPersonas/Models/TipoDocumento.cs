using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoPersonas.Models
{
    public class TipoDocumento
    {
        public string tipo { get; set; }

        public TipoDocumento(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
