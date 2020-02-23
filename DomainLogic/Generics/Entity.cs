using System;
using DomainLogic.IGenerics;

namespace DomainLogic.Generics
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}