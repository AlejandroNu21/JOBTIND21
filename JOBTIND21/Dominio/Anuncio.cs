using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Dominio
{
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Anuncio { get; set; }
        public int Id_Empresa { get; set; }
        public int Id_Usuario { get; set; }
        public string Anuncios { get; set; }

        public Usuario Usuario { get; set; }

        public Empresa Empresa { get; set; }
    }
}
