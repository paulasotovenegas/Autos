using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FrontEnd.W2.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            Autos = new HashSet<Autos>();
            Modelos = new HashSet<Modelos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
        public virtual ICollection<Modelos> Modelos { get; set; }
    }
}
