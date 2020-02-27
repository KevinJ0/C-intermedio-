using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Eleciones
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_realizacion { get; set; }
        public bool estado { get; set; }

    }
}
