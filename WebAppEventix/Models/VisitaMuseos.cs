using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppEventix.Models
{
    public class VisitaMuseos
    {
        [Key]
        public int VisitaMuseosId { get; set; }
        [Required]
        public string TituloVisita { get; set; }
        [Required]
        public string NombreMuseo { get; set; }
        [Required]
        public DateTime DiasCerrado { get; set; }
        public string ObrasDestacadas { get; set; }
        public float PrecioEntrada { get; set; }
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}