using JOBTIND21.Data;
using JOBTIND21.Dominio;
using JOBTIND21.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Repositorio
{
    public class EmpresaRepositorio : IEmpresa
    {
        private ApplicationDbContext bd;

        public EmpresaRepositorio (ApplicationDbContext bd)
        {
            this.bd = bd;
        }
        public void Buscar(Empresa E)
        {
            bd.Empresas.Find(E);
        }

        public void Delete(Empresa E)
        {
            bd.Empresas.Remove(E);
        }

        public void Guardar(Empresa E)
        {
            bd.Empresas.Add(E);
            bd.SaveChanges();
        }

        public ICollection<Empresa> ListarEmpresas()
        {
            return bd.Empresas.ToList();
        }
    }
}
