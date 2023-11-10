using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.Modelos.DTO
{
    public class CategoriaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}