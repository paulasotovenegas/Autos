using FrontEnd.API.Data;
using FrontEnd.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.API.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class RolesController : Controller
    {
        
        private readonly RoleManager<IdentityRole> roleManager;

        private AutosVentasContext _context;

        public RolesController(RoleManager<IdentityRole> roleManager, AutosVentasContext context)
        {
            this.roleManager = roleManager;
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var roles = _context.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Roles rol)
        {
            var roleExist = await roleManager.RoleExistsAsync(rol.Descripcion);
            if(!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(rol.Descripcion));
            }
            return RedirectToAction("Index","Roles");
        }
    }
}
