using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class Autos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Anio { get; set; }
        public string UserId { get; set; }
        public string Kilometraje { get; set; }
        public string TerminacionPlaca { get; set; }
        public int Cpuertas { get; set; }
        public string Provincia { get; set; }
        public string Color { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int? CombustibleId { get; set; }
        public int? EstadoId { get; set; }
        public int? MarcaId { get; set; }
        public int? ModeloId { get; set; }
        public int? TipoId { get; set; }
        public int? TransmisionId { get; set; }
        public string Imagen { get; set; }

        public virtual Combustible Combustible { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Marcas Marca { get; set; }
        public virtual Modelos Modelo { get; set; }
        public virtual TiposAutos Tipo { get; set; }
        public virtual Transmisiones Transmision { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}


