using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using ApplicationLogic.Business.GraphicCards;
using ApplicationLogic.Business.Specs;
using ApplicationLogic.Business.Vendors;
using ApplicationLogic.IGenerics.AppServices;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Specs;
using DomainLogic.Business.Vendors;
using Mijalski.GraphicCardCompare.Annotations;

namespace Mijalski.GraphicCardCompare
{
    public partial class MainWindow : Window, INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
