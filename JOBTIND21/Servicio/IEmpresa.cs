using JOBTIND21.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Servicio
{
    public interface IEmpresa
    {
        void Guardar(Empresa E);

        void Delete(Empresa E);

        void Buscar(Empresa E);

        ICollection<Empresa> ListarEmpresas();
    }
}
