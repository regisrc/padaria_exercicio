using Repositorio.Entidades;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;

namespace Repositorio.Repositorios
{
    public class ComidaRepository : IComidaRepository
    {
        private List<ComidaEntity> ListaEntidade;

        public ComidaRepository()
        {
            ListaEntidade = new List<ComidaEntity>();
        }

        public ComidaEntity GetById(Guid id)
        {
            return ListaEntidade.Find(x => x.Id == id);
        }

        public void Insert(ComidaEntity comidaEntity)
        {
            ListaEntidade.Add(comidaEntity);
        }
    }
}
