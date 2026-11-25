using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAppEventix.Models
{
    [AllowAnonymous]
    public class Opiniones
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TipoEntrada Entrada { get; set; }
        [Required]
        public TipoPuntuacion Voto { get; set; }


    }
    public enum TipoEntrada
    {
        Conciertos,
        Teatro,
        Musicales,
        Deportivos,
        Museo,
        Turistica
    }
    public enum TipoPuntuacion
    {
        Uno=1,
        Dos=2,
        Tres=3,
        Cuatro=4,
        Cinco=5

    }
}