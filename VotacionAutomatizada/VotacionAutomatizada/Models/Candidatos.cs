using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Candidatos
    {


        public int Id { get; set; }
        [StringLength(50)]
        public string nombre { get; set; }
        [StringLength(70)]
        public string apellido { get; set; }
        [StringLength(30)]
        //[Column("Partido Perteneciente")]
        [ForeignKey("Partidos_perteneciente")]
        public int IdPartidos { get; set; }
        [ForeignKey("IdPartidos")]
        public virtual Partidos Partidos { get; set; }
        [ForeignKey("Puesto_aspirante")]
        public int IdPuesto { get; set; }
        [ForeignKey("IdPuesto")]
        public virtual Puesto_electivo Puesto_electivo { get; set; }
        public string foto { get; set; }
        public bool estado { get; set; }


    }
}
