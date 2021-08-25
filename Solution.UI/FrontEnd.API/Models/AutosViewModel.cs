using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.API.Models
{
    public class AutosViewModel
    {
        public List<Autos> Autos { get; set; }
        public SelectList Modelos { get; set; }
        public SelectList Marcas { get; set; }
        public SelectList Combustibles { get; set; }
        public SelectList Estados { get; set; }
        public SelectList Tipos { get; set; }
        public SelectList Transmisiones { get; set; }
        public int Modelo { get; set; }
        public int Marca { get; set; }
        public int Combustible { get; set; }
        public int Estado { get; set; }
        public int Tipo { get; set; }
        public int Transmision { get; set; }
    }
}
