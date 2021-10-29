using JOBTIND21.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Servicio
{
    public interface IUsuario
    {
        void Insertar(Usuario c);

        void Delete(Usuario c);

        void Buscar(Usuario c);

        ICollection<Usuario> ListarCursos();
    }
}
