using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FrontEnd.API.Models
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
