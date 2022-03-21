using System;

namespace Repositorio.Entidades
{
    public class ComidaEntity : BaseEntity
    {
        public string Nome { get; set; }

        public ComidaEntity(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}
