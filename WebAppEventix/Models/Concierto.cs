using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebAppEventix.Models
{
    public class Concierto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Cantante { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Ciudad { get; set; }
        public string Lugar { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int Duracion { get; set; }
        public float PrcMin { get; set; }
        public float PrcMed { get; set; }
        public float PrcMax { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}