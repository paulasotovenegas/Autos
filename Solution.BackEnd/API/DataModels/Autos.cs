using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class Autos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int Anio { get; set; }
        public string UserId { get; set; }
        public string Kilometraje { get; set; }
        public string TerminacionPlaca { get; set; }
        public int Cpuertas { get; set; }
        public string Provincia { get; set; }
        public string Color { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CombustibleId { get; set; }
        public int EstadoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int TipoId { get; set; }
        public int TransmisionId { get; set; }
        public string Imagen { get; set; }
        public  Combustible Combustible { get; set; }
            public  Estado Estado { get; set; }
            public  Modelos Modelo { get; set; }
            public  Marcas Marca { get; set; }
            public  TiposAutos Tipo { get; set; }
            public  Transmisiones Transmision { get; set; }
            public  AspNetUsers User { get; set; }
        }
    }
