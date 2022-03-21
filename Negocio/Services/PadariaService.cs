using Negocio.Dto;
using Negocio.Interfaces;
using Repositorio.Entidades;
using Repositorio.Interfaces;
using System;

namespace Negocio.Services
{
    public class PadariaService : IPadariaService
    {
        private readonly IComidaRepository _comidaRepository;

        public PadariaService(IComidaRepository comidaRepository)
        {
            _comidaRepository = comidaRepository;
        }

        public ComidaRetornoDto GetById(Guid id)
        {
            var result = _comidaRepository.GetById(id);

            return ComidaRetornoDto.DeComidaEntityParaComidaRetornoDto(result);
        }

        public ComidaEntity Insert(ComidaDto comidaDto)
        {
            var entidade = new ComidaEntity(comidaDto.Nome);

            _comidaRepository.Insert(entidade);

            return entidade;
        }
    }
}
