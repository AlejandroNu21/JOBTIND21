using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Dominio
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Usuario { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        private string Contrasenia { get; set; }
        public string Especializacion { get; set; }

        public ICollection<Anuncio> Anuncios { get; set; }
    }
}
