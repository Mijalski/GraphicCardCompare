using System;
using System.Threading.Tasks;
using DomainLogic.Generics;
using DomainLogic.IGenerics;

namespace ApplicationLogic.IGenerics.CommandServices
{
    public interface IUpdateCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        TEntityDto Update(TEntityDto entityDto, Guid id);
    }
}