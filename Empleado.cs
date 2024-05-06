using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2Objetos
{
    internal class Empleado
    {
        //Declaración de variables privadas
        private string Nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo;

        //Generar constructor para crear una instacia de la clase donde toma
        //cuatro argumentos
        public Empleado(string Nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.Nombre = Nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }
        //Método que muesta los detalles del empleado y calcula el estado del empleado activo o inactivo.
        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {Nombre}, Número de Empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");

        }
        // Devuelve el número de empleado alamacenado.
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }
        //Cambia el estado del empleado según el valor proporcionado.
        //Muestra un mensaje  indicando si el empleado esta activo o desactivado y si 
        // se proporciona un valor diferente, muestranun mensaje de error; Estado no válido.
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true;
                Console.WriteLine("Empleado activado.");
            }
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no válido");
            }
        }

    }
}
