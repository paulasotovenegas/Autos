using FrontEnd.API.Areas.Identity.Data;
using FrontEnd.API.Data;
using FrontEnd.API.Models;
using FrontEnd.API.Servicios;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly AutosVentasContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        CombustibleServices serviciosCombustible = new CombustibleServices();
        EstadoServices serviciosEstado = new EstadoServices();
        MarcasServices serviciosMarcas = new MarcasServices();
        ModelosServices serviciosModelos = new ModelosServices();
        TiposAutosServices serviciosTiposAutos = new TiposAutosServices();
        TransmisionesServices serviciosTransmisiones = new TransmisionesServices();
        AutosServices serviciosAutos = new AutosServices();
        UserServices serviciosUsers = new UserServices();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, AutosVentasContext context)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        // GET: Movies
        public async Task<IActionResult> Index(int combustible, int estado, int marca, int modelo, int tipo, int transmision)
        {

            List<Autos> autos = serviciosAutos.GetAll().ToList();
            if (combustible != 0)
            {
            autos = serviciosAutos.GetAll().Where(m => m.CombustibleId == combustible).ToList();
            }
            if (estado != 0)
            {
              autos = serviciosAutos.GetAll().Where(m => m.EstadoId == estado).ToList();
            }
            if (marca != 0)
            {
                autos = serviciosAutos.GetAll().Where(m => m.MarcaId == marca).ToList();
            }
            if (modelo != 0)
            {
             autos = serviciosAutos.GetAll().Where(m => m.ModeloId == modelo).ToList();
            }
            if (tipo != 0)
            {
               autos = serviciosAutos.GetAll().Where(m => m.TipoId == tipo).ToList();
            }
            if (transmision != 0)
            {
                 autos = serviciosAutos.GetAll().Where(m => m.TransmisionId == transmision).ToList();
            }


            var autosB = new AutosViewModel
            {

                Combustibles = new SelectList(serviciosCombustible.GetAll(), "Id", "Descripcion"),
                Estados = new SelectList(serviciosEstado.GetAll(), "Id", "Descripcion"),
                Marcas = new SelectList(serviciosMarcas.GetAll(), "Id", "Descripcion"),
                Modelos = new SelectList(serviciosModelos.GetAll(), "Id", "Descripcion"),
                Tipos = new SelectList(serviciosTiposAutos.GetAll(), "Id", "Descripcion"),
                Transmisiones = new SelectList(serviciosTransmisiones.GetAll(), "Id", "Descripcion"),
                Autos =  autos.ToList()
            };

            return View(autosB);
        }

        public ActionResult Privacy()
        {    
           

                List<Autos> autos = serviciosAutos.GetAll().ToList();
                List<AspNetUsers> users = serviciosUsers.GetAll().ToList();


            var userRecord = from a in autos
                                 join u in users on a.UserId equals u.Id into table1
                                 from u in table1.ToList()
                                
                                 select new UserViewModel
                                 {
                                     auto = a,
                                     user = u
                                 };
                return View(userRecord);

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
