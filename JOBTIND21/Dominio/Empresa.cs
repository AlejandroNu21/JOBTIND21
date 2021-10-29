using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Dominio
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaId { get; set; }
        public string Nombre_Empresa { get; set; }
        public int TelefonoEmp { get; set; }
        public string EmailEmp { get; set; }
        public string ContraseñaEmp { get; set; }
        public string Vacante { get; set; }
        public int CategoriaID { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Anuncio> Anuncios { get; set; }

    }
}
