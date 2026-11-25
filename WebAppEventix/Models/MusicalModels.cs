using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppEventix.Models
{
    public class Musical
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string ActoresPrincipales { get; set; }
        [Required]
        public string Ciudad { get; set; }
        public string Lugar { get; set; }
        public string Productor { get; set; }
        public bool DiaDelEspectador { get; set; }
        public DateTime FechaHora { get; set; }
        public int DuracionEstimada { get; set; }
        public float PrecioMinimo { get; set; }
        public float PrecioMedio { get; set; }
        public float PrecioMaximo { get; set; }
        public string DescripcionPrecios { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}