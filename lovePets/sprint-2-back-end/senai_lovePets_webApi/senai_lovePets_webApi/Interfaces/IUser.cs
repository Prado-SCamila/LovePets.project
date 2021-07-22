using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IUser
    {
        public void Cadastrar(int idUsuario, Usuario novoUsuario);



        public void Deletar(int idUsuario);
      
    }
}
