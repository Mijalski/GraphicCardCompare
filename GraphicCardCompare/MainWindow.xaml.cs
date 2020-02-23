using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ApplicationLogic.Business.GraphicCards;
using ApplicationLogic.Business.Specs;
using ApplicationLogic.Business.Vendors;
using ApplicationLogic.IGenerics.AppServices;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Specs;
using DomainLogic.Business.Vendors;
using Microsoft.EntityFrameworkCore.Internal;
using Mijalski.GraphicCardCompare.Annotations;

namespace Mijalski.GraphicCardCompare
{
    public partial class MainWindow : Window
    {
        public List<GraphicCardDto> GraphicCardList { get; set; }
        public List<VendorDto> VendorList { get; set; }

        private readonly IAppService<GraphicCard, GraphicCardDto> _graphicCardAppService;
        private readonly IAppService<Vendor, VendorDto> _vendorAppService;

        public MainWindow(IAppService<GraphicCard, GraphicCardDto> graphicCardAppService, IAppService<Vendor, VendorDto> vendorAppService)
        {
            _graphicCardAppService = graphicCardAppService;
            _vendorAppService = vendorAppService;
            InitializeComponent();
            DataContext = this;
            GraphicCardList = _graphicCardAppService.GetAll();
            VendorList = _vendorAppService.GetAll();
        }

        private void GraphicCardList_EditEnding(object? sender, DataGridRowEditEndingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void VendorList_EditEnding(object? sender, DataGridRowEditEndingEventArgs e)
        {
            if(VendorList.Any(x => x.Name == e.))
        }
    }
}
