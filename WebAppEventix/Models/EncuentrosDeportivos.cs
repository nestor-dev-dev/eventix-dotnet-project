using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppEventix.Models
{
    public class EncuentrosDeportivos
    {
        [Key]
        public int EncuentrosDeportivosId { get; set; }
        [Required]
        public string Deporte {  get; set; }
        [Required]
        public string TituloPartido { get; set; }
        public string EquipoLocal {  get; set; }
        public string EquipoVisitante { get; set; }
        [Required]
        public string Ciudad { get; set; }
        public string Lugar { get; set; }
        public DateTime Fecha { get; set; }
        public float PrecioMinimo {  get; set; }
        public float PrecioMedio { get; set; }
        public float PrecioMaximo {  get; set; }
        public String UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}