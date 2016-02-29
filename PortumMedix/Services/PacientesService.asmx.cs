using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PortumMedix.DAO;
using PortumMedix.Entitys;

namespace PortumMedix.Services
{
    /// <summary>
    /// Descripción breve de PacientesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class PacientesService : System.Web.Services.WebService
    {

        private List<ePacientes> _ListaPacientes;
        private PacientesDAO _PacientesDAO;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sNombre"></param>
        /// <param name="sApaterno"></param>
        /// <param name="sAmaterno"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        [WebMethod]
        public string ADMpacientes(String sNombre, String sApaterno, String sAmaterno, String Accion, String id, String sNombreCompletoR, String sCorreoR)
        {
            try
            {
                this._PacientesDAO = new PacientesDAO();

                return this._PacientesDAO.ADMpacientes(sNombre, sApaterno, sAmaterno, Accion, id, sNombreCompletoR, sCorreoR);
            }
            catch
            {
                throw;
            }
            finally
            {
                this._PacientesDAO = null;
            }
        }






    }
}
