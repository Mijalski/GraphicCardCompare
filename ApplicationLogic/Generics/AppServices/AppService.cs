using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLogic.IGenerics;
using ApplicationLogic.IGenerics.AppServices;
using ApplicationLogic.IGenerics.CommandServices;
using ApplicationLogic.IGenerics.QueryServices;
using DomainLogic.IGenerics;
using Microsoft.EntityFrameworkCore;

namespace ApplicationLogic.Generics.AppServices
{
    public class AppService<TEntity, TEntityDto> : IAppService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        private readonly ICreateCommandService<TEntity, TEntityDto> _createCommandService;
        private readonly IUpdateCommandService<TEntity, TEntityDto> _updateCommandService;
        private readonly IDeleteCommandService<TEntity, TEntityDto> _deleteCommandService;
        private readonly IQueryService<TEntity, TEntityDto> _queryService;

        public AppService(ICreateCommandService<TEntity, TEntityDto> createCommandService,
            IQueryService<TEntity, TEntityDto> queryService, IUpdateCommandService<TEntity, TEntityDto> updateCommandService,
            IDeleteCommandService<TEntity, TEntityDto> deleteCommandService)
        {
            _createCommandService = createCommandService ?? throw new ArgumentNullException(nameof(createCommandService));
            _queryService = queryService ?? throw new ArgumentNullException(nameof(queryService));
            _updateCommandService = updateCommandService;
            _deleteCommandService = deleteCommandService;
        }

        public virtual List<TEntityDto> GetAll()
        {
            return _queryService
                .GetAll()
                .ToList();
        }

        public virtual TEntityDto Get(string name)
        {
            return _queryService.Get(name);
        }

        public virtual TEntityDto Create(TEntityDto createdEntityDto)
        {
            return _createCommandService.Create(createdEntityDto);
        }

        public virtual TEntityDto Update(TEntityDto createdEntityDto, string name)
        {
            return _updateCommandService.Update(createdEntityDto, name);
        }

        public virtual void Delete(TEntityDto createdEntityDto)
        {
            _deleteCommandService.Delete(createdEntityDto);
        }
    }
}