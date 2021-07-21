using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IPetRepository
    { 
   
            List<Pet> ListarTodos();

            void Cadastrar(Pet novoPet);

            Pet BuscarPorId(int idPet);

            Pet AtualizarDados(int idPet, Pet petAtualizado);

            void Deletar(int idPet);
        }
    }
