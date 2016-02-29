using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace PortumMedix.Entitys
{
    public class ePacientes
    {

        public ePacientes()
        {

        }

        ~ePacientes()
        {

        }

        private ObjectId id;
        private String _nombre;
        private String _apaterno;
        private String _amaterno;
        private DateTime _fecha_alta;
        private String _status;


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











    }
}