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
        public int Id_Empresa { get; set; }
        public string Nombre_Empresa { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Vacante { get; set; }
    }
}
