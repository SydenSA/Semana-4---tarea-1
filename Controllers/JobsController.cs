using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _06Publicaciones.config;

namespace _06Publicaciones.Controllers
{
    public class jobController
    {
        // Método para insertar un jobs
        public Jobs InsertarEmployee(Jobs jobs)
        {
            return Jobs.Insertar(jobs);
        }

        // Método para actualizar un jobs
        public string ActualizarEmployee(Jobs jobs)
        {
            return Jobs.Actualizar(jobs);
        }

        // Método para eliminar un jobs
        public string EliminarEmployee(string IdJobs)
        {
            return Jobs.Eliminar(IdJobs);
        }

        // Método para obtener un jobs por ID
        public Jobs ObtenerEmployeePorId(string IdJobs)
        {
            return Jobs.ObtenerPorId(IdJobs);
        }

        // Método para obtener todos los autores (esto requiere que se agregue un método en la clase Jobs)
        public List<Jobs> ObtenerTodosEmployee()
        {
            return Jobs.ObtenerTodos();
        }
    }
}