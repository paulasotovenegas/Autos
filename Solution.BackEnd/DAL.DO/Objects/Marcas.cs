using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class Marcas
    {
        public Marcas()
        {
            Modelos = new HashSet<Modelos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
        public virtual ICollection<Modelos> Modelos { get; set; }
    }
}
