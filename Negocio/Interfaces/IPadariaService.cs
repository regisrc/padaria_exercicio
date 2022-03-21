using Negocio.Dto;
using Repositorio.Entidades;
using System;

namespace Negocio.Interfaces
{
    public interface IPadariaService
    {
        ComidaEntity Insert(ComidaDto comidaDto);

        ComidaRetornoDto GetById(Guid id);
    }
}
