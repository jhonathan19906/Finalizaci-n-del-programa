using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeberDelDomingo.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public Byte[] Fotografia { get; set; }
        public virtual List<Celular> Celulares { get; set; }
        //public virtual List<>
    }

}
