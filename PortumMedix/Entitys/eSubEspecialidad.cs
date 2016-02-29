using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortumMedix.Entitys
{
    public class eSubEspecialidad
    {
        eSubEspecialidad()
        {
        }
        ~eSubEspecialidad()
        {
        }

        private String _subespecialidad;
        private String _cedula;


        public String subespecialidad
        {
            get { return this._subespecialidad; }
            set { this._subespecialidad = value; }
        }

        public String cedula
        {
            get { return this._cedula; }
            set { this._cedula = value; }
        }




    }
}