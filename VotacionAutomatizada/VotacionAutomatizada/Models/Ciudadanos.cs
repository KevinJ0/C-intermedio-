using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Ciudadanos
    {

        [StringLength(11, MinimumLength = 11)]
        public string Id { get; set; }
        [StringLength(50)]
        public string nombre { get; set; }
        [StringLength(70)]
        public string apellido { get; set; }
        [StringLength(30)]
        public string correo { get; set; }
        public bool estado { get; set; }

      
    }
}
