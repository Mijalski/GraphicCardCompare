using System;
using ApplicationLogic.Generics.CommandServices;
using AutoMapper;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Vendors;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Business.GraphicCards.CommandServices
{
    public class GraphicCardUpdateCommandService : UpdateCommandService<GraphicCard, GraphicCardDto>
    {
        private readonly IRepository<Vendor> _vendorRepository;
        public GraphicCardUpdateCommandService(IRepository<GraphicCard> repository, IMapper mapper, IRepository<Vendor> vendorRepository) 
            : base(repository, mapper)
        {
            _vendorRepository = vendorRepository;
        }

        public override GraphicCardDto Update(GraphicCardDto entityDto, Guid id)
        {
            var entity = _repository.Get(id);
            var vendor = _vendorRepository.Get(entityDto.VendorName);

            _mapper.Map(entityDto, entity);
            entity.Vendor = vendor;

            _repository.Update(entity);

            entityDto = _mapper.Map<GraphicCardDto>(entity);

            return entityDto;
        }
    }
}