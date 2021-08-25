using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FrontEnd.W2.Models
{
    public partial class Transmisiones
    {
        public Transmisiones()
        {
            Autos = new HashSet<Autos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
    }
}
