using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using PortumMedix.Entitys;

namespace PortumMedix.Entitys
{
    public class eMedicos
    {
        public eMedicos()
        {

        }

        ~eMedicos()
        {

        }

        private ObjectId id;
        private String _nombre;
        private String _apaterno;
        private String _amaterno;
        private String _correo;
        private int _cedula;
        private DateTime _fecha_alta;
        private String _status;
        private List<eEspecialidad>  _especialidad;
        private List<eConsultorio> _consultorio;
        

        public ObjectId _id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public String apaterno
        {
            get { return this._apaterno; }
            set { this._apaterno = value; }
        }

        public String amaterno
        {
            get { return this._amaterno; }
            set { this._amaterno = value; }
        }
        public String correo
        {
            get { return this._correo; }
            set { this._correo = value; }
        }

        public int cedula
        {
            get { return this._cedula; }
            set { this._cedula = value; }
        }

        public DateTime fecha_alta
        {
            get { return this._fecha_alta; }
            set { this._fecha_alta = value; }
        }

        public String status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        public List<eEspecialidad> especialidad
        {
            get { return this._especialidad; }
            set { this._especialidad = value; }
        }

        public List<eConsultorio> consultorio
        {
            get { return this._consultorio; }
            set { this._consultorio = value; }
        }




    }
}