using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class ClinicaRepository : IClinica

    {
        lovePetsContext ctx = new lovePetsContext();

        public Clinica AtualizarClinica(int id, Clinica clinicaAtual)
        {
            throw new NotImplementedException();
        }

        public Clinica BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }
    }
}
