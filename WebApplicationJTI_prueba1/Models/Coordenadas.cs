using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationJTI_prueba1.Models
{
    public class Coordenadas
    {
        public int CoordenadasID { get; set; }
        [Required]
        public float Latitud { get; set; }
        [Required]
        public float Longitud { get; set; }
        [Required]
        public DateTime FechaHora { get; set; }
    }
}
