using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortumMedix.DAO;
using PortumMedix.Entitys;
namespace PortumMedix.Controllers
{
    public class HomeController : Controller
    {

        private MedicosDAO _MedicosDAO;
        private List<eMedicos> _ListaMedicos;
        private PacientesDAO _PacientesDAO;
        private List<ePacientes> _ListaPacientes;


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Configuracion()
        {
            ViewBag.Message = "Configgg";
            return View();
        }

        public ActionResult Agenda()
        {
            ViewBag.Message = "Agenda";
            return View();
        }

        public ActionResult Pacientes()
        {
            try
            {
                //this._MedicosDAO = new MedicosDAO();
                //this._ListaMedicos = new List<eMedicos>();
                //this._ListaMedicos = this._MedicosDAO.SelectMedicos();

                this._PacientesDAO = new PacientesDAO();
                this._ListaPacientes = new List<ePacientes>();
                this._ListaPacientes = this._PacientesDAO.SelectPacientes();
                ViewData["Registros"] = this._ListaPacientes.Count.ToString();

                return View(this._ListaPacientes);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult Formatos()
        {
            ViewBag.Message = "Formatos";
            return View();
        }




    }
}