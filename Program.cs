using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se muestra el mensaje
            Console.WriteLine("Aplicación de gestión de Empleados");

            //Creamos una lista llamada listaEmpleados que contendra instacias o objetos de la clase Empleado.
            List<Empleado> listaEmpleados = new List<Empleado>();

            //Crea un nuevo objeto Empleado con los valores asiganados  y se añaden a la lísta empleados
            //3 empleados
            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("María", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));

            //Recorre la lista de empleados mediante un bucle y muestra los detalles mediante el método del objeto DEmpleado
            //variable empleado auxiliar
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            // Se define un numero de empleado 
            int numeroEmpleadoCambiarEstado = 103;
            // se llama al método BuscarEmpledo poniendo listaEmpleados y numeroEmpleadoCambiaEstado como argumento
            //el método BuscarEmpleado recorre la listaEmpleados y devuelve el empleado cuyo 
            //número coincide con el proporcionado
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            //Cambio de estado del Empleado
            //si se encuentra el número proporcionado, se cambia su estado llamando al metodoCambiarEstado(1)
            //en este caso activo y luego se muestra la información actualizada llamando al método MostrarDetalles()
            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                Console.WriteLine($"Empleaado con número {numeroEmpleadoCambiarEstado} no encontrado.");
            }
            // si no, se muestra el mensaje Empleado con número no encontrado. 

        }
        //método estatico
        //BuscarEmpleado toma dos argumentos; empleados de una lista de objetos de tipo Empleado
        //y numeroEmpleado que representa el número del empleado que desea buscar
        //luego recorre la listaEmpleado con un bucle foreach donde para cada empleado en la lista
        //compara el número de empleado con el número proporcionado; si se encuentra el empleado con el número asignado
        //devuelve el objeto empleado si no devuelve null.
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }
            return null;
        }
    }
}
