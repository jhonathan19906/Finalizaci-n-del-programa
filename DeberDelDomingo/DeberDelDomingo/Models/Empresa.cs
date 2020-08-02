using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberDelDomingo.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]

        public String Nombre { get; set; }
        public List<Celular> Celulares { get; private set; }

        public Celular CrearCelular()
        {
            string marca = "samsung";
            string modelo = "S7";

            Celular celular = new Celular(marca, modelo);
            Celulares.Add(celular);

            return celular;
        }
    }
}
