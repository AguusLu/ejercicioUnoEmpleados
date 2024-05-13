using ejercicioUnoPersonas.Models;

class Program
{
    static void Main(string[] args)
    {
        // Crear algunos tipos de documento
        TipoDocumento dni = new TipoDocumento("DNI");
        TipoDocumento pasaporte = new TipoDocumento("Pasaporte");

        // Crear algunos puestos
        Puesto gerente = new Puesto("Gerente", "Responsable de la gestión general de la fábrica");
        Puesto operario = new Puesto("Operario", "Encargado de realizar tareas de producción");

        // Crear empleados con tipos de documento asignados


        Empleado empleado1 = new Empleado("Juan", "Perez", new DateTime(1990, 5, 15), "12345678", dni, gerente);
        Empleado empleado2 = new Empleado("Maria", "Gomez", new DateTime(1985, 10, 20), "87654321", dni, operario);

        // Crear la instancia de la clase Administradora y agregar empleados
        Administradora administradora = new Administradora();
        administradora.agregarEmpleado(empleado1);
        administradora.agregarEmpleado(empleado2);

        // Buscar un empleado por número de documento
        Empleado empleadoEncontrado = administradora.buscarEmpleadoPorDocumento("12345678");
        if (empleadoEncontrado != null)
        {
            Console.WriteLine("Empleado encontrado:");
            Console.WriteLine("Nombre: {0}", empleadoEncontrado.nombre);
            Console.WriteLine("Apellido: {0}", empleadoEncontrado.apellido);
            Console.WriteLine("Fecha de Nacimiento: {0}", empleadoEncontrado.fechaNacimiento.ToShortDateString());
            Console.WriteLine("Número de Documento: {0}", empleadoEncontrado.numeroDocumento);
            if (empleadoEncontrado.tipoDocumento != null)
            {
                Console.WriteLine("Tipo de Documento: {0}", empleadoEncontrado.tipoDocumento?.tipo);
            }
            else
            {
                Console.WriteLine("El tipo de documento del empleado encontrado es null.");
            }
            if (empleadoEncontrado.puesto != null)
            {
                Console.WriteLine("Puesto: {0}", empleadoEncontrado.puesto?.nombre);
            }
            else
            {
                Console.WriteLine("El puesto del empleado encontrado es null.");
            }
        }
        else
        {
            Console.WriteLine("No se encontró ningún empleado con ese número de documento.");
        }
    }
}
