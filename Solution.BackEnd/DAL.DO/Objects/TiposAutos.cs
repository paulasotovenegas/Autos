using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class TiposAutos
    {
        public TiposAutos()
        {
            Autos = new HashSet<Autos>();
        }

        public string Descripcion { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
    }
}
