using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Partidos
    {

        [Key]
        public int IdPartidos { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string logo_partido { get; set; }

        public bool estado { get; set; }
    }
}
