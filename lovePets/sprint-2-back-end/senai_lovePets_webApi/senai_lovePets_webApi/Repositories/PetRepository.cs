using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
        public class PetRepository : IPetRepository
        {
            lovePetsContext ctx = new lovePetsContext();

            public Pet AtualizarDados(int idPet, Pet petAtualizado)
            {
                throw new NotImplementedException();
            }

            public Pet BuscarPorId(int idPet)
            {
                throw new NotImplementedException();
            }


            public void Cadastrar(Pet novoPet)
            {
                ctx.Pets.Add(novoPet);

                ctx.SaveChanges();
            }

            public void Deletar(int idPet)
            {
                throw new NotImplementedException();
            }

            public List<Pet> ListarTodos()
            {
                throw new NotImplementedException();
            }
        }
    }