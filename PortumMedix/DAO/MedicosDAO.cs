using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using PortumMedix.Entitys;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PortumMedix.DAO
{
    public class MedicosDAO
    {
        private Dictionary<int, String> _Dictionary;
        private String _CadenaConexion = "server=64.22.74.88; database=mediportum; user Id=torreblanca; password=Esp1g408";
        public List<eMedicos> _ListaMedicos;
        public eMedicos _Medicos;
        private NpgsqlDataReader _reader;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<eMedicos> SelectMedicos()
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection();
                conexion = new NpgsqlConnection(this._CadenaConexion);

                //try
                //{
                //    var Query = "SELECT * FROM t_medicos";
                //    var cmd = new NpgsqlCommand(Query, conexion);
                //    conexion.Open();
                //    this._reader = cmd.ExecuteReader();
                //    this._ListaMedicos = new List<eMedicos>();
                //    if (this._reader.HasRows)
                //    {
                //        while (this._reader.Read())
                //        {
                //            this._Medicos = new eMedicos();
                //            this._Medicos.idMedico = (ObjectId)this._reader[0];
                //            this._Medicos.Nombre = this._reader[1].ToString();
                //            this._Medicos.ApellidoPaterno = this._reader[2].ToString();
                //            this._Medicos.ApellidoMaterno = this._reader[3].ToString();
                //            this._Medicos.Cedula = this._reader[4].ToString();
                //            this._Medicos.Correo = this._reader[5].ToString();
                //            this._Medicos.Especialidad = this._reader[6].ToString();
                //            this._ListaMedicos.Add(this._Medicos);
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    conexion.Close();
                //}

                return this._ListaMedicos;
            }
            catch
            {
                throw;
            }
            finally
            {
                this._ListaMedicos = null;
                this._reader = null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="idMedico"></param>
        /// <returns></returns>
        public Dictionary<int, String> SelectMedicoByID(int idMedico)
        {
            try
            {
                this._Dictionary = new Dictionary<int, string>();
                NpgsqlConnection conexion = new NpgsqlConnection();
                conexion = new NpgsqlConnection(this._CadenaConexion);

                if (!String.IsNullOrWhiteSpace(this._CadenaConexion))
                {
                    try
                    {
                        var Query = "SELECT * FROM t_medicos WHERE id = " + idMedico;
                        var cmd = new NpgsqlCommand(Query, conexion);
                        conexion.Open();
                        this._reader = cmd.ExecuteReader();

                        if(this._reader.HasRows)
                        {
                            while(this._reader.Read())
                            {
                                this._Dictionary.Add((int)this._reader[0], this._reader[1].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw;
                        conexion.Close();
                    }
                }

                return this._Dictionary;
            }
            catch
            {
                throw;
            }
            finally
            {
                this._Dictionary = null;
                this._reader = null;
            }
        }








    }
}