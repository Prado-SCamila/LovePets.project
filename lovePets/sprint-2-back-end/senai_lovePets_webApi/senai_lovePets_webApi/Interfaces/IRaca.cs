using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IRaca
    {
        void Cadastrar(IRaca novaRaca);

        Raca AtualizarRaca(int id, IRaca racaAtualizada);

        Raca BuscarRaca(int id, IRaca racaBuscada);

        void Delete(int id);
    }
}
