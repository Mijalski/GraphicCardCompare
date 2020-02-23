using System;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLogic.IGenerics.QueryServices;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DomainLogic.Generics;
using Microsoft.EntityFrameworkCore;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Generics.QueryServices
{
    public class QueryService<TEntity, TEntityDto> : IQueryService<TEntity, TEntityDto>
        where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public QueryService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public TEntityDto Get(string name)
        {
            return _repository
                .GetAll()
                .AsNoTracking()
                .Where(_ => _.Name == name)
                .ProjectTo<TEntityDto>(_mapper.ConfigurationProvider)
                .Single();
        }

        public IQueryable<TEntityDto> GetAll()
        {
            return _repository
                .GetAll()
                .AsNoTracking()
                .ProjectTo<TEntityDto>(_mapper.ConfigurationProvider);
        }
    }
}