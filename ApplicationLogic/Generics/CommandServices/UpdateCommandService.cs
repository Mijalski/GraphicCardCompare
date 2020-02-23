using System;
using ApplicationLogic.IGenerics;
using ApplicationLogic.IGenerics.CommandServices;
using AutoMapper;
using DomainLogic.IGenerics;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Generics.CommandServices
{
    public class UpdateCommandService<TEntity, TEntityDto> : IUpdateCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public UpdateCommandService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
            _mapper = mapper  ?? throw new ArgumentException(nameof(mapper));
        }


        public virtual TEntityDto Update(TEntityDto entityDto, string name)
        {
            var entity = _repository.Get(name);

            _mapper.Map(entity, entityDto);

            _repository.Update(entity);

            entityDto = _mapper.Map<TEntityDto>(entity);

            return entityDto;
        }
    }
}