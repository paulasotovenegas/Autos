﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable
namespace FrontEnd.API.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Autos = new HashSet<Autos>();
        }

        public int Id{ get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Autos> Autos { get; set; }
    }
}
