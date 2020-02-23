using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationLogic.IGenerics.AppServices
{
    public interface IAppService<TEntity, TEntityDto>
    {
        List<TEntityDto> GetAll();
        TEntityDto Get(string name);
        TEntityDto Create(TEntityDto createdEntityDto);
        TEntityDto Update(TEntityDto createdEntityDto, string name);
        void Delete(TEntityDto createdEntityDto);
    }
}