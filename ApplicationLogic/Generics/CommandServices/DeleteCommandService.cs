using System;
using System.Threading.Tasks;
using ApplicationLogic.IGenerics;
using ApplicationLogic.IGenerics.CommandServices;
using AutoMapper;
using DomainLogic.IGenerics;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Generics.CommandServices
{
    public class DeleteCommandService<TEntity, TEntityDto> : IDeleteCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public DeleteCommandService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
            _mapper = mapper  ?? throw new ArgumentException(nameof(mapper));
        }


        public virtual void Delete(TEntityDto entityDto)
        {
            var entity = _repository.Get(entityDto.Name);

            _repository.Delete(entity);
        }
    }
}