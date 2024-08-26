using System;
using System.Data.SqlClient;
using _06Publicaciones.config;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _06Publicaciones
{
    public class Jobs
    {
        public string IdJobs { get; set; }
        public string Direc_Jobs { get; set; }
        public string min { get; set; }
        public string max { get; set; }
     

        //solo para mostrar informacion
        public string NombreCompleto { get; set; }

        // Constructor vacío
        public Jobs() { }

        // Método para insertar un nuevo jobs y retornar el registro insertado
        public static Jobs Insertar(Jobs jobs)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO jobs (job_id,job_desc, min_lvl, max_lvl, job_id) " +
                                   "OUTPUT INSERTED.job_id, INSERTED.job_desc, INSERTED.min_lvl, INSERTED.max_lvl, " +
                                   "VALUES (@IdJobs, @Direc_Jobs, @min, @max";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdJobs", jobs.IdJobs);
                        comando.Parameters.AddWithValue("@Direc_Jobs", jobs.Direc_Jobs);
                        comando.Parameters.AddWithValue("@min", jobs.min);
                        comando.Parameters.AddWithValue("@max", jobs.max);
                       


                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Jobs
                                {
                                    IdJobs= lector["job_id"].ToString(),
                                    Direc_Jobs = lector["job_desc"].ToString(),
                                    min = lector["min_lvl"].ToString(),
                                    max = lector["max_lvl"].ToString(),
                                 

                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el jobs.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el jobs.");
            }
            return null;
        }

        // Método para actualizar un jobs existente y retornar "OK"
        public static string Actualizar(Jobs jobs)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE jobs SET job_desc = @Direc_Jobs, min_lvl = @min, max_lvl = @max, " +
                                   "job_id = @IdJobs, job_desc = @IdNivel WHERE job_id = @IdJobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdJobs", jobs.IdJobs);
                        comando.Parameters.AddWithValue("@Direc_Jobs", jobs.Direc_Jobs);
                        comando.Parameters.AddWithValue("@min", jobs.min);
                        comando.Parameters.AddWithValue("@max", jobs.max);
                       

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el jobs.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el jobs.");
                return "Error";
            }
        }

        // Método para eliminar un jobs y retornar "OK"
        public static string Eliminar(string IdJobs)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM jobs WHERE job_id = @IdJobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdJobs", IdJobs);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el jobs.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el jobs.");
                return "Error";
            }
        }

        // Método para obtener un jobs por ID
        public static Jobs ObtenerPorId(string IdJobs)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs WHERE job_id = @IdJobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdJobs", IdJobs);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Jobs
                                {
                                    IdJobs= lector["job_id"].ToString(),
                                    Direc_Jobs = lector["job_desc"].ToString(),
                                    min = lector["min_lvl"].ToString(),
                                    max = lector["max_lvl"].ToString(),
                                 
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el jobs.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el jobs.");
            }
            return null;
        }
        public static List<Jobs> ObtenerTodos()
        {
            var jobs = new List<Jobs>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                // public string NombreCompleto { get; set; }
                                /*
                                 * frm_Autor
                                 *   lst_Autores.DataSource = Jobs.ObtenerTodos();
                                       lst_Autores.DisplayMember = "NombreCompleto";
                                        lst_Autores.ValueMember = "IdJobs";
                                 */
                                jobs.Add(new Jobs
                                {
                                    IdJobs= lector["job_id"].ToString(),
                                    Direc_Jobs = lector["job_desc"].ToString(),
                                    min = lector["min_lvl"].ToString(),
                                    max = lector["max_lvl"].ToString(),
                                 
                                    NombreCompleto = lector["job_id"].ToString() + " " + lector["job_desc"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de jobs.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de jobs.");
            }

            return jobs;
        }
    }
}
  