using ApplicationLogic.Generics.AppServices;
using ApplicationLogic.IGenerics.CommandServices;
using ApplicationLogic.IGenerics.QueryServices;
using DomainLogic.Business.GraphicCards;

namespace ApplicationLogic.Business.GraphicCards
{
    public class GraphicCardAppService : AppService<GraphicCard, GraphicCardDto>
    {
        public GraphicCardAppService(ICreateCommandService<GraphicCard, GraphicCardDto> createCommandService,
            IQueryService<GraphicCard, GraphicCardDto> queryService, IUpdateCommandService<GraphicCard, GraphicCardDto> updateCommandService, 
            IDeleteCommandService<GraphicCard, GraphicCardDto> deleteCommandService) 
            : base(createCommandService, queryService, updateCommandService, deleteCommandService)
        {
        }
    }
}