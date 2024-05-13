using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoPersonas.Models
{
    public class Puesto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Puesto(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
