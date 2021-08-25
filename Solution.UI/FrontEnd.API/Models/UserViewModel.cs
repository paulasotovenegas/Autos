using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.API.Models
{
    public class UserViewModel
    {
        public AspNetUsers user { get; set; }

        public Autos auto { get; set; }
    }
}
