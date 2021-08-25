using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class Estado
    {
        public Estado()
        {
            Autos = new HashSet<Autos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
    }
}
