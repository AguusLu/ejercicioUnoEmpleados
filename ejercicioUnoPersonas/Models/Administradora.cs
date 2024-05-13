using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoPersonas.Models
{
    public class Administradora
    {
        private List<Empleado> empleados;

        public Administradora()
        {
            empleados = new List<Empleado>();
        }

        // Método para agregar un empleado a la lista
        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        // Método para eliminar un empleado de la lista
        public void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }

        // Método para buscar un empleado por número de documento
        public Empleado BuscarEmpleadoPorDocumento(string numeroDocumento)
        {
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Comparando con el empleado {empleado.nombre} {empleado.apellido}");
                if (empleado.SosNumeroDoc(numeroDocumento))
                {
                    return empleado;
                }
            }
            return null; // Si no se encuentra ningún empleado con ese número de documento
        }
    }

}
