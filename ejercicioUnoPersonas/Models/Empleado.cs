using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoPersonas.Models
{
    public class Empleado
    {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public DateTime fechaNacimiento { get; set; }
            public string numeroDocumento { get; set; }
            public TipoDocumento tipoDocumento { get; set; }
            public Puesto puesto { get; set; }

            public Empleado(string nombre, string apellido, DateTime fechaNacimiento, string numeroDocumento, TipoDocumento tipoDocumento, Puesto puesto)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechaNacimiento = fechaNacimiento;
                this.numeroDocumento = numeroDocumento;
                this.tipoDocumento = tipoDocumento;
                this.puesto = puesto;
            }

        

        // Método para verificar si el empleado tiene el número de documento buscado
        public bool SosNumeroDoc(string numeroDocumento)
        {
            return this.numeroDocumento.ToLower().Trim() == numeroDocumento.ToLower().Trim();
        }

    }
}
