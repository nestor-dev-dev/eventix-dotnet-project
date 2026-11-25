using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppEventix.Models
{
    public class VisitaTuristicaGuiada
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string TituloRecorrido { get; set; }
        public bool Pago { get; set; }
        public string AgenciaTourOperadora { get; set; }
        public TipoVisita Tipo { get; set; }
        public DateTime FechaHora {  get; set; } 
        public int DuracionEstimada { get; set; }
        public float Precio { get; set; }
        public string LugarInicio { get; set; }
        public string LugarFin {  get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public enum TipoVisita {
        APie,
        Patinete,
        Bici,
        Bus
    }
}