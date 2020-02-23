using System;
using System.Threading.Tasks;
using ApplicationLogic.IGenerics;
using ApplicationLogic.IGenerics.CommandServices;
using AutoMapper;
using DomainLogic.IGenerics;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Generics.CommandServices
{
    public class CreateCommandService<TEntity, TEntityDto>  : ICreateCommandService<TEntity, TEntityDto>
        where TEntity : class, IEntity
        where TEntityDto : class, IEntityDto
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public CreateCommandService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
            _mapper = mapper  ?? throw new ArgumentException(nameof(mapper));
        }

        public TEntityDto Create(TEntityDto entityDto)
        {
            var mappedEntity = _mapper.Map<TEntity>(entityDto);

            _repository.Create(mappedEntity);

            entityDto = _mapper.Map<TEntityDto>(mappedEntity);

            return entityDto;
        }
    }
}