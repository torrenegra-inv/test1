using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using PortumMedix.Entitys;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace PortumMedix.DAO
{
    public class PacientesDAO
    {

        private List<ePacientes> _ListaPacientes;
        private ePacientes _ePacientes;
        private String _CadenaConexionMONGO = "server=64.22.74.88; database=mediportum; user Id=torreblanca; password=Esp1g408";
        private ePacientes _Pacientes;
        private NpgsqlDataReader _reader;
       

        public List<ePacientes> SelectPacientes()
        {
            try
            {
                this._ListaPacientes = new List<ePacientes>();

                MongoUrl _CadenaConexionMONGO = new MongoUrl("mongodb://torreblanca:M3d1P0r@64.22.74.88:27019");

                MongoClient clienteMONGO = new MongoClient(this._CadenaConexionMONGO);

                MongoServer servidorMONGO = clienteMONGO.GetServer();

                MongoDatabase BASEmediportum = servidorMONGO.GetDatabase("mediportum");

                var ColeccionMedicos = BASEmediportum.GetCollection<ePacientes>("pacientes");

                MongoCursor<ePacientes> _epacientes = ColeccionMedicos.FindAll();


                this._ListaPacientes = _epacientes.ToList<ePacientes>();

                //var Medico = new BsonDocument
                //{
                //    { "nombre" , "Nestor Arturo" },
                //    { "apaterno" , "Ramirez"},
                //    { "amaterno" , "Moreno" },
                //    { "correo" , "nramirez@gruposqs.com" },
                //    { "cedula" , 888888 },
                //    { "fecha_alta" , DateTime.Now },
                //    { "status" , "activo" },
                //    { "especialidad", new BsonArray
                //        {
                //        new BsonDocument
                //            {
                //                { "especialidad","Enfermero"},
                //                { "cedula",8888888},
                //                { "subespecialidad",new BsonDocument
                //                    {
                //                        { "subespecialidad", "Cuidado de pacientes" },
                //                        { "cedula" ,"" }
                //                    }
                //                }
                //            }
                //        }
                //    },
                //    { "consultorio", new BsonArray
                //        {
                //        new BsonDocument
                //            {
                //                { "direccion","Aqua"},
                //                { "ciudad","Medellin"},
                //                { "estado","Veracruz"},
                //                { "cp",11111},
                //                { "consultorio","1"},
                //                { "horario","08:00 - 16:00"},
                //                { "loc","Paseos del campestre"},
                //                { "referencia","luna bella"}
                //             }
                //        }
                //    }
                //};
                //ColeccionMedicos.Insert(Medico);



                return this._ListaPacientes;
            }
            catch
            {
                throw;
            }
            finally
            {
                this._ListaPacientes = null;
                this._reader = null;
            }
        }

        public String ADMpacientes(String sNombre, String sApaterno, String sAmaterno, String Accion, String id, String sNombreCompletoR, String sCorreoR)
        {
            try
            {
                using (NpgsqlConnection Conexion = new NpgsqlConnection(this._CadenaConexionMONGO))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("spadmpacientes", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_nombre", sNombre);
                    cmd.Parameters.AddWithValue("_apaterno", sApaterno);
                    cmd.Parameters.AddWithValue("_amaterno", sAmaterno);
                    cmd.Parameters.AddWithValue("_accion", Convert.ToInt32(Accion));
                    cmd.Parameters.AddWithValue("_id", Convert.ToInt32(id));
                    cmd.Parameters.Add("_salida", NpgsqlTypes.NpgsqlDbType.Text, 100);
                    cmd.Parameters["_salida"].Direction = System.Data.ParameterDirection.Output;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();

                    return cmd.Parameters["_salida"].Value.ToString();
                }
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }








    }
}