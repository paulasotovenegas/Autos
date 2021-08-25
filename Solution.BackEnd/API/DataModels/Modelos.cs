using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class Modelos
    {
            public Modelos()
            {
           
            }

            public int Id { get; set; }
            public string Descripcion { get; set; }
            public int? MarcaId { get; set; }

        public  Marcas Marca { get; set; }

        }
    }
