using Repositorio.Entidades;
using System;

namespace Negocio.Dto
{
    public class ComidaRetornoDto : ComidaBaseDto
    {
        public Guid Id { get; set; }

        public static ComidaRetornoDto DeComidaEntityParaComidaRetornoDto(ComidaEntity comidaEntity)
        {
            return new ComidaRetornoDto { Id = comidaEntity.Id, Nome = comidaEntity.Nome }; 
        }
    }
}
