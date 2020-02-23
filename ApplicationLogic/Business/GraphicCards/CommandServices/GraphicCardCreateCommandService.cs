using ApplicationLogic.Generics.CommandServices;
using AutoMapper;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Vendors;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace ApplicationLogic.Business.GraphicCards.CommandServices
{
    public class GraphicCardCreateCommandService : CreateCommandService<GraphicCard, GraphicCardDto>
    {
        private readonly IRepository<Vendor> _vendorRepository;
        public GraphicCardCreateCommandService(IRepository<GraphicCard> repository, IMapper mapper, IRepository<Vendor> vendorRepository) 
            : base(repository, mapper)
        {
            _vendorRepository = vendorRepository;
        }

        public override GraphicCardDto Create(GraphicCardDto entityDto)
        {
            var mappedEntity = _mapper.Map<GraphicCard>(entityDto);

            var vendor = _vendorRepository.Get(entityDto.VendorName);

            mappedEntity.Vendor = vendor;
            _repository.Create(mappedEntity);

            entityDto = _mapper.Map<GraphicCardDto>(mappedEntity);

            return entityDto;
        }
    }
}