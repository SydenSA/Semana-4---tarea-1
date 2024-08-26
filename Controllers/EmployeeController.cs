using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _06Publicaciones.config;

namespace _06Publicaciones.Controllers
{
    public class EmployeeController
    {
        // Método para insertar un employee
        public Employee InsertarEmployee(Employee employee)
        {
            return Employee.Insertar (employee);
        }

        // Método para actualizar un employee
        public string ActualizarEmployee(Employee employee)
        {
            return Employee.Actualizar(employee);
        }

        // Método para eliminar un employee
        public string EliminarEmployee(string IdEmployee)
        {
            return Employee.Eliminar(IdEmployee);
        }

        // Método para obtener un employee por ID
        public Employee ObtenerEmployeePorId(string IdEmployee)
        {
            return Employee.ObtenerPorId(IdEmployee);
        }

        // Método para obtener todos los autores (esto requiere que se agregue un método en la clase Employee)
        public List<Employee> ObtenerTodosEmployee()
        {
            return Employee.ObtenerTodos();
        }
    }
}
