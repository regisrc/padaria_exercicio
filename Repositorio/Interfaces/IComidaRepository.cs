using Repositorio.Entidades;
using System;

namespace Repositorio.Interfaces
{
    public interface IComidaRepository
    {
        void Insert(ComidaEntity comidaEntity);

        ComidaEntity GetById(Guid id);
    }
}
