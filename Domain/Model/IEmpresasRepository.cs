using System;
using startehouse.api.Domain.DTO;

namespace startehouse.api.Domain.Model
{

    public interface IEmpresasRepository
    {
        void Add(Empresas Empresas);

        List<EmpresasDTO> Get();

        Empresas? Get(int id);
    }
}

