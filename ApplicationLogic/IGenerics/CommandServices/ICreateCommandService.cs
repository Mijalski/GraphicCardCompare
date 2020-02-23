using System.Threading.Tasks;
using DomainLogic.IGenerics;

namespace ApplicationLogic.IGenerics.CommandServices
{
    public interface ICreateCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        TEntityDto Create(TEntityDto entityDto);
    }
}