using System;

namespace ApplicationLogic.IGenerics
{
    public interface IEntityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}