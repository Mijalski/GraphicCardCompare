using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationLogic.IGenerics.QueryServices
{
    public interface IQueryService<TEntity, TEntityDto>
    {
        TEntityDto Get(string name);
        IQueryable<TEntityDto> GetAll();
        
    }
}