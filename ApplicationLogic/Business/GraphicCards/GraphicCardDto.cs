using System;
using ApplicationLogic.IGenerics;

namespace ApplicationLogic.Business.GraphicCards
{
    public class GraphicCardDto : IEntityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int RamCapacity { get; set; }
        public string RamType { get; set; }
        public string InterfaceType { get; set; }
        public string ProcessorSpeed { get; set; }
        public double Wattage { get; set; }
        public string VendorName { get; set; }
    }
}