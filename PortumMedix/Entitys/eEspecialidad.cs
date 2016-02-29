using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortumMedix.Entitys;

namespace PortumMedix.Entitys
{
    public class eEspecialidad
    {
        eEspecialidad()
        {

        }
        ~eEspecialidad()
        {

        }

        private String _especialdad;
        private int _cedula;
        private eSubEspecialidad _subespecialidad;


        public String especialidad
        {
            get { return this._especialdad; }
            set { this._especialdad = value; }
        }

        public int cedula
        {
            get { return this._cedula; }
            set { this._cedula = value; }
        }

        public eSubEspecialidad subespecialidad
        {
            get { return this._subespecialidad; }
            set { this._subespecialidad = value; }
        }


}
}