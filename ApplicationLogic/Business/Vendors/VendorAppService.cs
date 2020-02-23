using ApplicationLogic.Business.GraphicCards;
using ApplicationLogic.Generics.AppServices;
using ApplicationLogic.IGenerics.CommandServices;
using ApplicationLogic.IGenerics.QueryServices;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Vendors;

namespace ApplicationLogic.Business.Vendors
{
    public class VendorAppService : AppService<Vendor, VendorDto>
    {
        public VendorAppService(ICreateCommandService<Vendor, VendorDto> createCommandService, IQueryService<Vendor, VendorDto> queryService,
            IUpdateCommandService<Vendor, VendorDto> updateCommandService, IDeleteCommandService<Vendor, VendorDto> deleteCommandService) 
            : base(createCommandService, queryService, updateCommandService, deleteCommandService)
        {
        }
    }
}