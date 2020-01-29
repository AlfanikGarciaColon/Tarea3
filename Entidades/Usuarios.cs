using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace SistemaFarmacia.Entidades
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Nombre obligatorio")]

        public string Nombres { get; set; }

        //[Required]
        //[Range(ErroMessage = "El Email es obligatorio)"]

        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public DateTime FechaIngreso { get; set; }


    }
}
