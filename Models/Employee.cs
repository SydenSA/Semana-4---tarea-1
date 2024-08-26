using System;
using System.Data.SqlClient;
using _06Publicaciones.config;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _06Publicaciones
{
    public class Employee
    {
        public string IdEmployee { get; set; }
        public string Nombre_em{ get; set; }
        public string Minit { get; set; }
        public string  Apellido_em { get; set; }
        public string Idtrabajo { get; set; }
        public string IdNivel { get; set; }
        public string IdPub { get; set; }
        public string contrato_em { get; set; }
     
        //solo para mostrar informacion
        public string NombreCompleto { get; set; }

        // Constructor vacío
        public Employee() { }

        // Método para insertar un nuevo employee y retornar el registro insertado
        public static Employee Insertar(Employee employee)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO employee (emp_id,fname, minit, lname, job_id, job_lvl, pub_id, hire_date) " +
                                   "OUTPUT INSERTED.emp_id, INSERTED.fname, INSERTED.minit, INSERTED.lname, " +
                                   "INSERTED.job_id, INSERTED.job_lvl, INSERTED.pub_id, INSERTED.hire_date " +
                                   "VALUES (@IdEmployee, @Nombre_em, @Minit, @Apellido_em, @Idtrabajo, @IdNivel, @IdPub, @contrato_em";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmployee", employee.IdEmployee);
                        comando.Parameters.AddWithValue("@Nombre_em", employee.Nombre_em);
                        comando.Parameters.AddWithValue("@Minit", employee.Minit);
                        comando.Parameters.AddWithValue("@Apellido_em", employee.Apellido_em);
                        comando.Parameters.AddWithValue("@Idtrabajo", employee.Idtrabajo);
                        comando.Parameters.AddWithValue("@IdNivel", employee.IdNivel);
                        comando.Parameters.AddWithValue("@IdPub", employee.IdPub);
                        comando.Parameters.AddWithValue("@contrato_em", employee.contrato_em);
                  

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Employee
                                {
                                    IdEmployee = lector["emp_id"].ToString(),
                                    Nombre_em = lector["fname"].ToString(),
                                    Minit = lector["minit"].ToString(),
                                    Apellido_em = lector["lname"].ToString(),
                                    Idtrabajo = lector["job_id"].ToString(),
                                    IdNivel = lector["job_lvl"].ToString(),
                                    IdPub = lector["pub_id"].ToString(),
                                    contrato_em = lector["hire_date"].ToString(),

                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el employee.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el employee.");
            }
            return null;
        }

        // Método para actualizar un employee existente y retornar "OK"
        public static string Actualizar(Employee employee)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE employee SET fname = @Nombre_em, minit = @Minit, lname = @Apellido_em, " +
                                   "job_id = @Idtrabajo, job_lvl = @IdNivel, pub_id = @IdPub, hire_date = @contrato_em WHERE emp_id = @IdEmployee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdEmployee", employee.IdEmployee);
                        comando.Parameters.AddWithValue("@Nombre_em", employee.Nombre_em);
                        comando.Parameters.AddWithValue("@Minit", employee.Minit);
                        comando.Parameters.AddWithValue("@Apellido_em", employee.Apellido_em);
                        comando.Parameters.AddWithValue("@Idtrabajo", employee.Idtrabajo);
                        comando.Parameters.AddWithValue("@IdNivel", employee.IdNivel);
                        comando.Parameters.AddWithValue("@IdPub", employee.IdPub);
                        comando.Parameters.AddWithValue("@contrato_em", employee.contrato_em);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el employee.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el employee.");
                return "Error";
            }
        }

        // Método para eliminar un employee y retornar "OK"
        public static string Eliminar(string idEmployee)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM employee WHERE emp_id = @IdEmployee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmployee", idEmployee);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el employee.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el employee.");
                return "Error";
            }
        }

        // Método para obtener un employee por ID
        public static Employee ObtenerPorId(string idEmployee)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee WHERE emp_id = @IdEmployee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmployee", idEmployee);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Employee
                                {
                                    IdEmployee = lector["emp_id"].ToString(),
                                    Nombre_em = lector["fname"].ToString(),
                                    Minit = lector["minit"].ToString(),
                                    Apellido_em = lector["lname"].ToString(),
                                    Idtrabajo = lector["job_id"].ToString(),
                                    IdNivel = lector["job_lvl"].ToString(),
                                    IdPub = lector["pub_id"].ToString(),
                                    contrato_em = lector["hire_date"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el employee.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el employee.");
            }
            return null;
        }
        public static List<Employee> ObtenerTodos()
        {
            var empleados = new List<Employee>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                // public string NombreCompleto { get; set; }
                                /*
                                 * frm_Autor
                                 *   lst_Autores.DataSource = Employee.ObtenerTodos();
                                       lst_Autores.DisplayMember = "NombreCompleto";
                                        lst_Autores.ValueMember = "IdEmployee";
                                 */
                                empleados.Add(new Employee
                                {
                                    IdEmployee = lector["emp_id"].ToString(),
                                    Nombre_em = lector["fname"].ToString(),
                                    Minit = lector["minit"].ToString(),
                                    Apellido_em = lector["lname"].ToString(),
                                    Idtrabajo = lector["job_id"].ToString(),
                                    IdNivel = lector["job_lvl"].ToString(),
                                    IdPub = lector["pub_id"].ToString(),
                                    contrato_em = lector["hire_date"].ToString(),
                                    NombreCompleto = lector["lname"].ToString() + " " + lector["fname"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de empleados.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de empleados.");
            }

            return empleados;
        }
    }
}