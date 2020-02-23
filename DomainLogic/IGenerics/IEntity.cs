using System;

namespace DomainLogic.IGenerics
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}