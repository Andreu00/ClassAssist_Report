using ClassAssistReport.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassAssistReport.DAO
{
    internal class DAOAlumno
    {
        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            conexion objetoConexion = new conexion();
            try
            {
                using (MySqlConnection connection = objetoConexion.establecerConexion())
                {
                    string query = "SELECT * FROM alumnos";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                alumnos.Add(new Alumno
                                {
                                    ID = reader.GetInt32("ID"),
                                    Nombre = reader.GetString("Nombre"),
                                    Apellidos = reader.GetString("Apellidos"),
                                    DNI = reader.GetString("DNI"),
                                    Email = reader.GetString("Email"),
                                    NumeroTelefono = reader.GetString("NumeroTelefono"),
                                    Curso = reader.IsDBNull(reader.GetOrdinal("Curso")) ? (int?)null : reader.GetInt32("Curso"),
                                    FechaDeNacimiento = reader.IsDBNull(reader.GetOrdinal("FechaDeNacimiento")) ? (DateTime?)null : reader.GetDateTime("FechaDeNacimiento"),
                                    TutoresID = reader.GetInt32("tutores_ID")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener alumnos: " + ex.Message);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
            return alumnos;
        }
    }
}
