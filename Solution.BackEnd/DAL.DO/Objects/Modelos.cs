using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class Modelos
    {
        public Modelos()
        {
            Autos = new HashSet<Autos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? MarcaId { get; set; }

        public virtual Marcas Marca { get; set; }
        public virtual ICollection<Autos> Autos { get; set; }
    }
}
