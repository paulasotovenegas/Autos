using FrontEnd.API.Areas.Identity.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FrontEnd.API.Models
{
    public class Autos
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        [DisplayName("Año")]
        public int Anio { get; set; }

        [DisplayName("Usuario")]
        public string UserId { get; set; }
        public string Kilometraje { get; set; }

        [DisplayName("Terminación Placa")]
        public string TerminacionPlaca { get; set; }

        [DisplayName("# Puertas")]
        public int Cpuertas { get; set; }
        public string Provincia { get; set; }
        public string Color { get; set; }
        public DateTime FechaIngreso { get; set; }

        [DisplayName("Combustible")]
        public int? CombustibleId { get; set; }

        [DisplayName("Estado")]
        public int? EstadoId { get; set; }

        [DisplayName("Marca")]
        public int? MarcaId { get; set; }

        [DisplayName("Modelo")]
        public int? ModeloId { get; set; }

        [DisplayName("Tipo")]
        public int? TipoId { get; set; }

        [DisplayName("Transmisión")]
        public int? TransmisionId { get; set; }
        public string Imagen { get; set; }

        [NotMapped]
        [DisplayName("Imagen")]
        public IFormFile ImagenFile { get; set; }



        public  Combustible Combustible { get; set; }
        public  Estado Estado { get; set; }
        public  Marcas Marca { get; set; }
        public  Modelos Modelo { get; set; }
        public  TiposAutos Tipo { get; set; }
        public  Transmisiones Transmision { get; set; }
        public ApplicationUser User { get; set; }
    }
}
