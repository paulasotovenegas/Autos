using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using FrontEnd.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using FrontEnd.API.Servicios;
using Microsoft.AspNetCore.Identity;
using FrontEnd.API.Areas.Identity.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FrontEnd.API.Controllers
{


    public class AutosController : Controller
    {
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        CombustibleServices serviciosCombustible = new CombustibleServices();
        EstadoServices serviciosEstado = new EstadoServices();
        MarcasServices serviciosMarcas = new MarcasServices();
        ModelosServices serviciosModelos = new ModelosServices();
        TiposAutosServices serviciosTiposAutos = new TiposAutosServices();
        TransmisionesServices serviciosTransmisiones = new TransmisionesServices();
        AutosServices serviciosAutos = new AutosServices();
        UserServices serviciosUsers = new UserServices();
        public AutosController(UserManager<ApplicationUser> userManager, IWebHostEnvironment _hostEnvironment)
        {
            _userManager = userManager;
            hostEnvironment = _hostEnvironment;
        }
        // GET: Autos
        public async Task<IActionResult> Index()
        {
            return View(serviciosAutos.GetAll().Where(m => m.UserId == _userManager.GetUserId(HttpContext.User)));
        }

        // GET: Autos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = GetByIdUser(id);

            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }
        [HttpPost]
        public JsonResult GetModeloMarca(int id)
        {
            List<Modelos> modelo = serviciosModelos.GetAll().Where(m => m.MarcaId == id).ToList();
            return Json(modelo);
        }

        // GET: Autos/Create
        public IActionResult Create()
        {
           
            
            ViewData["CombustibleId"] = new SelectList(serviciosCombustible.GetAll(), "Id", "Descripcion");
            ViewData["EstadoId"] = new SelectList(serviciosEstado.GetAll(), "Id", "Descripcion");
            ViewData["MarcaId"] = new SelectList(serviciosMarcas.GetAll(), "Id", "Descripcion");
            ViewData["ModeloId"] = new SelectList(serviciosModelos.GetAll(), "Id", "Descripcion");
            ViewData["TipoId"] = new SelectList(serviciosTiposAutos.GetAll(), "Id", "Descripcion");
            ViewData["TransmisionId"] = new SelectList(serviciosTransmisiones.GetAll(), "Id", "Descripcion");
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);

            return View();
        }
       

        // POST: Autos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Precio,Anio,UserId,Kilometraje,TerminacionPlaca,Cpuertas,Provincia,Color,FechaIngreso,CombustibleId,EstadoId,MarcaId,ModeloId,TipoId,TransmisionId,ImagenFile")] Autos autos)
        {
            if (ModelState.IsValid)
            {
                if (autos.ImagenFile != null)
                {
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(autos.ImagenFile.FileName);
                    string extension = Path.GetExtension(autos.ImagenFile.FileName);
                    autos.Imagen = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Image", filename);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await autos.ImagenFile.CopyToAsync(fileStream);
                    }
                }
                using (var cl = new HttpClient())
                {
                    cl.BaseAddress = new Uri(Program.baseurl);
                    var content = JsonConvert.SerializeObject(autos);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var postTask = cl.PostAsync("api/Autos", byteContent).Result;

                    if (postTask.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            ViewData["CombustibleId"] = new SelectList(serviciosCombustible.GetAll(), "Id", "Descripcion", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(serviciosEstado.GetAll(), "Id", "Descripcion", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(serviciosMarcas.GetAll(), "Id", "Descripcion", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(serviciosModelos.GetAll(), "Id", "Descripcion", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(serviciosTiposAutos.GetAll(), "Id", "Descripcion", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(serviciosTransmisiones.GetAll(), "Id", "Descripcion", autos.TransmisionId);
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);

            return View(autos);
        }

        // GET: Autos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = GetById(id);
            if (autos == null)
            {
                return NotFound();
            }
            ViewData["CombustibleId"] = new SelectList(serviciosCombustible.GetAll(), "Id", "Descripcion", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(serviciosEstado.GetAll(), "Id", "Descripcion", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(serviciosMarcas.GetAll(), "Id", "Descripcion", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(serviciosModelos.GetAll(), "Id", "Descripcion", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(serviciosTiposAutos.GetAll(), "Id", "Descripcion", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(serviciosTransmisiones.GetAll(), "Id", "Descripcion", autos.TransmisionId);
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            return View(autos);
        }

        // POST: Autos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Precio,Anio,UserId,Kilometraje,TerminacionPlaca,Cpuertas,Provincia,Color,FechaIngreso,CombustibleId,EstadoId,MarcaId,ModeloId,TipoId,TransmisionId,ImagenFile")] Autos autos)
        {
            if (id != autos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (autos.ImagenFile != null)
                    {
                        string wwwRootPath = hostEnvironment.WebRootPath;
                        string filename = Path.GetFileNameWithoutExtension(autos.ImagenFile.FileName);
                        string extension = Path.GetExtension(autos.ImagenFile.FileName);
                        autos.Imagen = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/Image", filename);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await autos.ImagenFile.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        var a = GetById(id);
                        autos.Imagen = a.Imagen;
                    }
                   
                       
                    using (var cl = new HttpClient())
                    {
                        cl.BaseAddress = new Uri(Program.baseurl);
                        var content = JsonConvert.SerializeObject(autos);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        var postTask = cl.PutAsync("api/Autos/" + id, byteContent).Result;

                        if (postTask.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception)
                {
                    var aux2 = GetById(id);
                    if (aux2 == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CombustibleId"] = new SelectList(serviciosCombustible.GetAll(), "Id", "Descripcion", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(serviciosEstado.GetAll(), "Id", "Descripcion", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(serviciosMarcas.GetAll(), "Id", "Descripcion", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(serviciosModelos.GetAll(), "Id", "Descripcion", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(serviciosTiposAutos.GetAll(), "Id", "Descripcion", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(serviciosTransmisiones.GetAll(), "Id", "Descripcion", autos.TransmisionId);
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            return View(autos);
        }


        // GET: Autos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = GetById(id);
               
            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }

        // POST: Autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autos = GetById(id);
            if (autos.Imagen != null)
            {
                var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image", autos.Imagen);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
            }
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/Autos/" + id);

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool AutosExists(int id)
        {
            return (GetById(id) != null);
        }

        private Autos GetById(int? id)
        {
            Autos aux = new Autos();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = cl.GetAsync("api/Autos/" + id).Result;

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Autos>(auxres);
                }
            }
            return aux;

        }

        public Autos GetByIdUser(int? id)
        {

            List<Autos> autos = serviciosAutos.GetAll().ToList();
            List<AspNetUsers> users = serviciosUsers.GetAll().ToList();

            var query = (from a in autos
                         join u in users on a.UserId equals u.Id
                         where a.Id == id
                         select a).FirstOrDefault();


            return query;

        }
    }
}
