using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {
        lovePetsContext ctx = new lovePetsContext();

        public List<Veterinario> ListarTodos()
        {
            return ctx.Veterinarios.ToList();
        }
    }
}
