using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class RacaRepository : IRaca
    {
        lovePetsContext ctx = new lovePetsContext();
        public Raca AtualizarRaca(int id, IRaca racaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Raca BuscarRaca(int id, IRaca racaBuscada)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(IRaca novaRaca)
        {
            ctx.Racas.Add(novaRaca);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
