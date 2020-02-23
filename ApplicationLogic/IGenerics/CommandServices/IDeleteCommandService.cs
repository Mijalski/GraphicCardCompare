using System.Threading.Tasks;
using DomainLogic.IGenerics;

namespace ApplicationLogic.IGenerics.CommandServices
{
    public interface IDeleteCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        void Delete(TEntityDto entityDto);
    }
}